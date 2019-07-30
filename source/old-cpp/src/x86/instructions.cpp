#include <math.h>
#include <memory>
#include <iomanip>

#include <exo/exception.hpp>

#include "x86/memory.hpp"
#include "x86/registers.hpp"
#include "x86/instructions.hpp"
#include "program/raw_program.hpp"


namespace raw_program {

extern bool extra_log;

namespace x86 {

void invalid()
{
    throw exo::exception::not_implemented();
}


// +
/** @return Возвращает истину, если необходимо сделать return.
 * @todo Перенести в raw_program.cpp? */
bool correct_function_position(uint_<32> ret_addr)
{
    static std::vector<uint_<32>> call_ret_addr;


    call_ret_addr.push_back(ret_addr);

    auto func_pop = [](void *) -> void
    {
        try
        {
            call_ret_addr.pop_back();
        }
        catch(...)
        {}
    };
    std::unique_ptr<void, decltype(func_pop)> call_ret_addr_pop(
            &call_ret_addr /* Что угодно, только не NULL. */,
            func_pop);


    std::vector<uint_<32>> hist; // for debug

    for(;;)
    {
        const uint_<32> to_run = cs.get_base() + eip;
        hist.push_back(to_run);

        if (to_run == 0)
            throw std::logic_error("Переход по нулевому указателю.");

        if (to_run == ret_addr)
            return false;

        // Шаг первый - ищем среди уже вызванных функций.
        auto iter = std::find(call_ret_addr.rbegin(), call_ret_addr.rend(), to_run);
        if (iter != call_ret_addr.rend())
            return true;

        // Шаг второй - если не нашли - значит вызываем новую функцию.
        raw_program::run_func();

        if (extra_log)
            std::cout << "ret" << std::endl;
    }
}

// +
void jmp_far_prepare(uint_<16> seg, uint_<32> tempEIP)
{
    if (cr0.pe == false || (cr0.pe && vm)) /* Real-address or virtual-8086 mode */
    {
        if (cs.fail_limit_check(tempEIP)) // is beyond code segment limit
            throw exo::exception::not_implemented(); // #GP(0);
        cs = seg;
        eip = tempEIP;
        return;
    }

    if (cr0.pe && vm == false) /* IA-32e mode or protected mode, not virtual-8086 mode */
    {
        /* @todo Not understand:
            IF effective address in the CS, DS, ES, FS, GS, or SS segment is illegal
            or segment selector in target operand NULL
            THEN #GP(0); FI; */

        seg_reg new_cs = seg;
        seg_desc new_cs_desc = new_cs.get_cached_desc();

        if (ia32_efer.lma == false)
        {
            if ( ! (new_cs_desc.is_type_code() || new_cs_desc.is_type_call_gate() || new_cs_desc.is_type_task_gate() || new_cs_desc.is_type_tss()) )
                throw exo::exception::not_implemented(); // #GP(segment selector)
        }
        else
            if ( ! (new_cs_desc.is_type_code() || new_cs_desc.is_type_call_gate()) )
                throw exo::exception::not_implemented(); // #GP(segment selector)

        if (new_cs_desc.is_type_conforming_code())
        {
            if (new_cs_desc.get_l() && new_cs_desc.get_db() && ia32_efer.lma)
                throw exo::exception::not_implemented(); // #GP(new code segment selector)
            if (get_cpl() < new_cs_desc.get_dpl())
                throw exo::exception::not_implemented(); // #GP(segment selector)
            if (new_cs_desc.is_present() == false)
                throw exo::exception::not_implemented(); // #GP(segment selector)

            if ((ia32_efer.lma == false || new_cs_desc.is_compatibility_mode())
                    && new_cs.fail_limit_check(tempEIP))
                throw exo::exception::not_implemented(); // #GP(0)

            uint_<8> _cpl_ = get_cpl();
            cs = new_cs;
            cs.set_rpl(_cpl_);
            eip = tempEIP;
        }
        else if (new_cs_desc.is_type_non_conforming_code())
        {
            if (new_cs.get_l() && new_cs.get_db() && ia32_efer.lma)
                throw exo::exception::not_implemented(); // #GP(new code segment selector)
            if ((get_cpl() < new_cs.get_rpl()) || (get_cpl() != new_cs_desc.get_dpl()))
                throw exo::exception::not_implemented(); // #GP(segment selector)
            if (new_cs.is_present() == false)
                throw exo::exception::not_implemented(); // #GP(segment selector)

            if ((ia32_efer.lma == false || new_cs_desc.is_compatibility_mode())
                                && new_cs.fail_limit_check(tempEIP))
                throw exo::exception::not_implemented(); // #GP(0)

            uint_<8> _cpl_ = get_cpl();
            cs = new_cs;
            cs.set_rpl(_cpl_);
            eip = tempEIP;
        }
        else if (new_cs_desc.is_type_call_gate())
        {
            throw exo::exception::not_implemented();
        }
        else if (new_cs_desc.is_type_task_gate())
        {
            throw exo::exception::not_implemented();
        }
        else if (new_cs_desc.is_type_tss())
        {
            throw exo::exception::not_implemented();
        }
        else
            throw std::logic_error("impossible");
    }
    else
        throw exo::exception::not_implemented(); // #GP(segment selector)
}

// +
void call_far_prepare(uint_<8> op_size, uint_<16> seg, uint_<32> off)
{
    if (cr0.pe == false || (cr0.pe && vm)) /* Real-address or virtual-8086 mode */
    {
        if (op_size == 32)
        {
            if ((off | 0xffff) != 0xffff)
                throw exo::exception::not_implemented(); // #GP(0)
            pushd(cs);
            pushd(eip_next);
            cs = seg;
            eip = off;
        }
        else  /* OperandSize = 16 */
        {
            pushw(cs);
            pushw(eip_next);
            cs = seg;
            eip = off;
        }
    }

    if (cr0.pe && vm == false) /* IA-32e mode or protected mode, not virtual-8086 mode */
    {
        /*    IF segment selector in target operand NULL
            THEN #GP(0); FI;
            IF segment selector index not within descriptor table limits
            THEN #GP(new code segment selector); FI;    */

        seg_reg new_cs = seg;
        seg_desc new_cs_desc = new_cs.get_cached_desc();

        if (ia32_efer.lma == false)
        {
            if ( ! (new_cs_desc.is_type_code() || new_cs_desc.is_type_call_gate() || new_cs_desc.is_type_task_gate() || new_cs_desc.is_type_tss()) )
                throw exo::exception::not_implemented(); // #GP(segment selector)
        }
        else
            if ( ! (new_cs_desc.is_type_code() || new_cs_desc.is_type_64bit_call_gate()) )
                throw exo::exception::not_implemented(); // #GP(segment selector)

        if (new_cs_desc.is_type_conforming_code())
        {
            if (new_cs.get_l() && new_cs.get_db() && ia32_efer.lma)
                throw exo::exception::not_implemented(); // #GP(new code segment selector)
            if (get_cpl() < new_cs_desc.get_dpl())
                throw exo::exception::not_implemented(); // #GP(new code segment selector)
            if (new_cs.is_present() == false)
                throw exo::exception::not_implemented(); // #GP(new code segment selector)

            if ((ia32_efer.lma == false || new_cs_desc.is_compatibility_mode())
                    && new_cs.fail_limit_check(off))
                throw exo::exception::not_implemented(); // #GP(0)

            if (op_size == 32)
            {
                pushd(cs);
                pushd(eip_next);

                uint_<8> _cpl_ = get_cpl();
                cs = new_cs;
                cs.set_rpl(_cpl_);
                eip = off;
            }
            else if (op_size == 16)
            {
                pushw(cs);
                pushw(eip_next);

                uint_<8> _cpl_ = get_cpl();
                cs = new_cs;
                cs.set_rpl(_cpl_);
                eip = off;
            }
            else /* OperandSize = 64 */
                throw exo::exception::not_implemented();
        }
        else if (new_cs_desc.is_type_non_conforming_code())
        {
            if (new_cs.get_l() && new_cs.get_db() && ia32_efer.lma)
                throw exo::exception::not_implemented(); // #GP(new code segment selector)
            if ((get_cpl() < new_cs.get_rpl()) || (get_cpl() != new_cs_desc.get_dpl()))
                throw exo::exception::not_implemented(); // #GP(segment selector)
            if (new_cs.is_present() == false)
                throw exo::exception::not_implemented(); // #GP(segment selector)

            if ((ia32_efer.lma == false || new_cs_desc.is_compatibility_mode())
                    && new_cs.fail_limit_check(off))
                throw exo::exception::not_implemented(); // #GP(0)

            if (op_size == 32)
            {
                pushd(cs);
                pushd(eip_next);

                uint_<8> _cpl_ = get_cpl();
                cs = new_cs;
                cs.set_rpl(_cpl_);
                eip = off;
            }
            else if (op_size == 16)
            {
                pushw(cs);
                pushw(eip_next);

                uint_<8> _cpl_ = get_cpl();
                cs = new_cs;
                cs.set_rpl(_cpl_);
                eip = off;
            }
            else /* OperandSize = 64 */
                throw exo::exception::not_implemented();
        }
        else if (new_cs_desc.is_type_call_gate())
        {
            throw exo::exception::not_implemented();
        }
        else if (new_cs_desc.is_type_task_gate())
        {
            throw exo::exception::not_implemented();
        }
        else if (new_cs_desc.is_type_tss())
        {
            throw exo::exception::not_implemented();
        }
        else
            throw std::logic_error("impossible");
    }
}

// +
void ret_far(uint_<8> op_size)
{
    const uint_<8> cpl = get_cpl();

    switch(op_size)
    {
    case 16:
        popw(eip);
        popw(cs);
        break;
    case 32:
        popd(eip);
        popd(cs);
        break;
    }


    if (cr0.pe == false || (cr0.pe && vm)) /* Real-address or virtual-8086 mode */
    {
        if (op_size == 16 && cs.fail_limit_check(eip))
            throw exo::exception::not_implemented();
    }

    /* Protected mode, not virtual-8086 mode */
    if (cr0.pe && vm == false && ia32_efer.lma == false)
    {
        if (cs.is_null())
            throw exo::exception::not_implemented(); // #GP(0)
        if (cs.get_cached_desc().is_type_code() == false)
            throw exo::exception::not_implemented(); // #GP(selector)
        if (cs.get_rpl() < cpl)
            throw exo::exception::not_implemented(); // #GP(selector)
        if (cs.get_cached_desc().is_type_conforming_code())
        {
            if (cs.get_rpl() < cs.get_cached_desc().get_dpl())
                throw exo::exception::not_implemented(); // #GP(selector)
        }
        else
            if (cs.get_rpl() != cs.get_cached_desc().get_dpl())
                throw exo::exception::not_implemented(); // #GP(selector)
        if (cs.is_present() == false)
            throw exo::exception::not_implemented(); // #NP(selector)
        if (cpl < cs.get_rpl())
        {
            // RETURN-OUTER-PRIVILEGE-LEVEL
            throw exo::exception::not_implemented();
        }
        else
        {
            // RETURN-TO-SAME-PRIVILEGE-LEVEL

            if (cs.fail_limit_check(eip))
                throw exo::exception::not_implemented(); // #GP(0)
        }
    }

    /* IA-32e Mode */
    if (cr0.pe && vm == false && ia32_efer.lma)
        throw exo::exception::not_implemented();
}

// +
void popf_(uint_<8> OperandSize)
{
    uint_<32> flg;
    uint_<32> clr_flg = 0;
    uint_<32> no_mod_mask = 0;// eflags.reserved_mask();

    switch (OperandSize)
    {
    case 32:
        popd(flg);
        break;
    case 64:
        popq(flg);
        break;
    case 16:
        popw(flg);
        no_mod_mask = 0xffff0000;
        break;
    default:
        throw std::exception();
    }


    // From AMD manual.
    if (cr0.pe == false)
    {
        // REAL_MODE
        no_mod_mask |= eflag_mask::vip | eflag_mask::vif | eflag_mask::vm;
        clr_flg = eflag_mask::rf;
    }
    else if (cr0.pe && vm == false)
    {
        // PROTECTED_MODE
        no_mod_mask |=  eflag_mask::vip | eflag_mask::vif | eflag_mask::vm;
        if (get_cpl() != 0)
            no_mod_mask |= eflag_mask::iopl;
        if (iopl < get_cpl())
            no_mod_mask |= eflag_mask::if_;
        clr_flg = eflag_mask::rf;
    }
    else
    {
        // VIRTUAL_MODE
        throw exo::exception::not_implemented();
    }

    eflags = ((uint_<32>(eflags) & (~clr_flg)) & no_mod_mask) | (flg & (~no_mod_mask));
}

// +
struct tss32 {
    uint_<32> back;                    /* Back link to other task */
    uint_<32> esp0;                    /* The CK stack pointer */
    uint_<32> ss0;                    /* The CK stack selector */
    uint_<32> esp1;                    /* The parent KL stack pointer */
    uint_<32> ss1;                    /* The parent KL stack selector */
    uint_<32> esp2;                    /* Unused */
    uint_<32> ss2;                    /* Unused */

    uint_<32> cr3;                    /* The page directory pointer */
    uint_<32> eip;                    /* The instruction pointer */
    uint_<32> eflags;                /* The flags */
    uint_<32> eax, ecx, edx, ebx;    /* The general purpose registers */
    uint_<32> esp, ebp, esi, edi;    /* The special purpose registers */
    uint_<32> es;                    /* The extra selector */
    uint_<32> cs;                    /* The code selector */
    uint_<32> ss;                    /* The application stack selector */
    uint_<32> ds;                    /* The data selector */
    uint_<32> fs;                    /* And another extra selector */
    uint_<32> gs;                    /* ... and another one */
    uint_<32> ldt;                    /* The local descriptor table */

    // uint_<32> reserved + io map;

    // +
    void save_cur_contest(bool next_eip)
    {
        cr3 = x86::cr3;

        if (next_eip)
            eip = x86::eip_next;
        else
            eip = x86::eip;

        eflags = x86::eflags;

        eax = x86::eax;
        ebx = x86::ebx;
        ecx = x86::ecx;
        edx = x86::edx;

        esp = x86::esp;
        ebp = x86::ebp;

        edi = x86::edi;
        esi = x86::esi;

        ldt = x86::lldr;

        es = x86::es;
        cs = x86::cs;
        ss = x86::ss;
        ds = x86::ds;
        fs = x86::fs;
        gs = x86::gs;
    }

    // +
    void restore_contest()
    {
        x86::cr3 = cr3;
        x86::eip = eip;
        x86::eflags = eflags;

        x86::eax = eax;
        x86::ebx = ebx;
        x86::ecx = ecx;
        x86::edx = edx;

        x86::esp = esp;
        x86::ebp = ebp;

        x86::edi = edi;
        x86::esi = esi;

        x86::lldr = ldt;

        x86::es = es;
        x86::cs = cs;
        x86::ss = ss;
        x86::ds = ds;
        x86::fs = fs;
        x86::gs = gs;
    }

    static tss32 & get_from_ptr(uint_<32> addr)
    {
        return mem_pg_raw(addr, sizeof(tss32)).get<tss32>();
    }
};

// +
enum class task_switch_reason
{
    jmp,
    call,
    iret,
    exception,
    interrupt
};

// +
static void switch_task(
        task_switch_reason ts_reason,
        bool in_interrupt_int_n,
        bool in_interrupt_hw,

        uint_<16> tss_new_selector,
        seg_desc & tss_new_desc,

        bool switch_through_task_gate, uint_<8> task_gate_dpl)
{
    if (ts_reason != task_switch_reason::interrupt)
        in_interrupt_int_n = in_interrupt_hw = false;

    // 2.

    uint_<8> dpl;
    if (switch_through_task_gate)
        dpl = task_gate_dpl;
    else
        dpl = tss_new_desc.get_dpl();

    if (ts_reason != task_switch_reason::exception
            && ts_reason != task_switch_reason::iret
            && (ts_reason != task_switch_reason::interrupt || in_interrupt_int_n))
        if (dpl < get_cpl() || dpl < (tss_new_selector & 0x3 /* rpl */))
            throw exo::exception::not_implemented(); // #GP

    // 3. Checks that the TSS descriptor of the new task is marked present and has a valid limit (greater than or equal to 0x67).
    if (tss_new_desc.is_present() == false || tss_new_desc.get_limit() < 0x67)
        throw exo::exception::not_implemented(); // #TS

    // 4. Checks that the new task is available (call, jump, exception, or interrupt) or busy (IRET return).
    if (tss_new_desc.is_tss_busy() != (ts_reason == task_switch_reason::iret))
        throw exo::exception::not_implemented();

    // 5. Checks that the current (old) TSS, new TSS, and all segment descriptors used in the task switch are paged into system memory.
    // @todo Не понял, о чём это они.

    // 6. If the task switch was initiated with a JMP or IRET instruction, the processor clears the busy (B) flag in the current (old) task’s TSS descriptor.
    uint_<16> tss_old_selector = tr;
    seg_desc & tss_old_desc = tr.get_orig_desc_ref();

    if (ts_reason == task_switch_reason::jmp || ts_reason == task_switch_reason::iret)
        tss_old_desc.set_tss_busy(false);

    // 8.

    if (tr.get_cached_desc().is_type_32_tss() == false)
        throw exo::exception::not_implemented();

    tss32 & tss_old = tss32::get_from_ptr(tr.get_base());
    tss_old.save_cur_contest(ts_reason != task_switch_reason::exception || in_interrupt_hw);

    // 7.
    if (ts_reason == task_switch_reason::iret)
        tss_old.eflags &= ~0x4000; // clr nt flag.

    // 10.
    if (ts_reason == task_switch_reason::call
            || ts_reason == task_switch_reason::jmp
            || ts_reason == task_switch_reason::exception
            || ts_reason == task_switch_reason::interrupt)
        tss_new_desc.set_tss_busy(true);

    // 11.
    tr = tss_new_selector;

    // 12.
    if (tr.get_cached_desc().is_type_32_tss() == false)
        throw exo::exception::not_implemented();

    tss32 & tss_new = tss32::get_from_ptr(tr.get_base());
    tss_new.restore_contest();

    // 9.
    if (ts_reason == task_switch_reason::call
            || ts_reason == task_switch_reason::exception
            || ts_reason == task_switch_reason::interrupt)
    {
        nt = true;
        tss_new.eflags |= 0x4000; // set nt flag.
        tss_new.back = tss_old_selector; // 7.4 TASK LINKING
    }

    // end of switch_tasks
}

// +
void int_internal(uint_<8> num,
        bool software_interrupt, bool in_interrupt_int_n,
        bool fault_with_error_code, uint_<32> error_code)
{
    if (extra_log)
        std::cout << "int_" << std::hex << std::setw(2) << num << std::endl;

    if (cr0.pe == false)
    {
        if (idtr_limit < (num << 2) + 3)
            throw exo::exception::not_implemented(); // #GP;

        // IF stack not large enough for a 6-byte return information
        // THEN #SS; FI;

        pushfw();
        if_ = false; /* Clear interrupt flag */
        tf = false; /* Clear trap flag */
        ac = false; /* Clear AC flag */
        pushw(cs);
        pushw(eip_next);

        /* No error codes are pushed in real-address mode */
        int_get_idt(num, cs, eip);
    }
    else // PE = 1
    {
        if (vm && iopl < 3 && in_interrupt_int_n)
            throw exo::exception::not_implemented(); // #GP(0); (* Bit 0 of error code is 0 because INT n *)
        else /* Protected mode, IA-32e mode, or virtual-8086 mode interrupt */
            if (ia32_efer.lma == false)
            {
                /* Protected mode, or virtual-8086 mode interrupt */

                seg_desc desc = seg_desc::get_desc_ref(idtr_base, idtr_limit, num * 8);

                if ( ! (desc.is_type_interrupt_gate() || desc.is_type_trap_gate() || desc.is_type_task_gate()) )
                    throw exo::exception::not_implemented(); // #GP(error_code(vector_number,1,EXT));
                if (software_interrupt && desc.get_dpl() < get_cpl())
                    throw exo::exception::not_implemented(); // #GP(error_code(vector_number,1,0));
                if (desc.is_present() == false)
                    throw exo::exception::not_implemented(); // #NP(error_code(vector_number,1,EXT));


                uint_<8> size_of_stack_frame_pushes = 0;


                if (desc.is_type_task_gate())
                {
                    // TASK-GATE
                    uint_<16> tss_new_selector = desc.get_gate_selector();

                    if (((tss_new_selector >> 2) & 0x1) == 1 /* local */
                            || gdtr_limit < (tss_new_selector & 0xfff8) + 7)
                        throw exo::exception::not_implemented(); // #GP(error_code(TSS selector,0,EXT))

                    seg_desc & tss_new_desc = seg_desc::get_desc_ref(gdtr_base, gdtr_limit, tss_new_selector);
                    size_of_stack_frame_pushes = tss_new_desc.get_system_segment_size();

                    if (tss_new_desc.is_tss_busy())
                        throw exo::exception::not_implemented(); // #GP(TSS selector,0,EXT))
                    if (tss_new_desc.is_present() == false)
                        throw exo::exception::not_implemented(); // #NP(TSS selector,0,EXT))


                    switch_task(fault_with_error_code ? task_switch_reason::exception :    task_switch_reason::interrupt,
                            in_interrupt_int_n,
                            !software_interrupt,

                            tss_new_selector,
                            tss_new_desc,

                            true, desc.get_dpl());


                    if (fault_with_error_code)
                    {
                    // IF stack limit does not allow push of error code
                    // THEN #SS(EXT); FI;

                        // In legacy mode, the size of an IDT entry (16 bits or 32 bits) determines the size of interrupt-stack-frame pushes.

                        if (size_of_stack_frame_pushes == 32)
                            pushd(error_code);
                        else if (size_of_stack_frame_pushes == 16)
                            pushw(error_code);
                        else
                            throw exo::exception::not_implemented();
                    }

                    if (cs.fail_limit_check(eip))
                        throw exo::exception::not_implemented(); // #GP(EXT)
                }
                else
                {
                    // TRAP-OR-INTERRUPT-GATE

                    uint_<16> new_cs_selector = desc.get_gate_selector();
                    if (new_cs_selector <= 0x3) // NULL
                        throw exo::exception::not_implemented(); // #GP(EXT)

                    seg_reg new_cs(new_cs_selector);

                    if (new_cs.get_cached_desc().is_type_code() == false
                            || get_cpl() < new_cs.get_cached_desc().get_dpl())
                        throw exo::exception::not_implemented(); // #GP(error_code(new code-segment selector,0,EXT))
                    if (new_cs.is_present() == false)
                        throw exo::exception::not_implemented(); // #NP(error_code(new code-segment selector,0,EXT))

                    uint_<8> cpl = get_cpl();

                    if (new_cs.get_cached_desc().is_type_non_conforming_code()
                            && new_cs.get_cached_desc().get_dpl() < get_cpl())
                    {
                        if (vm)
                            throw exo::exception::not_implemented();

                        // INTER-PRIVILEGE-LEVEL-INTERRUPT;
                        throw exo::exception::not_implemented();
                    }
                    else /* PE = 1, interrupt or trap gate, DPL ≥ CPL */
                    {
                        if (vm)
                            throw exo::exception::not_implemented(); // #GP(error_code(new code-segment selector,0,EXT))
                        if (new_cs.get_cached_desc().is_type_conforming_code()
                                || new_cs.get_cached_desc().get_dpl() == get_cpl())
                        {
                            // INTRA-PRIVILEGE-LEVEL-INTERRUPT;
                            if (ia32_efer.lma)
                                throw exo::exception::not_implemented();

                            uint_<32> new_eip = desc.get_interrupt_or_trap_eip();

                            if (new_cs.fail_limit_check(new_eip))
                                throw exo::exception::not_implemented(); // #GP(EXT)

                            if (desc.get_system_segment_size() != 32)
                                throw exo::exception::not_implemented();

                            pushfd();
                            pushd(cs);
                            pushd(eip_next);
                            cs = new_cs;
                            eip = new_eip;
                            if (fault_with_error_code)
                                pushd(error_code);
                        }
                        else
                            throw exo::exception::not_implemented(); // #GP(error_code(new code-segment selector,0,EXT))
                    }

                    cs.set_rpl(cpl);
                    if (desc.is_type_interrupt_gate())
                        if_ = false;
                    nt = tf = vm = rf = false;
                }
            }
            else/* IA-32e mode interrupt */
                throw exo::exception::not_implemented();
    }
}

// +
void iret_(uint_<8> op_size)
{
    if (cr0.pe == false)
    {
        // REAL-ADDRESS-MODE
        if (op_size == 32)
        {
            popd(eip);
            if ((eip | 0xffff) != 0xffff)
                throw exo::exception::not_implemented(); // #GP(0)
            popd(cs);

            uint_<32> tempEFLAGS;
            popd(tempEFLAGS);
            eflags = (tempEFLAGS & 0x257FD5) | (uint_<32>(eflags) & 0x1A0000);
        }
        else
        {
            popw(eip);
            popw(cs);

            uint_<16> tempEFLAGS;
            popw(tempEFLAGS);
            eflags = tempEFLAGS | (uint_<32>(eflags) & 0xffff0000);
        }
    }
    else
    {
        if (ia32_efer.lma == false)
        {
            // PROTECTED-MODE

            if (vm)
                // RETURN-FROM-VIRTUAL-8086-MODE
                throw exo::exception::not_implemented();

            if (nt)
            {
                // TASK-RETURN
                tss32 & tss_old = tss32::get_from_ptr(tr.get_base());
                uint_<16> tss_new_selector = tss_old.back;

                if (((tss_new_selector >> 2) & 0x1) == 1 /* local */
                        || gdtr_limit < (tss_new_selector & 0xfff8) + 7)
                    throw exo::exception::not_implemented(); // #TS(TSS selector)

                seg_desc & tss_new_desc = seg_desc::get_desc_ref(gdtr_base, gdtr_limit, tss_new_selector);
                if (tss_new_desc.is_type_tss() == false || tss_new_desc.is_tss_busy() == false)
                    throw exo::exception::not_implemented(); // #TS(TSS selector)
                if (tss_new_desc.is_present() == false)
                    throw exo::exception::not_implemented(); // #NP(TSS selector)

                switch_task(task_switch_reason::iret, false, false,
                        tss_new_selector, tss_new_desc,
                        false, 0);

                if (cs.fail_limit_check(eip))
                    throw exo::exception::not_implemented(); // #GP(0)

                return;
            }

            uint_<8> cpl = get_cpl();

            if (op_size != 32)
                throw exo::exception::not_implemented();
            popd(eip);
            popd(cs);

            uint_<32> tempEFLAGS;
            popd(tempEFLAGS);

            if ((tempEFLAGS & eflag_mask::vm) != 0 && get_cpl() == 0)
                throw exo::exception::not_implemented(); // RETURN-TO-VIRTUAL-8086-MODE;
            else
            {
                // PROTECTED-MODE-RETURN;
                if (cs.is_null())
                    throw exo::exception::not_implemented(); // GP(0)
                if (cs.get_cached_desc().is_type_code() == false)
                    throw exo::exception::not_implemented(); // #GP(selector)
                if (cs.get_rpl() < cpl)
                    throw exo::exception::not_implemented(); // #GP(selector)
                if (cs.get_cached_desc().is_type_conforming_code()
                        && cs.get_rpl() < cs.get_cached_desc().get_dpl())
                    throw exo::exception::not_implemented(); // #GP(selector)
                if (cs.is_present() == false)
                    throw exo::exception::not_implemented(); // #NP(selector)
                if (cpl < cs.get_rpl())
                {
                    // RETURN-OUTER-PRIVILEGE-LEVEL
                    throw exo::exception::not_implemented();
                }
                else
                {
                    // RETURN-TO-SAME-PRIVILEGE-LEVEL

                    if (cs.fail_limit_check(eip))
                        throw exo::exception::not_implemented(); // #GP(0)

                    uint_<32> ef_mask =
                            eflag_mask::cf |
                            eflag_mask::pf |
                            eflag_mask::af |
                            eflag_mask::zf |
                            eflag_mask::sf |
                            eflag_mask::tf |
                            eflag_mask::df |
                            eflag_mask::of |
                            eflag_mask::nt;

                    if (32 <= op_size)
                        ef_mask |= eflag_mask::rf | eflag_mask::ac | eflag_mask::id;

                    if (cpl <= iopl)
                        ef_mask |= eflag_mask::if_;

                    if (cpl == 0)
                    {
                        ef_mask |= eflag_mask::iopl;
                        if (32 <= op_size)
                            ef_mask |= eflag_mask::vip |eflag_mask::vif;
                    }

                    eflags = (tempEFLAGS & ef_mask) | (uint_<32>(eflags) & (~ef_mask));
                }
            }
        }
        else
        {
            // IA-32e-MODE
            throw exo::exception::not_implemented();
        }
    }
}


/* fpu */

enum class fpu_precision
{
    /* 24 bit */
    single,
    /* 53 bit */
    double_,
    /* 64 bit */
    double_extended
};

// +
uint_<16> FPUControlWord;
// +
uint_<16> FPUStatusWord;
// +
uint_<16> FPUTagWord;

// +
seg_reg FPUDataPointer_seg;
// +
uint_<32> FPUDataPointer_off;

// +
seg_reg FPUInstructionPointer_seg;
// +
uint_<32> FPUInstructionPointer_off;

// +
typename uint_ge<11>::type FPULastInstructionOpcode;

__float80 /* typename exo::math::fixed_ge<80>::utype */ st_regs[8];



static uint_<8> get_top()
{
    return ((FPUStatusWord >> 11) & 7);
}

static void set_top(uint_<8> x)
{
    FPUStatusWord = (FPUStatusWord & (~(7 << 11))) | ((x & 7) << 11);

}

/** @remark cf */
static void set_c0(bool v)
{
    FPUStatusWord = (FPUStatusWord & (~(1 << 8))) | ((v ? 1 : 0) << 8);
}

//static void set_c1(bool v)
//{
//    FPUStatusWord = (FPUStatusWord & (~(1 << 9))) | ((v ? 1 : 0) << 9);
//}

/** @remark pf */
static void set_c2(bool v)
{
    FPUStatusWord = (FPUStatusWord & (~(1 << 10))) | ((v ? 1 : 0) << 10);
}

/** @remark zf */
static void set_c3(bool v)
{
    FPUStatusWord = (FPUStatusWord & (~(1 << 14))) | ((v ? 1 : 0) << 14);
}

static bool get_invalid_flag()
{
    return ((FPUStatusWord & 1) != 0);
}


//static fpu_precision get_precision()
//{
//    uint_<8> p = (FPUControlWord >> 8) & 3;
//    switch (p)
//    {
//    case 0:
//        return fpu_precision::single;
//    case 2:
//        return fpu_precision::double_;
//    case 3:
//        return fpu_precision::double_extended;
//    default:
//        throw std::exception();
//    }
//}

static __float80 & ST(uint_<8> num)
{
    return st_regs[(get_top() + num) & 7];
}

/** 0 - valid, 1 - zero, 2 - special, 3 - empty */
static uint_<8> get_tag(uint_<8> num)
{
    return (FPUTagWord >> (((get_top() + num) & 7) * 2)) & 3;
}

static void set_tag(uint_<8> num, uint_<8> val)
{
    FPUTagWord = (FPUTagWord & (~(3 << (((get_top() + num) & 7) * 2)))) | ((val & 3) << (((get_top() + num) & 7) * 2));
}

static void fpu_pop()
{
    set_tag(0, 3);
    set_top(get_top() + 1);
}


// +
void fninit()
{
    FPUControlWord = 0x037F;
    FPUStatusWord = 0;
    FPUTagWord = 0xFFFF;
    FPUDataPointer_seg = 0;
    FPUDataPointer_off = 0;
    FPUInstructionPointer_seg = 0;
    FPUInstructionPointer_off = 0;
    FPULastInstructionOpcode = 0;
}

// +
void fnstsw(uint_<16> & DEST)
{
    DEST = FPUStatusWord;
}

// +
void fnstcw(uint_<16> & DEST)
{
    DEST = FPUControlWord;
}

void fldcw(uint_<16> SRC)
{
    FPUControlWord = SRC;
}

void fnsavew_a16(seg_reg & seg, uint_<16> off)
{
    if (cr0.pe == false)
    {
        memw_a16(seg, off) = FPUControlWord;
        memw_a16(seg, off + 2) = FPUStatusWord;
        memw_a16(seg, off + 4) = FPUTagWord;
        memw_a16(seg, off + 6) = FPUInstructionPointer_off;
        memw_a16(seg, off + 8) = ((FPUInstructionPointer_off >> 16) << 12) | FPULastInstructionOpcode;
        memw_a16(seg, off + 10) = FPUDataPointer_off;
        memw_a16(seg, off + 12) = ((FPUDataPointer_off >> 16) << 12);
    }
    else
        throw exo::exception::not_implemented();

    for (int i = 0; i < 8; i++)
        mem_seg_pg_raw(seg, off + 14 + i * 10, 10).get<__float80>() = ST(i);

    fninit();
}

void fldz()
{
    set_top(get_top() + 7); // TOP ← TOP − 1;

    if (get_tag(0) != 3)
        throw exo::exception::not_implemented();

    ST(0) = +0.0;//w;
    set_tag(0, 1);
}

void fld1()
{
    set_top(get_top() + 7); // TOP ← TOP − 1;

    if (get_tag(0) != 3)
        throw exo::exception::not_implemented();

    ST(0) = +1.0;//w;
    set_tag(0, 0);
}

void fldln2()
{
    set_top(get_top() + 7); // TOP ← TOP − 1;

    if (get_tag(0) != 3)
        throw exo::exception::not_implemented();

    ST(0) = M_LN2l;
    set_tag(0, 0);
}

void fldl2e()
{
    set_top(get_top() + 7); // TOP ← TOP − 1;

    if (get_tag(0) != 3)
        throw exo::exception::not_implemented();

    ST(0) = M_LOG2El;
    set_tag(0, 0);
}

void fld(int src_n, int dst_n)
{
    auto save = ST(dst_n);
    auto tag = get_tag(dst_n);

    set_top(get_top() + 7); // TOP ← TOP − 1;

    if (src_n != 0)
        throw std::exception();

    if (get_tag(src_n) != 3)
        throw exo::exception::not_implemented();

    ST(src_n) = save;
    set_tag(src_n, tag);
}

void fld(uint_<32> & val)
{
    set_top(get_top() + 7); // TOP ← TOP − 1;

    if (get_tag(0) != 3)
        throw exo::exception::not_implemented();

    ST(0) = reinterpret_cast<float&>(val);
    set_tag(0, 0);
}

void fld(uint_<64> & val)
{
    set_top(get_top() + 7); // TOP ← TOP − 1;

    if (get_tag(0) != 3)
        throw exo::exception::not_implemented();

    ST(0) = reinterpret_cast<double&>(val);
    set_tag(0, 0);
}

void fld(uint_<80> &)
{
    throw exo::exception::not_implemented();
}


void fchs()
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();
    ST(0) = -ST(0);
}


void fadd(uint_<64> & x)
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();

    double val = reinterpret_cast<double&>(x);

    ST(0) += val;
}

void fadd(int a, int b)
{
    if (get_tag(a) == 3)
        throw exo::exception::not_implemented();

    if (get_tag(b) == 3)
        throw exo::exception::not_implemented();

    ST(a) += ST(b);
}

void faddp(int a, int b)
{
    fadd(a, b);
    fpu_pop();
}


void fdiv(int a, int b)
{
    if (get_tag(a) == 3)
        throw exo::exception::not_implemented();
    if (get_tag(b) == 3)
        throw exo::exception::not_implemented();
    ST(a) /= ST(b);
}

void fdiv(uint_<64> & val_)
{
    double val = reinterpret_cast<double&>(val_);

    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();
    ST(0) /= val;
}

void fdivp(int a, int b)
{
    fdiv(a, b);
    fpu_pop();
}

void fdivr(int a, int b)
{
    if (get_tag(a) == 3)
        throw exo::exception::not_implemented();
    if (get_tag(b) == 3)
        throw exo::exception::not_implemented();
    ST(a) = ST(b) / ST(a);
}

void fdivr(uint_<64> & x)
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();

    double val = reinterpret_cast<double&>(x);

    ST(0) = val / ST(0);
}

void fdivrp(int a, int b)
{
    fdivr(a, b);
    fpu_pop();
}

void fmul(uint_<32> &)
{
    throw exo::exception::not_implemented();
}

void fmul(uint_<64> & x)
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();

    double val = reinterpret_cast<double&>(x);

    ST(0) *= val;
}

void fmul(int a, int b)
{
    if (get_tag(a) == 3)
        throw exo::exception::not_implemented();
    if (get_tag(b) == 3)
        throw exo::exception::not_implemented();
    ST(a) *= ST(b);
}

void fmulp(int a, int b)
{
    fmul(a, b);
    fpu_pop();
}

void fsub(int a, int b)
{
    if (get_tag(a) == 3)
        throw exo::exception::not_implemented();
    if (get_tag(b) == 3)
        throw exo::exception::not_implemented();
    ST(a) -= ST(b);
}

void fsubp(int a, int b)
{
    fsub(a, b);
    fpu_pop();
}

void fsubr(uint_<64> & x_)
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();

    double x = reinterpret_cast<double&>(x_);

    ST(0) = x - ST(0);
}

void fcom(uint_<64> & val_)
{
    double val = reinterpret_cast<double&>(val_);

    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();

    bool c0, c2, c3;
    if (ST(0) < val)
    {
        c0 = true;
        c2 = c3 = false;
    }
    else if (ST(0) == val)
    {
        c3 = true;
        c0 = c2 = false;
    }
    else if (ST(0) > val)
    {
        c0 = c2 = c3 = false;
    }
    else
    {
        if (get_invalid_flag())
            throw exo::exception::not_implemented();
        c0 = c2 = c3 = true;
    }

    set_c0(c0);
    set_c2(c2);
    set_c3(c3);
}

void fcom(int a, int b)
{
    if (get_tag(a) == 3)
        throw exo::exception::not_implemented();
    if (get_tag(b) == 3)
        throw exo::exception::not_implemented();

    bool c0, c2, c3;
    if (ST(a) < ST(b))
    {
        c0 = true;
        c2 = c3 = false;
    }
    else if (ST(a) == ST(b))
    {
        c3 = true;
        c0 = c2 = false;
    }
    else if (ST(a) > ST(b))
    {
        c0 = c2 = c3 = false;
    }
    else
    {
        if (get_invalid_flag())
            throw exo::exception::not_implemented();
        c0 = c2 = c3 = true;
    }

    set_c0(c0);
    set_c2(c2);
    set_c3(c3);
}

void fcom()
{
    fcom(0, 1);
}

void fcomp()
{
    fcom();
    fpu_pop();
}

void fcomp(uint_<64> & val)
{
    fcom(val);
    fpu_pop();
}

void fcomp(int a, int b)
{
    fcom(a, b);
    fpu_pop();
}

void fcompp()
{
    fcomp();
    fpu_pop();
}

void ftst()
{
    double val = 0;
    fcom(reinterpret_cast<uint_<64>&>(val));
}

void fxch(int src_n, int dst_n)
{
    std::swap(ST(src_n), ST(dst_n));

    auto tag = get_tag(src_n);
    set_tag(src_n, get_tag(dst_n));
    set_tag(dst_n, tag);
}

/**
 * @brief Load Integer.
 * Push <...> onto the FPU register stack.
 */
void fild(uint_<16> & x)
{
    set_top(get_top() + 7); // TOP ← TOP − 1;

    if (get_tag(0) != 3)
        throw exo::exception::not_implemented();

    ST(0) = static_cast<int16_t>(x);
    set_tag(0, 0);
}

/**
 * @brief Load Integer.
 * Push <...> onto the FPU register stack.
 */
void fild(uint_<32> & x)
{
    set_top(get_top() + 7); // TOP ← TOP − 1;

    if (get_tag(0) != 3)
        throw exo::exception::not_implemented();

    ST(0) = static_cast<int32_t>(x);
    set_tag(0, 0);
}

/**
 * @brief Load Integer.
 * Push <...> onto the FPU register stack.
 */
void fild(uint_<64> & x)
{
    set_top(get_top() + 7); // TOP ← TOP − 1;

    if (get_tag(0) != 3)
        throw exo::exception::not_implemented();

    ST(0) = static_cast<int64_t>(x);
    set_tag(0, 0);
}

/**
 * @brief Store Integer.
 * Store ST(0) in <...> and pop register stack.
 */
void fistp(uint_<32> & x_)
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();

    int32_t & x = reinterpret_cast<int32_t &>(x_); // from unsigned to signed

    x = ST(0);
    if (static_cast<__float80>(x) != ST(0))
        throw exo::exception::not_implemented();

    fpu_pop();
}

/**
 * @brief Store Integer.
 * Store ST(0) in <...> and pop register stack.
 */
void fistp(uint_<64> & x_)
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();

    int64_t & x = reinterpret_cast<int64_t &>(x_); // from unsigned to signed

    x = ST(0);
    if (static_cast<__float80>(x) != ST(0))
        throw exo::exception::not_implemented();

    fpu_pop();
}

/**
 * @brief Store Real.
 * Copy ST(0) to <...>.
 */
void fst(uint_<32> & x)
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();

    reinterpret_cast<float&>(x) = ST(0);
}

/**
 * @brief Store Real.
 * Copy ST(0) to <...>.
 */
void fst(uint_<64> & x)
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();

    reinterpret_cast<double&>(x) = ST(0);
}

/**
 * @brief Store Real.
 * Copy ST(0) to <...> and pop register stack.
 */
void fstp(uint_<32> & x)
{
    fst(x);
    fpu_pop();
}

/**
 * @brief Store Real.
 * Copy ST(0) to <...> and pop register stack.
 */
void fstp(uint_<64> & x)
{
    fst(x);
    fpu_pop();
}

/**
 * @brief Store Real.
 * Copy ST(0) to <...> and pop register stack.
 */
void fstp(uint_<80> &)
{
    throw exo::exception::not_implemented();
}

/**
 * @brief Store Real.
 * Copy ST(0) to ST(s) and pop register stack.
 */
void fstp(int s)
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();

    if (s != 0)
    {
        ST(s) = ST(0);
        set_tag(s, get_tag(0));
    }

    fpu_pop();
}

void fyl2x()
{
    // ST(1) ← ST(1) ∗ log2ST(0);

    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();
    if (get_tag(1) == 3)
        throw exo::exception::not_implemented();

    __float80 x = ST(0);
    __float80 y = ST(1);
    __float80 result;
    asm ("fyl2x" : "=t" (result) : "0" (x), "u" (y) : "st(1)");
    ST(1) = result;

    fpu_pop();
}

void fprem()
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();
    if (get_tag(1) == 3)
        throw exo::exception::not_implemented();

    __float80 x = ST(0);
    __float80 y = ST(1);
    __float80 result;
    asm ("fprem" : "=t" (result) : "0" (x), "u" (y));
    ST(0) = result;
}

/**
 * @brief Round to Integer.
 * Round ST(0) to an integer.
 */
void frndint()
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();

    __float80 x = ST(0);
    __float80 result;
    asm ("frndint" : "=t" (result) : "0" (x));
    ST(0) = result;
}

void fsqrt()
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();
    ST(0) = sqrtl(ST(0));
}

void fscale()
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();
    if (get_tag(1) == 3)
        throw exo::exception::not_implemented();

    ST(0) = ldexpl(ST(0), ST(1));
}

void fabs()
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();
    ST(0) = fabsl(ST(0));
}

void f2xm1()
{
    if (get_tag(0) == 3)
        throw exo::exception::not_implemented();

    __float80 x = ST(0);
    __float80 result;
    asm ("f2xm1" : "=t" (result) : "0" (x));
    ST(0) = result;
}


} /* namespace x86 */
} /* namespace raw_program */
