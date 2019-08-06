using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7974d375-227a-4445-827d-b340b5deb34c")]
        public void Method_1010_6615()
        {
            ii(0x1010_6615, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1010_661a, 5); calld(Definitions.sys_check_available_stack_size, 0x5f733); /* call 0x10165d52 */
            ii(0x1010_661f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_6620, 1); pushd(esi);                             /* push esi */
            ii(0x1010_6621, 1); pushd(edi);                             /* push edi */
            ii(0x1010_6622, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_6623, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6625, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1010_662b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_662e, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1010_6631, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1010_6634, 2); pushd(0x14);                            /* push 0x14 */
            ii(0x1010_6636, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_6639, 5); add(eax, 0xac);                         /* add eax, 0xac */
            ii(0x1010_663e, 1); pushd(eax);                             /* push eax */
            ii(0x1010_663f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_6642, 1); pushd(eax);                             /* push eax */
            ii(0x1010_6643, 5); calld(0x1012_3b6c, 0x1d524);            /* call 0x10123b6c */
            ii(0x1010_6648, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1010_664b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_664d, 6); if(jzd(0x1010_6704, 0xb1)) goto l_0x1010_6704; /* jz 0x10106704 */
            ii(0x1010_6653, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_6656, 5); add(eax, 0xac);                         /* add eax, 0xac */
            ii(0x1010_665b, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_665e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_6661, 5); add(eax, 0xac);                         /* add eax, 0xac */
            ii(0x1010_6666, 5); calld(Definitions.sys_strlen, 0x6b85c); /* call 0x10171ec7 */
            ii(0x1010_666b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_666d, 2); if(jnzd(0x1010_667b, 0xc)) goto l_0x1010_667b; /* jnz 0x1010667b */
            ii(0x1010_666f, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1010_6676, 5); jmpd(0x1010_670b, 0x90); goto l_0x1010_670b; /* jmp 0x1010670b */
        l_0x1010_667b:
            ii(0x1010_667b, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_667e, 5); calld(/* sys */ 0x1017_90ce, 0x72a4b);  /* call 0x101790ce */
            ii(0x1010_6683, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_6685, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_6688, 3); mov(memw_a32[ds, eax], dx);             /* mov [eax], dx */
        l_0x1010_668b:
            ii(0x1010_668b, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_668e, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
            ii(0x1010_6691, 3); cmp(memb_a32[ds, eax], 0x20);           /* cmp byte [eax], 0x20 */
            ii(0x1010_6694, 2); if(jnzd(0x1010_668b, -0xb)) goto l_0x1010_668b; /* jnz 0x1010668b */
            ii(0x1010_6696, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_6699, 5); mov(memw_a32[ds, eax], 0);              /* mov word [eax], 0x0 */
        l_0x1010_669e:
            ii(0x1010_669e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_66a1, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1010_66a4, 3); cmp(eax, 0xd);                          /* cmp eax, 0xd */
            ii(0x1010_66a7, 2); if(jzd(0x1010_66c4, 0x1b)) goto l_0x1010_66c4; /* jz 0x101066c4 */
            ii(0x1010_66a9, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1010_66ac, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_66af, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1010_66b2, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1010_66b5, 6); mov(eax, memd_a32[ds, eax + 0x101b_8fa8]); /* mov eax, [eax+0x101b8fa8] */
            ii(0x1010_66bb, 5); calld(Definitions.sys_strcasecmp, 0x5fa70); /* call 0x10166130 */
            ii(0x1010_66c0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_66c2, 2); if(jnzd(0x1010_66c6, 0x2)) goto l_0x1010_66c6; /* jnz 0x101066c6 */
        l_0x1010_66c4:
            ii(0x1010_66c4, 2); jmpd(0x1010_66ce, 0x8); goto l_0x1010_66ce; /* jmp 0x101066ce */
        l_0x1010_66c6:
            ii(0x1010_66c6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_66c9, 3); inc(memw_a32[ds, eax]);                 /* inc word [eax] */
            ii(0x1010_66cc, 2); jmpd(0x1010_669e, -0x30); goto l_0x1010_669e; /* jmp 0x1010669e */
        l_0x1010_66ce:
            ii(0x1010_66ce, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_66d1, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1010_66d4, 3); cmp(eax, 0xd);                          /* cmp eax, 0xd */
            ii(0x1010_66d7, 2); if(jaed(0x1010_66e2, 0x9)) goto l_0x1010_66e2; /* jae 0x101066e2 */
            ii(0x1010_66d9, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1010_66e0, 2); jmpd(0x1010_66fb, 0x19); goto l_0x1010_66fb; /* jmp 0x101066fb */
        l_0x1010_66e2:
            ii(0x1010_66e2, 5); mov(ecx, 0x23c);                        /* mov ecx, 0x23c */
            ii(0x1010_66e7, 5); mov(ebx, StringDefinitions.InifileCpp); /* mov ebx, 0x101a3af2 */
            ii(0x1010_66ec, 5); mov(edx, StringDefinitions.EntryNameLen); /* mov edx, 0x101a3afe */
            ii(0x1010_66f1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_66f3, 5); calld(Definitions.sys_assert, 0x5f69a); /* call 0x10165d92 */
            ii(0x1010_66f8, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1010_66fb:
            ii(0x1010_66fb, 7); mov(memd_a32[ss, ebp - 0x10], 0x1);     /* mov dword [ebp-0x10], 0x1 */
            ii(0x1010_6702, 2); jmpd(0x1010_670b, 0x7); goto l_0x1010_670b; /* jmp 0x1010670b */
        l_0x1010_6704:
            ii(0x1010_6704, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x1010_670b:
            ii(0x1010_670b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_670e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_6710, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_6711, 1); popd(edi);                              /* pop edi */
            ii(0x1010_6712, 1); popd(esi);                              /* pop esi */
            ii(0x1010_6713, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_6714, 1); retd(); return;                         /* ret */
        }
    }
}
