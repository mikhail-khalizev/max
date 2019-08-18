using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_b516-d2bce3eb")]
        public void Method_1007_b516()
        {
            ii(0x1007_b516, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1007_b51b, 5); calld(Definitions.sys_check_available_stack_size, 0xe_a832); /* call 0x10165d52 */
            ii(0x1007_b520, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_b521, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_b522, 1); pushd(esi);                             /* push esi */
            ii(0x1007_b523, 1); pushd(edi);                             /* push edi */
            ii(0x1007_b524, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_b525, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_b527, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1007_b52d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_b530, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_b533, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_b535, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_b538, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_b53b, 5); calld(0x1013_ad11, 0xb_f7d1);           /* call 0x1013ad11 */
            ii(0x1007_b540, 2); test(al, al);                           /* test al, al */
            ii(0x1007_b542, 2); if(jzd(0x1007_b55f, 0x1b)) goto l_0x1007_b55f; /* jz 0x1007b55f */
            ii(0x1007_b544, 5); calld(0x1008_a79c, 0xf253);             /* call 0x1008a79c */
            ii(0x1007_b549, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_b54b, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1007_b54d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_b550, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_b555, 5); calld(0x100a_53ac, 0x2_9e52);           /* call 0x100a53ac */
            ii(0x1007_b55a, 5); jmpd(0x1007_b630, 0xd1); goto l_0x1007_b630; /* jmp 0x1007b630 */
        l_0x1007_b55f:
            ii(0x1007_b55f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_b562, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_b565, 5); calld(0x1008_a228, 0xecbe);             /* call 0x1008a228 */
            ii(0x1007_b56a, 5); calld(0x1008_a370, 0xee01);             /* call 0x1008a370 */
            ii(0x1007_b56f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_b571, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b574, 5); calld(0x1007_af7a, -0x5ff);             /* call 0x1007af7a */
            ii(0x1007_b579, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_b57b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_b57e, 4); add(memw_a32[ds, eax + 0x25], dx);      /* add [eax+0x25], dx */
            ii(0x1007_b582, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_b585, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b588, 5); calld(0x1015_27ed, 0xd_7260);           /* call 0x101527ed */
            ii(0x1007_b58d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_b590, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_b593, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1007_b596, 5); calld(0x1008_ab1c, 0xf581);             /* call 0x1008ab1c */
            ii(0x1007_b59b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b59e, 6); mov(memw_a32[ds, eax + 0x1e], 0);       /* mov word [eax+0x1e], 0x0 */
            ii(0x1007_b5a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_b5a7, 6); mov(memw_a32[ds, eax + 0x20], 0);       /* mov word [eax+0x20], 0x0 */
            ii(0x1007_b5ad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_b5af, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_b5b2, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1007_b5b5, 5); calld(0x1013_ad71, 0xb_f7b7);           /* call 0x1013ad71 */
            ii(0x1007_b5ba, 2); test(al, al);                           /* test al, al */
            ii(0x1007_b5bc, 2); if(jzd(0x1007_b5d2, 0x14)) goto l_0x1007_b5d2; /* jz 0x1007b5d2 */
            ii(0x1007_b5be, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_b5c1, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1007_b5c4, 5); calld(0x1008_af28, 0xf95f);             /* call 0x1008af28 */
            ii(0x1007_b5c9, 5); calld(0x1008_ad28, 0xf75a);             /* call 0x1008ad28 */
            ii(0x1007_b5ce, 2); test(al, al);                           /* test al, al */
            ii(0x1007_b5d0, 2); if(jzd(0x1007_b5d4, 0x2)) goto l_0x1007_b5d4; /* jz 0x1007b5d4 */
        l_0x1007_b5d2:
            ii(0x1007_b5d2, 2); jmpd(0x1007_b630, 0x5c); goto l_0x1007_b630; /* jmp 0x1007b630 */
        l_0x1007_b5d4:
            ii(0x1007_b5d4, 5); calld(0x1008_a7bc, 0xf1e3);             /* call 0x1008a7bc */
            ii(0x1007_b5d9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_b5de, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_b5e1, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1007_b5e6, 5); calld(Definitions.sys_new, 0xe_a815);   /* call 0x10165e00 */
            ii(0x1007_b5eb, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_b5ee, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_b5f1, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_b5f4, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1007_b5f8, 2); if(jzd(0x1007_b61a, 0x20)) goto l_0x1007_b61a; /* jz 0x1007b61a */
            ii(0x1007_b5fa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_b5fd, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1007_b600, 5); calld(0x1008_af84, 0xf97f);             /* call 0x1008af84 */
            ii(0x1007_b605, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_b607, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_b60a, 5); calld(Definitions.my_ctor_c11, 0x2_82ba); /* call 0x100a38c9 */
            ii(0x1007_b60f, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1007_b612, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1007_b615, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1007_b618, 2); jmpd(0x1007_b620, 0x6); goto l_0x1007_b620; /* jmp 0x1007b620 */
        l_0x1007_b61a:
            ii(0x1007_b61a, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1007_b61d, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1007_b620:
            ii(0x1007_b620, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x1007_b623, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_b628, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1007_b62b, 5); calld(0x100a_4db6, 0x2_9786);           /* call 0x100a4db6 */
        l_0x1007_b630:
            ii(0x1007_b630, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_b632, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_b633, 1); popd(edi);                              /* pop edi */
            ii(0x1007_b634, 1); popd(esi);                              /* pop esi */
            ii(0x1007_b635, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_b636, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_b637, 1); retd(); return;                         /* ret */
        }
    }
}
