#include <set>
#include <map>
#include <fstream>
#include <sstream>
#include <iostream>
#include <string.h>
#include <iterator>

#include <boost/unordered_map.hpp>

#include <exo/linux.hpp>
#include <exo/exception.hpp>
#include <exo/format_header/exe.hpp>
#include <exo/util/count_of.hpp>

#include "x86/memory.hpp"
#include "x86/registers.hpp"
#include "x86/bin_to_cxx.hpp"
#include "x86/instructions.hpp"
#include "program/raw_program.hpp"

#include "dos/dma.hpp"
#include "dos/timer.hpp"
#include "dos/memory.hpp"
#include "dos/interrupt.hpp"


namespace raw_program {

using namespace exo;
using namespace dos;
using namespace x86;


using namespace exo::linux;
using exo::format_header::exe_dos;


bool extra_log = false;


// +
struct func_info
{
    /** Адрес вызываемой функции (уже декодированной). */
    void (*func)();

    /** Исходный бинарный код функции. Если код не известен (по каким-то причинам), то \a code.is_empty() должен быть равен true. */
    exo::memory_space_const code;

    /** Имя функции C++ без namespace. Например: "func_0x101354f7". */
    exo::memory_space_const func_name;

    /** Разрядность декодируемого кода. 16 или 32 бит. */
    uint_<8> mode;

    func_info(void (*func_)(), uint_<8> mode_)
    : func(func_)
    , code()
    , func_name()
    , mode(mode_)
    {}

    func_info(void (*func_)(), exo::memory_space_const func_name_, exo::memory_space_const code_, uint_<8> mode_)
    : func(func_)
    , code(code_)
    , func_name(func_name_)
    , mode(mode_)
    {}
};



const char * file_name = "../orig_max/MAXRUN.EXE";
const uint_<16> image_load_seg = 0x1a2; // Const from dosbox.
const uint_<16> pspseg = image_load_seg - 16; // 0x192


// +
//static boost::unordered_multimap<uint_<32>, func_info> funcs_by_pc;
static std::multimap<uint_<32>, func_info> funcs_by_pc;


// @todo rename to 'funcs_any_time_runs'. Функции, когда либо запускавшиеся.
static std::pair<uint_<32>, uint_<8>> used_funcs_known[] = {
#define INFO(a, b)  {a, b},
#include "program/info/funcs_any_time_runs.hpp"
#undef INFO
};


void debug_breakpoint() {}

// +
static func_info * find_func_exact(seg_reg & seg, uint_<32> addr)
{
    auto range_iter = funcs_by_pc.equal_range(seg.get_base() + addr);

    for (auto iter = range_iter.first; iter != range_iter.second; iter++)
    {
        if (iter -> second.mode != (cs.get_db() ? 32 : 16))
            continue;

        if (mem_pg_equals(seg.get_base() + addr, iter -> second.code))
            return & iter -> second;
    }

    return NULL;
}

static func_info * find_func_from_known_and_remember_it(seg_reg & seg, uint_<32> addr)
{
    // Попробуем найти её среди известных.

    for (auto & val: funcs_by_pc)
    {
        if (val.second.code.is_empty())
            continue;

        if (val.second.func_name.is_empty())
            throw std::logic_error("Код у функции есть, а его имя неизвестно.");

        if (val.second.mode != (cs.get_db() ? 32 : 16))
            continue;

        if (mem_pg_equals(seg.get_base() + addr, val.second.code) == false)
            continue;


        // Всё хорошо. Запомним её, а затем сохраним в файл, чтоб в следующий раз не пришлось искать.

        funcs_by_pc.insert(std::make_pair(seg.get_base() + addr, val.second));


        std::fstream output("program/auto/link.cpp", std::ios_base::app | std::ios_base::out);
        output << std::hex << std::showbase;


        output << "LINK(";
        /*bin_to_cxx::*/write_addr_with_check_known_definitions(output, seg.get_base() + addr, true, true);
        output << ", " << val.second.func_name << ", " << static_cast<uint_<16>>(val.second.mode);
        output << ", ({";


        for (uint_<32> i = 0; i < val.second.code.size() - 1; i++)
            output << val.second.code.get<uint_<8>, uint_<32>>(i) << ", ";
        output << val.second.code.get<uint_<8>, uint_<32>>(val.second.code.size() - 1);

        output << "}))\n\n";

        return & val.second;
    }

    return NULL;
}

static void decode_function(seg_reg & seg, uint_<32> short_addr)
{
//    exit(1); // "--on-unknown-func={decode-and-exit, exit}"
    bin_to_cxx to_cxx(seg.get_db() ? 32 : 16, mem_pg_raw, seg.get_base(), ds.get_base());

    if (seg.get_base() != 0)
        to_cxx.add_region_to_suppress_decode(0, seg.get_base());

    if (static_cast<uint_<32>>(seg.get_base() + seg.get_limit() + 1) != 0)
        to_cxx.add_region_to_suppress_decode(seg.get_base() + seg.get_limit() + 1, 0);


    /* Аргументы следующим методам установлены опытным путём. */

    to_cxx.set_string_data_area(0x101a0003, 0x101b384d);

    to_cxx.force_end_funcs().insert(0x14b5b5);
    to_cxx.force_end_funcs().insert(0x14edfc);
    to_cxx.force_end_funcs().insert(0x14f88b);
    to_cxx.force_end_funcs().insert(0x14f8ef);
    to_cxx.force_end_funcs().insert(0x158748);


    auto & ns_syslib = defualt_namespace_by_addr[0x10165d52];
    ns_syslib.first = 0x1019c3cd + 1;
    ns_syslib.second.push_back("sys");


    for (auto & i : funcs_by_pc)
        if (i.second.mode == (cs.get_db() ? 32 : 16))
            to_cxx.already_decoded_funcs_insert(i.first, i.second.code);
    to_cxx.already_decoded_funcs_erase(seg.get_base() + short_addr); // force decode.


#if 0
    // Замечено, что многие функции начинаются со следующих двух команд.

    {0x68, 0x28, 0, 0, 0,  0xe8, 0x90, 0xa1, 0xb, 0}
    II(0x100abbb8, 0x5)   pushd(0x28);                          /* push dword 0x28 */
    II(0x100abbbd, 0x5)   calld(sys_check_available_stack_size, 0xba190); /* call 0x10165d52 */
#endif
#if 1
    const addr_type code_start = 0x10070000;
    const addr_type code_end = 0x10165d52;


    static bool its_first = true;
    if (cs.get_base() == 0 && cs.get_db() && its_first)
    {
        its_first = false;

        memory_space_const code;
        for (addr_type i = code_start; i < code_end; i++)
        {
            if (code.is_empty())
                code = mem_seg_pg_raw(seg, i, 1);

            if (code.get<uint_<8>>() == 0x68)
            {
                code = mem_seg_pg_raw(seg, i, 10);
                if (code.get<uint_<8>>(0, 5) == 0xe8 && (code.get<uint_<32>>(0, 6) + i + 10 == 0x10165d52)
                        && funcs_by_pc.find(i) == funcs_by_pc.end())
                    to_cxx.decode_func(i);
            }

            code = code.remove_prefix(1);
        }

        // extra
        to_cxx.decode_func(0x101481d4);
        to_cxx.decode_func(0x10165d4a);
        to_cxx.decode_func(0x10165eee);
        to_cxx.decode_func(0x1016609c);
        to_cxx.decode_func(0x10166114);
        to_cxx.decode_func(0x10168624);
        to_cxx.decode_func(0x10168690);
        to_cxx.decode_func(0x10168698);
        to_cxx.decode_func(0x1016a21c);
        to_cxx.decode_func(0x1016a320);
        to_cxx.decode_func(0x1016a4c4);
        to_cxx.decode_func(0x1016a4d0);
        to_cxx.decode_func(0x1016a514);
        to_cxx.decode_func(0x1016a568);
        to_cxx.decode_func(0x1016c9d0);
        to_cxx.decode_func(0x1016c9dc);
        to_cxx.decode_func(0x101712d0);
        to_cxx.decode_func(0x101714e0);
        to_cxx.decode_func(0x10171680);
        to_cxx.decode_func(0x10171810);
        to_cxx.decode_func(0x10171834);
        to_cxx.decode_func(0x10171c5c);
        to_cxx.decode_func(0x10172d9c);
        to_cxx.decode_func(0x10179690);
        to_cxx.decode_func(0x10179a00);
        to_cxx.decode_func(0x10179b80);
        to_cxx.decode_func(0x1017de6f);
        to_cxx.decode_func(0x1017df39);
        to_cxx.decode_func(0x10181cc4);
        to_cxx.decode_func(0x10181cc8);
        to_cxx.decode_func(0x10181ce1);
        to_cxx.decode_func(0x10181ce6);
        to_cxx.decode_func(0x10181f92);
        to_cxx.decode_func(0x10181fae);
        to_cxx.decode_func(0x10181fde);
        to_cxx.decode_func(0x101820a9);
        to_cxx.decode_func(0x101820c6);
        to_cxx.decode_func(0x10182113);
        to_cxx.decode_func(0x10182212);
        to_cxx.decode_func(0x1018224d);
        to_cxx.decode_func(0x10187ac2);
        to_cxx.decode_func(0x10187ad4);
        to_cxx.decode_func(0x10187b25);
        to_cxx.decode_func(0x10187b2b);
        to_cxx.decode_func(0x1018c980);
        to_cxx.decode_func(0x1018ca00);
        to_cxx.decode_func(0x1018cda8);
        to_cxx.decode_func(0x1018cdf4);
        to_cxx.decode_func(0x1018d034);
        to_cxx.decode_func(0x1018d304);
        to_cxx.decode_func(0x1018d9dc);
        to_cxx.decode_func(0x1018da9d);
        to_cxx.decode_func(0x1018dc3c);
        to_cxx.decode_func(0x1018dc67);
        to_cxx.decode_func(0x1018dd02);
        to_cxx.decode_func(0x1018dd5b);
        to_cxx.decode_func(0x1018e8dc);
        to_cxx.decode_func(0x1018e8e4);
        to_cxx.decode_func(0x1018e91c);
        to_cxx.decode_func(0x1018e924);
        to_cxx.decode_func(0x1018e928);
        to_cxx.decode_func(0x1018e935);
        to_cxx.decode_func(0x1018e948);
        to_cxx.decode_func(0x1018e95c);
        to_cxx.decode_func(0x1018e96c);
        to_cxx.decode_func(0x1018e9b0);
        to_cxx.decode_func(0x101900c4);
        to_cxx.decode_func(0x10190138);
        to_cxx.decode_func(0x101901f0);
        to_cxx.decode_func(0x1019026c);
        to_cxx.decode_func(0x10190280);
        to_cxx.decode_func(0x10194718);
        to_cxx.decode_func(0x101949bd);
        to_cxx.decode_func(0x10194c19);
        to_cxx.decode_func(0x1019661d);
        to_cxx.decode_func(0x10199a8a);
        to_cxx.decode_func(0x10199bb8);
        to_cxx.decode_func(0x1019a9b3);
        to_cxx.decode_func(0x1019aa71);
        to_cxx.decode_func(0x1019c3cd);
    }
#endif


//#define PREDICTABLE_DECODE
//    to_cxx.add_region_to_suppress_decode(0x10289000, 0); // Чтоб не выходил за пределы MAXRUN.EXE
//    to_cxx.decode_area(code_start, code_end); // Весь код MAXRUN.EXE

#ifdef PREDICTABLE_DECODE
    // Функции, когда либо запускавшиеся.
    for (auto i = std::begin(used_funcs_known); i != std::end(used_funcs_known); i++)
        if (i -> second == (seg.get_db() ? 32 : 16)
                && seg.fail_limit_check(i -> first, 1) == false)
        {
            std::cout << "Запуск декодирования функции '" << std::hex << std::showbase << i -> first << "'." << std::endl;
            to_cxx.decode(i -> first);
        }
#endif

    // @todo -> Перенести в to_cxx. И добавить флаг verbose. Или просто в syslog info.
    std::cout << "Запуск декодирования функции '" << std::hex << std::showbase;
    write_addr(std::cout, seg.get_base() + short_addr);
    std::cout << "'." << std::endl;

    to_cxx.decode_func(seg.get_base() + short_addr);
    to_cxx.write_cxx_to_dir("program/auto");
}

// +
static const func_info & get_func(seg_reg & seg, uint_<32> addr)
{
    if (seg.get_base() + addr == 0)
        throw std::runtime_error("Запрос функции по нулевому указателю.");

    func_info * ret = find_func_exact(seg, addr);
    if (ret != NULL)
        return *ret;

    ret = find_func_from_known_and_remember_it(seg, addr);
    if (ret != NULL)
        return *ret;

    // Всё-таки декодируем.
    decode_function(seg, addr);

    exit(5); // Use in bash: ERR=5 ; while [ $ERR == 5 ] ; do make -j8 && { rm /tmp/*.png ; time ./openmax ; } ; ERR=$? ; done

    /* Просто так. На всякий случай. */
    throw std::logic_error("Функция не найдена.");
}

static void add_to_used_func_list(uint_<32> full_addr, uint_<8> mode)
{
    static std::map<uint_<32>, uint_<8>> used_funcs; // <addr, bit mode>

    if (used_funcs.empty())
        for (auto i = std::begin(used_funcs_known); i != std::end(used_funcs_known); i++)
            used_funcs.insert(std::make_pair(i -> first, i -> second));

    auto ret = used_funcs.insert(std::make_pair(full_addr, mode));
    ret.first -> second = mode;
    if (ret.second)
    {
        std::fstream file("program/info/funcs_any_time_runs.hpp", std::ios_base::out);
        file << std::hex << std::showbase;
        for (auto & i : used_funcs)
        {
            file << "INFO(";
            /*bin_to_cxx::*/write_addr(file, i.first);
            file << ", " << static_cast<uint_<32>>(i.second) << ")\n";
        }
    }
}

// +
void run_func()
{
    const uint_<32> run = cs.get_base() + eip;
// "--on-run-func={none, dump-reg}"
    bool on_run_func__dump_reg = false;

    if (on_run_func__dump_reg)
    {
        std::cerr << "before run " << std::hex << run.get() <<
            ", eax " << eax.get() <<
            ", ebx " << ebx.get() <<
            ", ecx " << ecx.get() <<
            ", edx " << edx.get() <<
            ", esi " << esi.get() <<
            ", edi " << edi.get() <<
            ", esp " << esp.get() <<
            ", ebp " << ebp.get() <<
            ", ds.val " << uint_<16>(ds) <<
            ", es.val " << uint_<16>(es) <<
            ", cs.val " << uint_<16>(cs) <<
            ", ss.val " << uint_<16>(ss) <<
            ", fs.val " << uint_<16>(fs) <<
            ", gs.val " << uint_<16>(gs) <<
            std::endl;
    }

    eip_next = eip;
    const func_info & info = get_func(cs, eip);

    if (extra_log)
        std::cout << "run " << info.func_name << std::endl;

    add_to_used_func_list(run, (cs.get_db() ? 32 : 16));
    info.func();
    eip_next = eip;

    if (on_run_func__dump_reg)
    {
        std::cerr << "after run " << std::hex << run.get() <<
            ", eax " << eax.get() <<
            ", ebx " << ebx.get() <<
            ", ecx " << ecx.get() <<
            ", edx " << edx.get() <<
            ", esi " << esi.get() <<
            ", edi " << edi.get() <<
            ", esp " << esp.get() <<
            ", ebp " << ebp.get() <<
            ", ds.val " << uint_<16>(ds) <<
            ", es.val " << uint_<16>(es) <<
            ", cs.val " << uint_<16>(cs) <<
            ", ss.val " << uint_<16>(ss) <<
            ", fs.val " << uint_<16>(fs) <<
            ", gs.val " << uint_<16>(gs) <<
            std::endl;
    }
}


uint_<32> add_internal_dyn_func(void (*func)(), uint_<8> mode)
{
    static uint_<32> internal_dyn_count = 0;
    internal_dyn_count++;
    add_internal_dyn_func(func, mode, internal_dyn_count);
    return internal_dyn_count;
}

void add_internal_dyn_func(void (*func)(), uint_<8> mode, uint_<32> addr)
{
    auto range_iter = funcs_by_pc.equal_range(addr);

    for (auto iter = range_iter.first; iter != range_iter.second; iter++)
        if (iter -> second.func != func)
            throw std::exception();

    funcs_by_pc.insert(std::make_pair(addr, func_info(func, mode)));
}

void add_internal_dyn_func_if_free(void (*func)(), uint_<8> mode, uint_<32> addr)
{
    auto iter = funcs_by_pc.find(addr);
    if (iter != funcs_by_pc.end())
        return;

    funcs_by_pc.insert(std::make_pair(addr, func_info(func, mode)));
}


func_info_inserter::func_info_inserter(uint_<32> pc, exo::memory_space_const func_name, void (*func)(),  std::initializer_list<unsigned char> code, uint_<8> mode)
{
    func_info info(func, func_name, exo::memory_space_const(code.begin(), code.size()), mode);
    funcs_by_pc.insert(std::make_pair(pc, info));

#if 0
// Чтоб этот код работал необходимо чтобы 'funcs_by_pc' был объявлен как std::multimap, а не как boost::unordered_multimap.

    auto equal_pc_range = funcs_by_pc.equal_range(pc);

    // Перебираем функции, после адреса pc.
    for (auto iter = equal_pc_range.second; iter != funcs_by_pc.end(); iter++)
    {
        if (pc + info.code.size() <= iter -> first) // Если нет пересечения, значит они просто закончились.
            break;

        memory_space_const code_intersect = info.code.remove_prefix(static_cast<size_t>(iter -> first - pc));

        if (code_intersect == iter -> second.code)
            std::cerr << "Пересечение: функция '" << info.func_name << "' включает в себя '" << iter -> second.func_name << "'." << std::endl;
    }

    // Перебираем функции, до адреса pc.
    auto iter = equal_pc_range.first;
    iter--;
    for (; iter != funcs_by_pc.begin(); iter--)
    {
        if (iter -> first + iter -> second.code.size() <= pc) // Если нет пересечения, значит они просто закончились.
            break;

        memory_space_const code_intersect = iter -> second.code.remove_prefix(static_cast<size_t>(pc - iter -> first));

        if (code_intersect == info.code)
            std::cerr << "Пересечение: функция '" << iter -> second.func_name << "' включает в себя '" << info.func_name << "'." << std::endl;
    }
#endif
}


// +
void init_x86_dos_prog()
{
    file ff(file_name, file_flags::rdonly);
    mapping fm = ff.mmap(map_prot::read, map_type::private_, 0, ff.stat().size);


    exe_dos & exe = fm.ms().get<exe_dos>();
    if (exe.is_correct() == false)
        throw std::exception();


    dos_mem_init();

    // Alloc dos - dummy.

    bx = pspseg - 2 /* internal alloc logic */;
    dos_mem_alloc();
    if (cf)
        throw std::exception();


    // Alloc image

    uint_<32> exe_image_off = exe.exe_data_start();
    uint_<32> image_size = exe.extra_data_start() - exe_image_off;

    bx = (image_size + 15) / 16 + 16 /* psp_size */;
    dos_mem_alloc();
    if (cf)
        throw std::exception();

    if (ax != pspseg)
        throw std::exception();

    ds = image_load_seg;
    uint_<8> * image = & memb_a16(ds, 0);


    // Read image of program.

    fm.ms().sub_space(exe_image_off, image_size).copy_to(image);

    // Read relocations.

    exe_dos::reloc reloc_arr[exe.num_relocs.get()];
    fm.ms().sub_space(exe.reloc_table_offset, sizeof(reloc_arr)).copy_to(reloc_arr);


    // Apply realoc.

    for (int i = 0; i < exe.num_relocs; i++)
    {
        uint_<32> addr = reloc_arr[i];

        if (image_size <= addr + 1)
            throw std::exception();

        uint_<16> & to_change = reinterpret_cast<uint_<16>&>(image[addr]);
        to_change += image_load_seg;
    }


    // set psp

    const uint_<16> evnseg = pspseg - 0xa; // 0x188
    const typename uint_<8>::type evn_init[] =
    {         /* PATH=Z:\\ */
            0x50, 0x41, 0x54, 0x48, 0x3d, 0x5a, 0x3a, 0x5c, 0x0,
            /* COMSPEC=Z:\\COMMAND.COM */
            0x43, 0x4f, 0x4d, 0x53, 0x50, 0x45, 0x43, 0x3d, 0x5a, 0x3a, 0x5c, 0x43,
            0x4f, 0x4d, 0x4d, 0x41, 0x4e, 0x44, 0x2e, 0x43, 0x4f, 0x4d, 0x0,
            /* BLASTER=A220 I7 D1 H5 T6 */ // Port Address - 220, Interrupt - 7, DMA Channel - 1, "High" DMA Channel - 5, Type of Card - 6.
            0x42, 0x4c, 0x41, 0x53, 0x54, 0x45, 0x52, 0x3d, 0x41, 0x32, 0x32,
            0x30, 0x20, 0x49, 0x37, 0x20, 0x44, 0x31, 0x20, 0x48, 0x35, 0x20,
            0x54, 0x36, 0x0,

            0x0, 0x1, 0x0,
            /* C:\\MAXRUN.EXE */
            0x43, 0x3a, 0x5c, 0x4d, 0x41, 0x58, 0x52, 0x55, 0x4e, 0x2e, 0x45,
            0x58, 0x45, 0x0
    };

    ds = evnseg;
    memcpy(&memb_a16(ds, 0), evn_init, sizeof(evn_init));

    ds = pspseg; // 0x192
    memb_a16(ds, 0x81) = 0xd; // Empty command-line (terminated by a 0x0D).
    memw_a16(ds, 0x2c) = evnseg;

    /* Terminate address of previous program. */
    // memw_a16(ds, 0xa) = 0x20c8;
    // memw_a16(ds, 0xa + 2) = 0xf000;

    ds = evnseg - 1; // 0x187
    memb_a16(ds, 0) = 0x4d; /* Не знаю, что это. */
    memw_a16(ds, 1) = pspseg;
    memw_a16(ds, 3) = 0x9;

    ds = pspseg - 1; // 0x191
    // memw_a16(ds, 0x3) = 0x1346 - 0x191;
    memw_a16(ds, 0x3) = 0xc02 - 0x191;


    install_std_ints();


    // Устанавливаем начальные значения в регистры.

    ds = pspseg;
    es = ds;

    ss = image_load_seg + exe.ss;
    sp = exe.sp;

    cs = image_load_seg + exe.cs;
    eip = eip_next = exe.ip;


    eax = 0;
    ebx = 0;
    ecx = 0xff;
    edx = pspseg;

    esi = 0x2382;
    edi = 0x340;
    ebp = 0x91c;

    eflags = 0x7202;


    timers_init();
}


} /* namespace raw_program */

