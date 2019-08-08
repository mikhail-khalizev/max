using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("378f73b5-64ed-4291-ae80-45e5eb4cbaa6")]
        public void Method_1007_3cfd()
        {
            ii(0x1007_3cfd, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_3d02, 5); calld(Definitions.sys_check_available_stack_size, 0xf_204b); /* call 0x10165d52 */
            ii(0x1007_3d07, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_3d08, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_3d09, 1); pushd(esi);                             /* push esi */
            ii(0x1007_3d0a, 1); pushd(edi);                             /* push edi */
            ii(0x1007_3d0b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_3d0c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_3d0e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_3d14, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_3d17, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_3d1a, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1007_3d1e, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x1007_3d23, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_3d26, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1007_3d29, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_3d2d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_3d2f, 5); mov(eax, memd_a32[ds, 0x101c_9454]);    /* mov eax, [0x101c9454] */
            ii(0x1007_3d34, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_3d36, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_3d38, 2); mov(al, memb_a32[ds, edx]);             /* mov al, [edx] */
            ii(0x1007_3d3a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_3d3d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_3d40, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_3d42, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_3d43, 1); popd(edi);                              /* pop edi */
            ii(0x1007_3d44, 1); popd(esi);                              /* pop esi */
            ii(0x1007_3d45, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_3d46, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_3d47, 1); retd(); return;                         /* ret */
        }
    }
}
