using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c80c4a6b-3afe-423d-a064-f098f0fee253")]
        public void Method_1008_7abb()
        {
            ii(0x1008_7abb, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1008_7ac0, 5); calld(Definitions.sys_check_available_stack_size, 0xde28d); /* call 0x10165d52 */
            ii(0x1008_7ac5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_7ac6, 1); pushd(esi);                             /* push esi */
            ii(0x1008_7ac7, 1); pushd(edi);                             /* push edi */
            ii(0x1008_7ac8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_7ac9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_7acb, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1008_7ad1, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_7ad4, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1008_7ad7, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1008_7ada, 5); mov(ecx, 0xf00);                        /* mov ecx, 0xf00 */
            ii(0x1008_7adf, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_7ae1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_7ae4, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1008_7ae7, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1008_7ae9, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1008_7aec, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_7aef, 5); calld(0x100a_26d1, 0x1abdd);            /* call 0x100a26d1 */
            ii(0x1008_7af4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_7af7, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_7afa, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_7afd, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_7b00, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_7b03, 5); calld(Definitions.my_ctor_0x101b38f8, -0x11418); /* call 0x100766f0 */
            ii(0x1008_7b08, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1008_7b0b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_7b0e, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_7b11, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1008_7b14, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_7b17, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_7b1a, 5); calld(Definitions.my_ctor_0x101b38f8, -0x1142f); /* call 0x100766f0 */
            ii(0x1008_7b1f, 3); sub(eax, 0x17);                         /* sub eax, 0x17 */
            ii(0x1008_7b22, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_7b25, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_7b28, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1008_7b2b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_7b2e, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_3b80); /* mov dword [eax+0x2], 0x101b3b80 */
            ii(0x1008_7b35, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1008_7b38, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_7b3b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_7b3e, 5); calld(0x1007_6630, -0x11513);           /* call 0x10076630 */
            ii(0x1008_7b43, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7b46, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1008_7b49, 4); mov(memw_a32[ds, edx + 0x1b], ax);      /* mov [edx+0x1b], ax */
            ii(0x1008_7b4d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_7b50, 4); mov(memb_a32[ds, eax + 0x1d], 0);       /* mov byte [eax+0x1d], 0x0 */
            ii(0x1008_7b54, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_7b57, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1008_7b5a, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1008_7b5d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_7b5f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_7b60, 1); popd(edi);                              /* pop edi */
            ii(0x1008_7b61, 1); popd(esi);                              /* pop esi */
            ii(0x1008_7b62, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_7b63, 1); retd(); return;                         /* ret */
        }
    }
}
