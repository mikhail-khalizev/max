using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("eca5b70a-b73d-4041-99c1-7ae768149f42")]
        public void Method_1008_c86c()
        {
            ii(0x1008_c86c, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1008_c871, 5); calld(Definitions.sys_check_available_stack_size, 0xd_94dc); /* call 0x10165d52 */
            ii(0x1008_c876, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_c877, 1); pushd(esi);                             /* push esi */
            ii(0x1008_c878, 1); pushd(edi);                             /* push edi */
            ii(0x1008_c879, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_c87a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_c87c, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1008_c882, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_c885, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1008_c888, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1008_c88b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_c88e, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1008_c891, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_c894, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1008_c897, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_c89a, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x1008_c89d, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1008_c8a0, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1008_c8a3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c8a6, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1008_c8a9, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1008_c8ab, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1008_c8ae, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_c8b1, 5); calld(0x100a_26d1, 0x1_5e1b);           /* call 0x100a26d1 */
            ii(0x1008_c8b6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_c8b9, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_c8bc, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1008_c8bf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_c8c2, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_c8c5, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x1_61da); /* call 0x100766f0 */
            ii(0x1008_c8ca, 3); sub(eax, 0x15);                         /* sub eax, 0x15 */
            ii(0x1008_c8cd, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_c8d0, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_c8d3, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_c8d6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_c8d9, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_46f4); /* mov dword [eax+0x2], 0x101b46f4 */
            ii(0x1008_c8e0, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_c8e3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_c8e6, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_c8e9, 5); calld(0x1007_6630, -0x1_62be);          /* call 0x10076630 */
            ii(0x1008_c8ee, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c8f1, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1f);    /* cmp byte [eax+0x3e], 0x1f */
            ii(0x1008_c8f5, 2); if(jnzd(0x1008_c90c, 0x15)) goto l_0x1008_c90c; /* jnz 0x1008c90c */
            ii(0x1008_c8f7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c8fa, 5); calld(0x1007_611c, -0x1_67e3);          /* call 0x1007611c */
            ii(0x1008_c8ff, 4); mov(dx, memw_a32[ds, eax + 0x8]);       /* mov dx, [eax+0x8] */
            ii(0x1008_c903, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_c906, 4); mov(memw_a32[ds, eax + 0x13], dx);      /* mov [eax+0x13], dx */
            ii(0x1008_c90a, 2); jmpd(0x1008_c91d, 0x11); goto l_0x1008_c91d; /* jmp 0x1008c91d */
        l_0x1008_c90c:
            ii(0x1008_c90c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c90f, 5); calld(0x1015_0a9e, 0xc_418a);           /* call 0x10150a9e */
            ii(0x1008_c914, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_c916, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_c919, 4); mov(memw_a32[ds, eax + 0x13], dx);      /* mov [eax+0x13], dx */
        l_0x1008_c91d:
            ii(0x1008_c91d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_c920, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1008_c923, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1008_c926, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_c928, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_c929, 1); popd(edi);                              /* pop edi */
            ii(0x1008_c92a, 1); popd(esi);                              /* pop esi */
            ii(0x1008_c92b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_c92c, 1); retd(); return;                         /* ret */
        }
    }
}
