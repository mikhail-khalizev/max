using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("66a18b29-3796-4906-aec1-a99bb4663388")]
        public void Method_1010_6ee0()
        {
            ii(0x1010_6ee0, 5); pushd(0x54);                            /* push 0x54 */
            ii(0x1010_6ee5, 5); calld(Definitions.sys_check_available_stack_size, 0x5ee68); /* call 0x10165d52 */
            ii(0x1010_6eea, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_6eeb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_6eec, 1); pushd(edx);                             /* push edx */
            ii(0x1010_6eed, 1); pushd(esi);                             /* push esi */
            ii(0x1010_6eee, 1); pushd(edi);                             /* push edi */
            ii(0x1010_6eef, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_6ef0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6ef2, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1010_6ef8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_6efb, 5); mov(ebx, 0x32);                         /* mov ebx, 0x32 */
            ii(0x1010_6f00, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_6f02, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1010_6f05, 5); calld(Definitions.sys_memset, 0x5eed6); /* call 0x10165de0 */
            ii(0x1010_6f0a, 7); mov(memd_a32[ss, ebp - 0x28], 0x4);     /* mov dword [ebp-0x28], 0x4 */
            ii(0x1010_6f11, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_6f14, 3); and(eax, 0xf);                          /* and eax, 0xf */
            ii(0x1010_6f17, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1010_6f1a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_6f1d, 3); shr(eax, 0x4);                          /* shr eax, 0x4 */
            ii(0x1010_6f20, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1010_6f25, 4); mov(memw_a32[ss, ebp - 0x16], ax);      /* mov [ebp-0x16], ax */
            ii(0x1010_6f29, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x1010_6f2c, 5); mov(eax, 0x7a);                         /* mov eax, 0x7a */
            ii(0x1010_6f31, 5); calld(0x100e_44ba, -0x22a7c);           /* call 0x100e44ba */
            ii(0x1010_6f36, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_6f38, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_6f39, 1); popd(edi);                              /* pop edi */
            ii(0x1010_6f3a, 1); popd(esi);                              /* pop esi */
            ii(0x1010_6f3b, 1); popd(edx);                              /* pop edx */
            ii(0x1010_6f3c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_6f3d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_6f3e, 1); retd(); return;                         /* ret */
        }
    }
}
