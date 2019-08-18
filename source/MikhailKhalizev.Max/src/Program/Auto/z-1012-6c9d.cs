using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9760dc6d-3d00-4ded-b0e6-36b619347713")]
        public void Method_1012_6c9d()
        {
            ii(0x1012_6c9d, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_6ca2, 5); calld(Definitions.sys_check_available_stack_size, 0x3_f0ab); /* call 0x10165d52 */
            ii(0x1012_6ca7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_6ca8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_6ca9, 1); pushd(edx);                             /* push edx */
            ii(0x1012_6caa, 1); pushd(esi);                             /* push esi */
            ii(0x1012_6cab, 1); pushd(edi);                             /* push edi */
            ii(0x1012_6cac, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_6cad, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_6caf, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1012_6cb5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_6cb8, 7); mov(memd_a32[ss, ebp - 0x8], 0x101c_59f5); /* mov dword [ebp-0x8], 0x101c59f5 */
            ii(0x1012_6cbf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_6cc2, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1012_6cc5, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1012_6cc9, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_6ccf, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1012_6cd5, 5); calld(0x100c_b60c, -0x5_b6ce);          /* call 0x100cb60c */
            ii(0x1012_6cda, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1012_6cde, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1012_6ce4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_6ce7, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x1012_6ceb, 7); mov(memw_a32[ds, edx + 0x101c_a583], ax); /* mov [edx+0x101ca583], ax */
            ii(0x1012_6cf2, 5); mov(ebx, 0x28);                         /* mov ebx, 0x28 */
            ii(0x1012_6cf7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_6cfa, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x1012_6cfd, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1012_6d01, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_6d07, 5); mov(ecx, 0x101c_a468);                  /* mov ecx, 0x101ca468 */
            ii(0x1012_6d0c, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1012_6d0e, 5); calld(Definitions.sys_memcpy, 0x3_f138); /* call 0x10165e4b */
            ii(0x1012_6d13, 5); mov(ebx, 0x60);                         /* mov ebx, 0x60 */
            ii(0x1012_6d18, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_6d1b, 3); add(edx, 0x4a);                         /* add edx, 0x4a */
            ii(0x1012_6d1e, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1012_6d22, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_6d28, 5); mov(ecx, 0x101c_a468);                  /* mov ecx, 0x101ca468 */
            ii(0x1012_6d2d, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1012_6d2f, 5); add(eax, 0x88);                         /* add eax, 0x88 */
            ii(0x1012_6d34, 5); calld(Definitions.sys_memcpy, 0x3_f112); /* call 0x10165e4b */
            ii(0x1012_6d39, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1012_6d3c, 3); add(ebx, 0x2c);                         /* add ebx, 0x2c */
            ii(0x1012_6d3f, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1012_6d42, 2); add(al, 0x63);                          /* add al, 0x63 */
            ii(0x1012_6d44, 3); movsx(edx, al);                         /* movsx edx, al */
            ii(0x1012_6d47, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1012_6d4c, 5); calld(0x1010_6205, -0x2_0b4c);          /* call 0x10106205 */
            ii(0x1012_6d51, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_6d53, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_6d54, 1); popd(edi);                              /* pop edi */
            ii(0x1012_6d55, 1); popd(esi);                              /* pop esi */
            ii(0x1012_6d56, 1); popd(edx);                              /* pop edx */
            ii(0x1012_6d57, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_6d58, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_6d59, 1); retd(); return;                         /* ret */
        }
    }
}
