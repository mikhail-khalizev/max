using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6ff76dd6-7e13-46c7-b4b9-5ac274ee6118")]
        public void Method_1007_f279()
        {
            ii(0x1007_f279, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1007_f27e, 5); calld(Definitions.sys_check_available_stack_size, 0xe_6acf); /* call 0x10165d52 */
            ii(0x1007_f283, 1); pushd(esi);                             /* push esi */
            ii(0x1007_f284, 1); pushd(edi);                             /* push edi */
            ii(0x1007_f285, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_f286, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_f288, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1007_f28e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_f291, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1007_f294, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x1007_f297, 3); mov(memb_a32[ss, ebp - 0x4], cl);       /* mov [ebp-0x4], cl */
            ii(0x1007_f29a, 5); mov(ecx, 0x400);                        /* mov ecx, 0x400 */
            ii(0x1007_f29f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_f2a1, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1007_f2a5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_f2a8, 5); calld(0x100a_26d1, 0x2_3424);           /* call 0x100a26d1 */
            ii(0x1007_f2ad, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_f2b0, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_f2b3, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_f2b6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_f2b9, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1007_f2bc, 5); calld(0x1008_a330, 0xb06f);             /* call 0x1008a330 */
            ii(0x1007_f2c1, 3); sub(eax, 0x14);                         /* sub eax, 0x14 */
            ii(0x1007_f2c4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_f2c7, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_f2ca, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1007_f2cd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_f2d0, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1007_f2d3, 5); calld(Definitions.my_ctor_0x101b56fc, 0x99a4); /* call 0x10088c7c */
            ii(0x1007_f2d8, 3); sub(eax, 0x18);                         /* sub eax, 0x18 */
            ii(0x1007_f2db, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_f2de, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_f2e1, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1007_f2e4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_f2e7, 3); add(eax, 0x22);                         /* add eax, 0x22 */
            ii(0x1007_f2ea, 5); calld(Definitions.my_ctor_0x101b56fc, 0x998d); /* call 0x10088c7c */
            ii(0x1007_f2ef, 3); sub(eax, 0x22);                         /* sub eax, 0x22 */
            ii(0x1007_f2f2, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_f2f5, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_f2f8, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1007_f2fb, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_f2fe, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_3d40); /* mov dword [eax+0x2], 0x101b3d40 */
            ii(0x1007_f305, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1007_f308, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_f30b, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1007_f30e, 5); calld(0x1008_a2b4, 0xafa1);             /* call 0x1008a2b4 */
            ii(0x1007_f313, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1007_f316, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1007_f319, 3); mov(memb_a32[ds, edx + 0x2c], al);      /* mov [edx+0x2c], al */
            ii(0x1007_f31c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_f31f, 4); mov(memb_a32[ds, eax + 0x13], 0);       /* mov byte [eax+0x13], 0x0 */
            ii(0x1007_f323, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_f326, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1007_f329, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1007_f32c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_f32e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_f32f, 1); popd(edi);                              /* pop edi */
            ii(0x1007_f330, 1); popd(esi);                              /* pop esi */
            ii(0x1007_f331, 1); retd(); return;                         /* ret */
        }
    }
}
