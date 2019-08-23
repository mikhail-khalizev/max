using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_9fd0-9085f2f6")]
        public void Method_1011_9fd0()
        {
            ii(0x1011_9fd0, 5); push(0x24);                             /* push 0x24 */
            ii(0x1011_9fd5, 5); call(Definitions.sys_check_available_stack_size, 0x4_bd78); /* call 0x10165d52 */
            ii(0x1011_9fda, 1); push(ebx);                              /* push ebx */
            ii(0x1011_9fdb, 1); push(ecx);                              /* push ecx */
            ii(0x1011_9fdc, 1); push(esi);                              /* push esi */
            ii(0x1011_9fdd, 1); push(edi);                              /* push edi */
            ii(0x1011_9fde, 1); push(ebp);                              /* push ebp */
            ii(0x1011_9fdf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_9fe1, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_9fe7, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_9fea, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_9fed, 7); test(memd[ss, ebp - 0x4], 0x4);         /* test dword [ebp-0x4], 0x4 */
            ii(0x1011_9ff4, 2); if(jz(0x1011_a00a, 0x14)) goto l_0x1011_a00a; /* jz 0x1011a00a */
            ii(0x1011_9ff6, 5); mov(edx, 0x101b_6894);                  /* mov edx, 0x101b6894 */
            ii(0x1011_9ffb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_9ffe, 5); call(Definitions.sys_call_dtor_arr, 0x4_bfb5); /* call 0x10165fb8 */
            ii(0x1011_a003, 5); call(Definitions.sys_delete_arr, 0x4_bfd0); /* call 0x10165fd8 */
            ii(0x1011_a008, 2); jmp(0x1011_a048, 0x3e); goto l_0x1011_a048; /* jmp 0x1011a048 */
        l_0x1011_a00a:
            ii(0x1011_a00a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_a00d, 7); mov(memd[ds, eax + 0x2], 0x101b_6924);  /* mov dword [eax+0x2], 0x101b6924 */
            ii(0x1011_a014, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_a016, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_a019, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_a01c, 5); call(0x100b_7294, -0x6_2d8d);           /* call 0x100b7294 */
            ii(0x1011_a021, 3); sub(eax, 0x18);                         /* sub eax, 0x18 */
            ii(0x1011_a024, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_a027, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_a02c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_a02f, 5); call(0x1012_02cc, 0x6298);              /* call 0x101202cc */
            ii(0x1011_a034, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_a037, 7); test(memd[ss, ebp - 0x4], 0x2);         /* test dword [ebp-0x4], 0x2 */
            ii(0x1011_a03e, 2); if(jz(0x1011_a048, 0x8)) goto l_0x1011_a048; /* jz 0x1011a048 */
            ii(0x1011_a040, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_a043, 5); call(Definitions.sys_delete, 0x4_bf1c); /* call 0x10165f64 */
        l_0x1011_a048:
            ii(0x1011_a048, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_a04b, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1011_a04e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_a051, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_a053, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_a054, 1); pop(edi);                               /* pop edi */
            ii(0x1011_a055, 1); pop(esi);                               /* pop esi */
            ii(0x1011_a056, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_a057, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_a058, 1); ret();                                  /* ret */
        }
    }
}
