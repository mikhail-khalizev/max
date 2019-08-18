using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_6bd8-c3838671")]
        public void Method_100a_6bd8()
        {
            ii(0x100a_6bd8, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x100a_6bdd, 5); calld(Definitions.sys_check_available_stack_size, 0xb_f170); /* call 0x10165d52 */
            ii(0x100a_6be2, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_6be3, 1); pushd(esi);                             /* push esi */
            ii(0x100a_6be4, 1); pushd(edi);                             /* push edi */
            ii(0x100a_6be5, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_6be6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_6be8, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100a_6bee, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_6bf1, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_6bf4, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100a_6bf7, 5); mov(ecx, 0x2300);                       /* mov ecx, 0x2300 */
            ii(0x100a_6bfc, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100a_6bff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6c02, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100a_6c05, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100a_6c07, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_6c0a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_6c0d, 5); calld(0x100a_26d1, -0x4541);            /* call 0x100a26d1 */
            ii(0x100a_6c12, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_6c15, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_6c18, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_6c1b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_6c1e, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6c21, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x3_0536); /* call 0x100766f0 */
            ii(0x100a_6c26, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100a_6c29, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_6c2c, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_6c2f, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100a_6c32, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_6c35, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100a_6c38, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x3_054d); /* call 0x100766f0 */
            ii(0x100a_6c3d, 3); sub(eax, 0x17);                         /* sub eax, 0x17 */
            ii(0x100a_6c40, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_6c43, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_6c46, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_6c49, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_6c4c, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x100a_6c4f, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x3_0564); /* call 0x100766f0 */
            ii(0x100a_6c54, 3); sub(eax, 0x1b);                         /* sub eax, 0x1b */
            ii(0x100a_6c57, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_6c5a, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_6c5d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_6c60, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_6c63, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_4e08); /* mov dword [eax+0x2], 0x101b4e08 */
            ii(0x100a_6c6a, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100a_6c6e, 2); if(jzd(0x100a_6c8b, 0x1b)) goto l_0x100a_6c8b; /* jz 0x100a6c8b */
            ii(0x100a_6c70, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_6c73, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100a_6c76, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100a_6c79, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100a_6c7c, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100a_6c7f, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100a_6c82, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_6c84, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_6c87, 4); mov(memw_a32[ds, eax + 0xd], dx);       /* mov [eax+0xd], dx */
        l_0x100a_6c8b:
            ii(0x100a_6c8b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_6c8e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_6c91, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6c94, 5); calld(0x1007_6630, -0x3_0669);          /* call 0x10076630 */
            ii(0x100a_6c99, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_6c9c, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100a_6c9f, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100a_6ca2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_6ca4, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_6ca5, 1); popd(edi);                              /* pop edi */
            ii(0x100a_6ca6, 1); popd(esi);                              /* pop esi */
            ii(0x100a_6ca7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_6ca8, 1); retd(); return;                         /* ret */
        }
    }
}
