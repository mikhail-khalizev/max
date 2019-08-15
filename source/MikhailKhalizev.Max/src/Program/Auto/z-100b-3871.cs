using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f6f6267a-cd53-45b2-b29e-217b520e026d")]
        public void Method_100b_3871()
        {
            ii(0x100b_3871, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x100b_3876, 5); calld(Definitions.sys_check_available_stack_size, 0xb_24d7); /* call 0x10165d52 */
            ii(0x100b_387b, 1); pushd(esi);                             /* push esi */
            ii(0x100b_387c, 1); pushd(edi);                             /* push edi */
            ii(0x100b_387d, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_387e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_3880, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100b_3886, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_3889, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100b_388c, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100b_388f, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100b_3892, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_3895, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100b_3898, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100b_389b, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100b_389e, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100b_38a1, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100b_38a4, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100b_38a7, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100b_38aa, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_38ad, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100b_38b0, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100b_38b2, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_38b5, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_38b8, 5); calld(0x100a_26d1, -0x1_11ec);          /* call 0x100a26d1 */
            ii(0x100b_38bd, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_38c0, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_38c3, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100b_38c6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_38c9, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_38cc, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x3_d1e1); /* call 0x100766f0 */
            ii(0x100b_38d1, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100b_38d4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_38d7, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_38da, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100b_38dd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_38e0, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_38e3, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x3_d1f8); /* call 0x100766f0 */
            ii(0x100b_38e8, 3); sub(eax, 0x17);                         /* sub eax, 0x17 */
            ii(0x100b_38eb, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_38ee, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_38f1, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_38f4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_38f7, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100b_38fa, 5); calld(0x1009_c930, -0x1_6fcf);          /* call 0x1009c930 */
            ii(0x100b_38ff, 3); sub(eax, 0x1b);                         /* sub eax, 0x1b */
            ii(0x100b_3902, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_3905, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_3908, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_390b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_390e, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_52d4); /* mov dword [eax+0x2], 0x101b52d4 */
            ii(0x100b_3915, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_3918, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_391b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_391e, 5); calld(0x1007_6630, -0x3_d2f3);          /* call 0x10076630 */
            ii(0x100b_3923, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_3926, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_3929, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_392c, 5); calld(0x1007_6630, -0x3_d301);          /* call 0x10076630 */
            ii(0x100b_3931, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_3934, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100b_3937, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100b_393a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_393c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_393d, 1); popd(edi);                              /* pop edi */
            ii(0x100b_393e, 1); popd(esi);                              /* pop esi */
            ii(0x100b_393f, 1); retd(); return;                         /* ret */
        }
    }
}
