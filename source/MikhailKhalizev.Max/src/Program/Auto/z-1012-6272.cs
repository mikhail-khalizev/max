using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("54ab319c-584a-4f0c-8d68-d91b9549d78e")]
        public void Method_1012_6272()
        {
            ii(0x1012_6272, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_6277, 5); calld(Definitions.sys_check_available_stack_size, 0x3_fad6); /* call 0x10165d52 */
            ii(0x1012_627c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_627d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_627e, 1); pushd(esi);                             /* push esi */
            ii(0x1012_627f, 1); pushd(edi);                             /* push edi */
            ii(0x1012_6280, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_6281, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_6283, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_6289, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_628c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_628f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_6292, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_6295, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_6298, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_629b, 5); calld(0x1012_5fba, -0x2e6);             /* call 0x10125fba */
            ii(0x1012_62a0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_62a3, 3); mov(dl, memb_a32[ds, eax + 0xd]);       /* mov dl, [eax+0xd] */
            ii(0x1012_62a6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_62a9, 3); mov(memb_a32[ds, eax + 0x46], dl);      /* mov [eax+0x46], dl */
            ii(0x1012_62ac, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_62af, 3); mov(dl, memb_a32[ds, eax + 0xe]);       /* mov dl, [eax+0xe] */
            ii(0x1012_62b2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_62b5, 3); mov(memb_a32[ds, eax + 0x47], dl);      /* mov [eax+0x47], dl */
            ii(0x1012_62b8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_62bb, 3); mov(dl, memb_a32[ds, eax + 0xf]);       /* mov dl, [eax+0xf] */
            ii(0x1012_62be, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_62c1, 3); mov(memb_a32[ds, eax + 0x48], dl);      /* mov [eax+0x48], dl */
            ii(0x1012_62c4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_62c7, 3); mov(dl, memb_a32[ds, eax + 0x10]);      /* mov dl, [eax+0x10] */
            ii(0x1012_62ca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_62cd, 3); mov(memb_a32[ds, eax + 0x49], dl);      /* mov [eax+0x49], dl */
            ii(0x1012_62d0, 7); mov(memd_a32[ss, ebp - 0xc], 0x11);     /* mov dword [ebp-0xc], 0x11 */
            ii(0x1012_62d7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_62da, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_62dc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_62dd, 1); popd(edi);                              /* pop edi */
            ii(0x1012_62de, 1); popd(esi);                              /* pop esi */
            ii(0x1012_62df, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_62e0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_62e1, 1); retd(); return;                         /* ret */
        }
    }
}
