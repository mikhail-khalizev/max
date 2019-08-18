using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_4525-30889841")]
        public void Method_100b_4525()
        {
            ii(0x100b_4525, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_452a, 5); calld(Definitions.sys_check_available_stack_size, 0xb_1823); /* call 0x10165d52 */
            ii(0x100b_452f, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_4530, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_4531, 1); pushd(esi);                             /* push esi */
            ii(0x100b_4532, 1); pushd(edi);                             /* push edi */
            ii(0x100b_4533, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_4534, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_4536, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_453c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_453f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_4542, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_4544, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_4547, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_454a, 5); calld(0x1013_ad11, 0x8_67c2);           /* call 0x1013ad11 */
            ii(0x100b_454f, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4551, 2); if(jnzd(0x100b_4564, 0x11)) goto l_0x100b_4564; /* jnz 0x100b4564 */
            ii(0x100b_4553, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_4555, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_4558, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_455b, 5); calld(0x1013_ad11, 0x8_67b1);           /* call 0x1013ad11 */
            ii(0x100b_4560, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4562, 2); if(jzd(0x100b_4573, 0xf)) goto l_0x100b_4573; /* jz 0x100b4573 */
        l_0x100b_4564:
            ii(0x100b_4564, 5); mov(edx, StringDefinitions.CompletedRendezvousTask); /* mov edx, 0x101a10ef */
            ii(0x100b_4569, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_456c, 5); calld(Definitions.sys_strcpy, 0xb_195e); /* call 0x10165ecf */
            ii(0x100b_4571, 2); jmpd(0x100b_45de, 0x6b); goto l_0x100b_45de; /* jmp 0x100b45de */
        l_0x100b_4573:
            ii(0x100b_4573, 5); mov(edx, StringDefinitions.Bring);      /* mov edx, 0x101a110a */
            ii(0x100b_4578, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_457b, 5); calld(Definitions.sys_strcpy, 0xb_194f); /* call 0x10165ecf */
            ii(0x100b_4580, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_4583, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4586, 5); calld(0x1007_6574, -0x3_e017);          /* call 0x10076574 */
            ii(0x100b_458b, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100b_458e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_4591, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100b_4594, 6); mov(edx, memd_a32[ds, eax + 0x101c_81d7]); /* mov edx, [eax+0x101c81d7] */
            ii(0x100b_459a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_459d, 5); calld(Definitions.sys_strcat, 0xb_198f); /* call 0x10165f31 */
            ii(0x100b_45a2, 5); mov(edx, StringDefinitions.And2);       /* mov edx, 0x101a1111 */
            ii(0x100b_45a7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_45aa, 5); calld(Definitions.sys_strcat, 0xb_1982); /* call 0x10165f31 */
            ii(0x100b_45af, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_45b2, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_45b5, 5); calld(0x1007_6574, -0x3_e046);          /* call 0x10076574 */
            ii(0x100b_45ba, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100b_45bd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_45c0, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100b_45c3, 6); mov(edx, memd_a32[ds, eax + 0x101c_81d7]); /* mov edx, [eax+0x101c81d7] */
            ii(0x100b_45c9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_45cc, 5); calld(Definitions.sys_strcat, 0xb_1960); /* call 0x10165f31 */
            ii(0x100b_45d1, 5); mov(edx, StringDefinitions.Together);   /* mov edx, 0x101a1117 */
            ii(0x100b_45d6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_45d9, 5); calld(Definitions.sys_strcat, 0xb_1953); /* call 0x10165f31 */
        l_0x100b_45de:
            ii(0x100b_45de, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_45e1, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_45e4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_45e7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_45e9, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_45ea, 1); popd(edi);                              /* pop edi */
            ii(0x100b_45eb, 1); popd(esi);                              /* pop esi */
            ii(0x100b_45ec, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_45ed, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_45ee, 1); retd(); return;                         /* ret */
        }
    }
}
