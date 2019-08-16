using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3dbe7684-c755-4809-9ab6-4b18020b72d7")]
        public void Method_100c_43a0()
        {
            ii(0x100c_43a0, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_43a5, 5); calld(Definitions.sys_check_available_stack_size, 0xa_19a8); /* call 0x10165d52 */
            ii(0x100c_43aa, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_43ab, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_43ac, 1); pushd(edx);                             /* push edx */
            ii(0x100c_43ad, 1); pushd(esi);                             /* push esi */
            ii(0x100c_43ae, 1); pushd(edi);                             /* push edi */
            ii(0x100c_43af, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_43b0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_43b2, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_43b8, 5); mov(eax, memd_a32[ds, 0x101c_3964]);    /* mov eax, [0x101c3964] */
            ii(0x100c_43bd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_43c0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_43c2, 2); if(jzd(0x100c_43cd, 0x9)) goto l_0x100c_43cd; /* jz 0x100c43cd */
            ii(0x100c_43c4, 7); mov(memd_a32[ss, ebp - 0x4], 0x2);      /* mov dword [ebp-0x4], 0x2 */
            ii(0x100c_43cb, 2); jmpd(0x100c_4402, 0x35); goto l_0x100c_4402; /* jmp 0x100c4402 */
        l_0x100c_43cd:
            ii(0x100c_43cd, 5); mov(eax, memd_a32[ds, 0x101c_3966]);    /* mov eax, [0x101c3966] */
            ii(0x100c_43d2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_43d5, 3); cmp(eax, 0x64);                         /* cmp eax, 0x64 */
            ii(0x100c_43d8, 2); if(jged(0x100c_43e3, 0x9)) goto l_0x100c_43e3; /* jge 0x100c43e3 */
            ii(0x100c_43da, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x100c_43e1, 2); jmpd(0x100c_4402, 0x1f); goto l_0x100c_4402; /* jmp 0x100c4402 */
        l_0x100c_43e3:
            ii(0x100c_43e3, 5); mov(eax, memd_a32[ds, 0x101c_3966]);    /* mov eax, [0x101c3966] */
            ii(0x100c_43e8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_43eb, 5); cmp(eax, 0xc8);                         /* cmp eax, 0xc8 */
            ii(0x100c_43f0, 2); if(jged(0x100c_43fb, 0x9)) goto l_0x100c_43fb; /* jge 0x100c43fb */
            ii(0x100c_43f2, 7); mov(memd_a32[ss, ebp - 0x4], 0x1);      /* mov dword [ebp-0x4], 0x1 */
            ii(0x100c_43f9, 2); jmpd(0x100c_4402, 0x7); goto l_0x100c_4402; /* jmp 0x100c4402 */
        l_0x100c_43fb:
            ii(0x100c_43fb, 7); mov(memd_a32[ss, ebp - 0x4], 0x2);      /* mov dword [ebp-0x4], 0x2 */
        l_0x100c_4402:
            ii(0x100c_4402, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_4405, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_4407, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_4408, 1); popd(edi);                              /* pop edi */
            ii(0x100c_4409, 1); popd(esi);                              /* pop esi */
            ii(0x100c_440a, 1); popd(edx);                              /* pop edx */
            ii(0x100c_440b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_440c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_440d, 1); retd(); return;                         /* ret */
        }
    }
}