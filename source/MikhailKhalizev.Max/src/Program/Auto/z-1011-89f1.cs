using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0fdf76d2-79ee-44a8-b743-436ac89df808")]
        public void Method_1011_89f1()
        {
            ii(0x1011_89f1, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_89f6, 5); calld(Definitions.sys_check_available_stack_size, 0x4_d357); /* call 0x10165d52 */
            ii(0x1011_89fb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_89fc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_89fd, 1); pushd(esi);                             /* push esi */
            ii(0x1011_89fe, 1); pushd(edi);                             /* push edi */
            ii(0x1011_89ff, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_8a00, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_8a02, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_8a08, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_8a0b, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_8a0e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_8a11, 3); mov(edx, memd_a32[ds, edx + 0x14]);     /* mov edx, [edx+0x14] */
            ii(0x1011_8a14, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_8a17, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_8a1a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_8a1c, 3); mov(bl, memb_a32[ds, eax + 0x2a]);      /* mov bl, [eax+0x2a] */
            ii(0x1011_8a1f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_8a21, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1011_8a24, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1011_8a26, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1011_8a29, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_8a2c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_8a2f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_8a31, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_8a32, 1); popd(edi);                              /* pop edi */
            ii(0x1011_8a33, 1); popd(esi);                              /* pop esi */
            ii(0x1011_8a34, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_8a35, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_8a36, 1); retd(); return;                         /* ret */
        }
    }
}