using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_c45d-2c6be47")]
        public void Method_100a_c45d()
        {
            ii(0x100a_c45d, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100a_c462, 5); calld(Definitions.sys_check_available_stack_size, 0xb_98eb); /* call 0x10165d52 */
            ii(0x100a_c467, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_c468, 1); pushd(esi);                             /* push esi */
            ii(0x100a_c469, 1); pushd(edi);                             /* push edi */
            ii(0x100a_c46a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_c46b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_c46d, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100a_c473, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_c476, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_c479, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100a_c47c, 5); mov(ecx, 0x2900);                       /* mov ecx, 0x2900 */
            ii(0x100a_c481, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_c483, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_c486, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_c488, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x100a_c48b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_c48e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c491, 5); calld(0x100a_26d1, -0x9dc5);            /* call 0x100a26d1 */
            ii(0x100a_c496, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_c499, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_c49c, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_c49f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c4a2, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_c4a5, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x3_5dba); /* call 0x100766f0 */
            ii(0x100a_c4aa, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100a_c4ad, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_c4b0, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_c4b3, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100a_c4b6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c4b9, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100a_c4bc, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_59d1); /* call 0x10076af0 */
            ii(0x100a_c4c1, 3); sub(eax, 0x1a);                         /* sub eax, 0x1a */
            ii(0x100a_c4c4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_c4c7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c4ca, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_c4cd, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_59e2); /* call 0x10076af0 */
            ii(0x100a_c4d2, 3); sub(eax, 0x1e);                         /* sub eax, 0x1e */
            ii(0x100a_c4d5, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_c4d8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c4db, 3); add(eax, 0x22);                         /* add eax, 0x22 */
            ii(0x100a_c4de, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_59f3); /* call 0x10076af0 */
            ii(0x100a_c4e3, 3); sub(eax, 0x22);                         /* sub eax, 0x22 */
            ii(0x100a_c4e6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_c4e9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c4ec, 3); add(eax, 0x28);                         /* add eax, 0x28 */
            ii(0x100a_c4ef, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_5a04); /* call 0x10076af0 */
            ii(0x100a_c4f4, 3); sub(eax, 0x28);                         /* sub eax, 0x28 */
            ii(0x100a_c4f7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_c4fa, 5); calld(0x100a_ab28, -0x19d7);            /* call 0x100aab28 */
            ii(0x100a_c4ff, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_c502, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c505, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_c508, 5); calld(0x100a_aad4, -0x1a39);            /* call 0x100aaad4 */
            ii(0x100a_c50d, 3); sub(eax, 0x2c);                         /* sub eax, 0x2c */
            ii(0x100a_c510, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_c513, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_c516, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_c519, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c51c, 3); add(eax, 0x3c);                         /* add eax, 0x3c */
            ii(0x100a_c51f, 5); calld(0x1009_c930, -0xfbf4);            /* call 0x1009c930 */
            ii(0x100a_c524, 3); sub(eax, 0x3c);                         /* sub eax, 0x3c */
            ii(0x100a_c527, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_c52a, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_c52d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_c530, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c533, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_5494); /* mov dword [eax+0x2], 0x101b5494 */
            ii(0x100a_c53a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_c53d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c540, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_c543, 5); calld(0x1007_6630, -0x3_5f18);          /* call 0x10076630 */
            ii(0x100a_c548, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c54b, 4); mov(memb_a32[ds, eax + 0x45], 0);       /* mov byte [eax+0x45], 0x0 */
            ii(0x100a_c54f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c552, 4); mov(memb_a32[ds, eax + 0x47], 0);       /* mov byte [eax+0x47], 0x0 */
            ii(0x100a_c556, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c559, 6); mov(memw_a32[ds, eax + 0x17], 0);       /* mov word [eax+0x17], 0x0 */
            ii(0x100a_c55f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c562, 4); mov(memb_a32[ds, eax + 0x19], 0x3);     /* mov byte [eax+0x19], 0x3 */
            ii(0x100a_c566, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c569, 6); mov(memw_a32[ds, eax + 0x22], 0xffff);  /* mov word [eax+0x22], 0xffff */
            ii(0x100a_c56f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c572, 6); mov(memw_a32[ds, eax + 0x24], 0xffff);  /* mov word [eax+0x24], 0xffff */
            ii(0x100a_c578, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_c57b, 3); add(edx, 0x22);                         /* add edx, 0x22 */
            ii(0x100a_c57e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c581, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_c584, 5); calld(0x1008_8b44, -0x2_3a45);          /* call 0x10088b44 */
            ii(0x100a_c589, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_c58c, 3); add(edx, 0x22);                         /* add edx, 0x22 */
            ii(0x100a_c58f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c592, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100a_c595, 5); calld(0x1008_8b44, -0x2_3a56);          /* call 0x10088b44 */
            ii(0x100a_c59a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c59d, 6); mov(memw_a32[ds, eax + 0x28], 0xffff);  /* mov word [eax+0x28], 0xffff */
            ii(0x100a_c5a3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c5a6, 6); mov(memw_a32[ds, eax + 0x2a], 0xffff);  /* mov word [eax+0x2a], 0xffff */
            ii(0x100a_c5ac, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_c5af, 5); calld(0x1007_611c, -0x3_6498);          /* call 0x1007611c */
            ii(0x100a_c5b4, 4); mov(dx, memw_a32[ds, eax + 0x8]);       /* mov dx, [eax+0x8] */
            ii(0x100a_c5b8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c5bb, 4); mov(memw_a32[ds, eax + 0x26], dx);      /* mov [eax+0x26], dx */
            ii(0x100a_c5bf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_c5c2, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_c5c5, 3); mov(memd_a32[ds, edx + 0x40], eax);     /* mov [edx+0x40], eax */
            ii(0x100a_c5c8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c5cb, 4); mov(memb_a32[ds, eax + 0x44], 0);       /* mov byte [eax+0x44], 0x0 */
            ii(0x100a_c5cf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c5d2, 4); mov(memb_a32[ds, eax + 0x46], 0);       /* mov byte [eax+0x46], 0x0 */
            ii(0x100a_c5d6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_c5d9, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100a_c5dc, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100a_c5df, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_c5e1, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_c5e2, 1); popd(edi);                              /* pop edi */
            ii(0x100a_c5e3, 1); popd(esi);                              /* pop esi */
            ii(0x100a_c5e4, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_c5e5, 1); retd(); return;                         /* ret */
        }
    }
}
