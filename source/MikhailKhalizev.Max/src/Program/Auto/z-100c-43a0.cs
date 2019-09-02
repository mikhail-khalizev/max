using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_43a0-c734e206")]
        public void Method_100c_43a0()
        {
            ii(0x100c_43a0, 5); push(0x20);                             /* push 0x20 */
            ii(0x100c_43a5, 5); call(Definitions.sys_check_available_stack_size, 0xa_19a8); /* call 0x10165d52 */
            ii(0x100c_43aa, 1); push(ebx);                              /* push ebx */
            ii(0x100c_43ab, 1); push(ecx);                              /* push ecx */
            ii(0x100c_43ac, 1); push(edx);                              /* push edx */
            ii(0x100c_43ad, 1); push(esi);                              /* push esi */
            ii(0x100c_43ae, 1); push(edi);                              /* push edi */
            ii(0x100c_43af, 1); push(ebp);                              /* push ebp */
            ii(0x100c_43b0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_43b2, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100c_43b8, 5); mov(eax, memd[ds, 0x101c_3964]);        /* mov eax, [0x101c3964] */
            ii(0x100c_43bd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_43c0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_43c2, 2); if(jz(0x100c_43cd, 9)) goto l_0x100c_43cd; /* jz 0x100c43cd */
            ii(0x100c_43c4, 7); mov(memd[ss, ebp - 4], 2);              /* mov dword [ebp-0x4], 0x2 */
            ii(0x100c_43cb, 2); jmp(0x100c_4402, 0x35); goto l_0x100c_4402; /* jmp 0x100c4402 */
        l_0x100c_43cd:
            ii(0x100c_43cd, 5); mov(eax, memd[ds, 0x101c_3966]);        /* mov eax, [0x101c3966] */
            ii(0x100c_43d2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_43d5, 3); cmp(eax, 0x64);                         /* cmp eax, 0x64 */
            ii(0x100c_43d8, 2); if(jge(0x100c_43e3, 9)) goto l_0x100c_43e3; /* jge 0x100c43e3 */
            ii(0x100c_43da, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
            ii(0x100c_43e1, 2); jmp(0x100c_4402, 0x1f); goto l_0x100c_4402; /* jmp 0x100c4402 */
        l_0x100c_43e3:
            ii(0x100c_43e3, 5); mov(eax, memd[ds, 0x101c_3966]);        /* mov eax, [0x101c3966] */
            ii(0x100c_43e8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_43eb, 5); cmp(eax, 0xc8);                         /* cmp eax, 0xc8 */
            ii(0x100c_43f0, 2); if(jge(0x100c_43fb, 9)) goto l_0x100c_43fb; /* jge 0x100c43fb */
            ii(0x100c_43f2, 7); mov(memd[ss, ebp - 4], 1);              /* mov dword [ebp-0x4], 0x1 */
            ii(0x100c_43f9, 2); jmp(0x100c_4402, 7); goto l_0x100c_4402; /* jmp 0x100c4402 */
        l_0x100c_43fb:
            ii(0x100c_43fb, 7); mov(memd[ss, ebp - 4], 2);              /* mov dword [ebp-0x4], 0x2 */
        l_0x100c_4402:
            ii(0x100c_4402, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_4405, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_4407, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_4408, 1); pop(edi);                               /* pop edi */
            ii(0x100c_4409, 1); pop(esi);                               /* pop esi */
            ii(0x100c_440a, 1); pop(edx);                               /* pop edx */
            ii(0x100c_440b, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_440c, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_440d, 1); ret();                                  /* ret */
        }
    }
}
