using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5277f34e-f6b4-4451-80fa-f47fac7d23a0")]
        public void Method_1014_899e()
        {
            ii(0x1014_899e, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1014_89a3, 5); calld(Definitions.sys_check_available_stack_size, 0x1_d3aa); /* call 0x10165d52 */
            ii(0x1014_89a8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_89a9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_89aa, 1); pushd(edx);                             /* push edx */
            ii(0x1014_89ab, 1); pushd(esi);                             /* push esi */
            ii(0x1014_89ac, 1); pushd(edi);                             /* push edi */
            ii(0x1014_89ad, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_89ae, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_89b0, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_89b6, 5); mov(eax, 0xe1);                         /* mov eax, 0xe1 */
            ii(0x1014_89bb, 5); calld(Definitions.sys_new, 0x1_d440);   /* call 0x10165e00 */
            ii(0x1014_89c0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_89c3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_89c6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_89c9, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_89cd, 2); if(jzd(0x1014_89e2, 0x13)) goto l_0x1014_89e2; /* jz 0x101489e2 */
            ii(0x1014_89cf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_89d2, 5); calld(0x1014_89fa, 0x23);               /* call 0x101489fa */
            ii(0x1014_89d7, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_89da, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_89dd, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_89e0, 2); jmpd(0x1014_89e8, 0x6); goto l_0x1014_89e8; /* jmp 0x101489e8 */
        l_0x1014_89e2:
            ii(0x1014_89e2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_89e5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x1014_89e8:
            ii(0x1014_89e8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_89eb, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_89ee, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_89f1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_89f3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_89f4, 1); popd(edi);                              /* pop edi */
            ii(0x1014_89f5, 1); popd(esi);                              /* pop esi */
            ii(0x1014_89f6, 1); popd(edx);                              /* pop edx */
            ii(0x1014_89f7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_89f8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_89f9, 1); retd(); return;                         /* ret */
        }
    }
}
