using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("442112e1-a1c1-4335-806d-565949744057")]
        public void Method_1011_9dde()
        {
            ii(0x1011_9dde, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1011_9de3, 5); calld(Definitions.sys_check_available_stack_size, 0x4_bf6a); /* call 0x10165d52 */
            ii(0x1011_9de8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_9de9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_9dea, 1); pushd(edx);                             /* push edx */
            ii(0x1011_9deb, 1); pushd(esi);                             /* push esi */
            ii(0x1011_9dec, 1); pushd(edi);                             /* push edi */
            ii(0x1011_9ded, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_9dee, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_9df0, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1011_9df6, 5); mov(eax, 0x2d);                         /* mov eax, 0x2d */
            ii(0x1011_9dfb, 5); calld(Definitions.sys_new, 0x4_c000);   /* call 0x10165e00 */
            ii(0x1011_9e00, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_9e03, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_9e06, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_9e09, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1011_9e0d, 2); if(jzd(0x1011_9e22, 0x13)) goto l_0x1011_9e22; /* jz 0x10119e22 */
            ii(0x1011_9e0f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_9e12, 5); calld(0x1011_82f3, -0x1b24);            /* call 0x101182f3 */
            ii(0x1011_9e17, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_9e1a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_9e1d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_9e20, 2); jmpd(0x1011_9e28, 0x6); goto l_0x1011_9e28; /* jmp 0x10119e28 */
        l_0x1011_9e22:
            ii(0x1011_9e22, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_9e25, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x1011_9e28:
            ii(0x1011_9e28, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_9e2b, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_9e2e, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_9e31, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_9e33, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_9e34, 1); popd(edi);                              /* pop edi */
            ii(0x1011_9e35, 1); popd(esi);                              /* pop esi */
            ii(0x1011_9e36, 1); popd(edx);                              /* pop edx */
            ii(0x1011_9e37, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_9e38, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_9e39, 1); retd(); return;                         /* ret */
        }
    }
}
