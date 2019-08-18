using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bc53f88d-e312-4b6e-9ec2-913f390f3088")]
        public void Method_100b_084c()
        {
            ii(0x100b_084c, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x100b_0851, 5); calld(Definitions.sys_check_available_stack_size, 0xb_54fc); /* call 0x10165d52 */
            ii(0x100b_0856, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_0857, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_0858, 1); pushd(esi);                             /* push esi */
            ii(0x100b_0859, 1); pushd(edi);                             /* push edi */
            ii(0x100b_085a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_085b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_085d, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100b_0863, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_0866, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_0869, 5); mov(ecx, 0x2900);                       /* mov ecx, 0x2900 */
            ii(0x100b_086e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_0870, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_0873, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100b_0876, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100b_0878, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_087b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_087e, 5); calld(0x100a_26d1, -0xe1b2);            /* call 0x100a26d1 */
            ii(0x100b_0883, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_0886, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_0889, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100b_088c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_088f, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_0892, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x3_a1a7); /* call 0x100766f0 */
            ii(0x100b_0897, 3); sub(eax, 0x15);                         /* sub eax, 0x15 */
            ii(0x100b_089a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_089d, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_08a0, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_08a3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_08a6, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_08a9, 5); calld(0x100b_7cbc, 0x740e);             /* call 0x100b7cbc */
            ii(0x100b_08ae, 3); sub(eax, 0x19);                         /* sub eax, 0x19 */
            ii(0x100b_08b1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_08b4, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_08b7, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_08ba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_08bd, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_08c0, 5); calld(0x1008_a634, -0x2_6291);          /* call 0x1008a634 */
            ii(0x100b_08c5, 3); sub(eax, 0x23);                         /* sub eax, 0x23 */
            ii(0x100b_08c8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_08cb, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_08ce, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_08d1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_08d4, 3); add(eax, 0x27);                         /* add eax, 0x27 */
            ii(0x100b_08d7, 5); calld(0x1008_a958, -0x2_5f84);          /* call 0x1008a958 */
            ii(0x100b_08dc, 3); sub(eax, 0x27);                         /* sub eax, 0x27 */
            ii(0x100b_08df, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_08e2, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_08e5, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_08e8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_08eb, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_53b4); /* mov dword [eax+0x2], 0x101b53b4 */
            ii(0x100b_08f2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_08f5, 4); mov(dx, memw_a32[ds, eax + 0x8]);       /* mov dx, [eax+0x8] */
            ii(0x100b_08f9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_08fc, 4); mov(memw_a32[ds, eax + 0x13], dx);      /* mov [eax+0x13], dx */
            ii(0x100b_0900, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100b_0903, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_0906, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_0909, 5); calld(0x1007_6630, -0x3_a2de);          /* call 0x10076630 */
            ii(0x100b_090e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0910, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_0913, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_0916, 5); calld(0x100b_7cfc, 0x73e1);             /* call 0x100b7cfc */
            ii(0x100b_091b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_091e, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100b_0921, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100b_0924, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_0926, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_0927, 1); popd(edi);                              /* pop edi */
            ii(0x100b_0928, 1); popd(esi);                              /* pop esi */
            ii(0x100b_0929, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_092a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_092b, 1); retd(); return;                         /* ret */
        }
    }
}
