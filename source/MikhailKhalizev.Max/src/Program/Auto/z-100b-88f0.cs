using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("580687ce-3e2d-4ca1-b41f-3c4134134036")]
        public void Method_100b_88f0()
        {
            ii(0x100b_88f0, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100b_88f5, 5); calld(Definitions.sys_check_available_stack_size, 0xa_d458); /* call 0x10165d52 */
            ii(0x100b_88fa, 1); pushd(esi);                             /* push esi */
            ii(0x100b_88fb, 1); pushd(edi);                             /* push edi */
            ii(0x100b_88fc, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_88fd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_88ff, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100b_8905, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_8908, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100b_890b, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100b_890e, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x100b_8911, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_8914, 5); calld(0x1013_aaa8, 0x8_218f);           /* call 0x1013aaa8 */
            ii(0x100b_8919, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_891c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_891f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_8922, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_8925, 3); add(eax, 0x9);                          /* add eax, 0x9 */
            ii(0x100b_8928, 5); calld(0x100a_b3f4, -0xd539);            /* call 0x100ab3f4 */
            ii(0x100b_892d, 3); sub(eax, 0x9);                          /* sub eax, 0x9 */
            ii(0x100b_8930, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_8933, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_8936, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_8939, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_893c, 3); add(eax, 0xd);                          /* add eax, 0xd */
            ii(0x100b_893f, 5); calld(Definitions.my_ctor_0x101b4184, -0x4_1e54); /* call 0x10076af0 */
            ii(0x100b_8944, 3); sub(eax, 0xd);                          /* sub eax, 0xd */
            ii(0x100b_8947, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_894a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_894d, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_5900); /* mov dword [eax+0x2], 0x101b5900 */
            ii(0x100b_8954, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_8957, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100b_895a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_895d, 5); calld(0x100b_8852, -0x110);             /* call 0x100b8852 */
            ii(0x100b_8962, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100b_8964, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_8967, 3); mov(memb_a32[ds, eax + 0x6], dl);       /* mov [eax+0x6], dl */
            ii(0x100b_896a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_896d, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x100b_8971, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_8974, 4); mov(memw_a32[ds, eax + 0xd], dx);       /* mov [eax+0xd], dx */
            ii(0x100b_8978, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_897b, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x100b_897f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_8982, 4); mov(memw_a32[ds, eax + 0xf], dx);       /* mov [eax+0xf], dx */
            ii(0x100b_8986, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_8989, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_898c, 3); add(eax, 0x9);                          /* add eax, 0x9 */
            ii(0x100b_898f, 5); calld(0x100b_8244, -0x750);             /* call 0x100b8244 */
            ii(0x100b_8994, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8997, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100b_899a, 4); mov(memw_a32[ds, edx + 0x7], ax);       /* mov [edx+0x7], ax */
            ii(0x100b_899e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_89a1, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100b_89a4, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_89a7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_89a9, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_89aa, 1); popd(edi);                              /* pop edi */
            ii(0x100b_89ab, 1); popd(esi);                              /* pop esi */
            ii(0x100b_89ac, 1); retd(); return;                         /* ret */
        }
    }
}
