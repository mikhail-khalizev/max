using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5608a688-4286-4ae8-8176-19a6171a17d8")]
        public void Method_100d_77e8()
        {
            ii(0x100d_77e8, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100d_77ed, 5); calld(Definitions.sys_check_available_stack_size, 0x8_e560); /* call 0x10165d52 */
            ii(0x100d_77f2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_77f3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_77f4, 1); pushd(esi);                             /* push esi */
            ii(0x100d_77f5, 1); pushd(edi);                             /* push edi */
            ii(0x100d_77f6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_77f7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_77f9, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100d_77ff, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_7802, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_7805, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_7808, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_780b, 3); cmp(eax, memd_a32[ds, edx + 0x10]);     /* cmp eax, [edx+0x10] */
            ii(0x100d_780e, 2); if(jnzd(0x100d_7820, 0x10)) goto l_0x100d_7820; /* jnz 0x100d7820 */
            ii(0x100d_7810, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7813, 4); mov(dx, memw_a32[ds, eax + 0x4]);       /* mov dx, [eax+0x4] */
            ii(0x100d_7817, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_781a, 4); cmp(dx, memw_a32[ds, eax + 0x2b]);      /* cmp dx, [eax+0x2b] */
            ii(0x100d_781e, 2); if(jged(0x100d_7822, 0x2)) goto l_0x100d_7822; /* jge 0x100d7822 */
        l_0x100d_7820:
            ii(0x100d_7820, 2); jmpd(0x100d_782b, 0x9); goto l_0x100d_782b; /* jmp 0x100d782b */
        l_0x100d_7822:
            ii(0x100d_7822, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100d_7826, 5); jmpd(0x100d_79b9, 0x18e); goto l_0x100d_79b9; /* jmp 0x100d79b9 */
        l_0x100d_782b:
            ii(0x100d_782b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_782e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_7831, 3); cmp(eax, memd_a32[ds, edx + 0x14]);     /* cmp eax, [edx+0x14] */
            ii(0x100d_7834, 2); if(jnzd(0x100d_7846, 0x10)) goto l_0x100d_7846; /* jnz 0x100d7846 */
            ii(0x100d_7836, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7839, 4); mov(dx, memw_a32[ds, eax + 0x4]);       /* mov dx, [eax+0x4] */
            ii(0x100d_783d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7840, 4); cmp(dx, memw_a32[ds, eax + 0x2d]);      /* cmp dx, [eax+0x2d] */
            ii(0x100d_7844, 2); if(jled(0x100d_7848, 0x2)) goto l_0x100d_7848; /* jle 0x100d7848 */
        l_0x100d_7846:
            ii(0x100d_7846, 2); jmpd(0x100d_7851, 0x9); goto l_0x100d_7851; /* jmp 0x100d7851 */
        l_0x100d_7848:
            ii(0x100d_7848, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100d_784c, 5); jmpd(0x100d_79b9, 0x168); goto l_0x100d_79b9; /* jmp 0x100d79b9 */
        l_0x100d_7851:
            ii(0x100d_7851, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_7854, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_7857, 3); cmp(eax, memd_a32[ds, edx + 0x18]);     /* cmp eax, [edx+0x18] */
            ii(0x100d_785a, 6); if(jnzd(0x100d_79ab, 0x14b)) goto l_0x100d_79ab; /* jnz 0x100d79ab */
            ii(0x100d_7860, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x100d_7863, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100d_7866, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7869, 3); mov(eax, memd_a32[ds, eax + 0x20]);     /* mov eax, [eax+0x20] */
            ii(0x100d_786c, 5); calld(0x100d_6a92, -0xddf);             /* call 0x100d6a92 */
            ii(0x100d_7871, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7874, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100d_7877, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_787a, 4); sub(ax, memw_a32[ds, edx + 0x2]);       /* sub ax, [edx+0x2] */
            ii(0x100d_787e, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100d_7881, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7884, 4); cmp(memb_a32[ds, eax + 0x26], 0);       /* cmp byte [eax+0x26], 0x0 */
            ii(0x100d_7888, 2); if(jzd(0x100d_78f3, 0x69)) goto l_0x100d_78f3; /* jz 0x100d78f3 */
            ii(0x100d_788a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_788d, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_7890, 5); calld(0x100d_4ebc, -0x29d9);            /* call 0x100d4ebc */
            ii(0x100d_7895, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_7898, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_789b, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_789e, 5); calld(0x100d_4f24, -0x297f);            /* call 0x100d4f24 */
            ii(0x100d_78a3, 1); cwde();                                 /* cwde */
            ii(0x100d_78a4, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_78a6, 3); sub(eax, memd_a32[ss, ebp - 0x10]);     /* sub eax, [ebp-0x10] */
            ii(0x100d_78a9, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_78ac, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_78af, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_78b2, 5); calld(0x100d_4f24, -0x2993);            /* call 0x100d4f24 */
            ii(0x100d_78b7, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_78ba, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_78bc, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_78bf, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100d_78c1, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100d_78c3, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100d_78c7, 4); imul(edx, memd_a32[ss, ebp - 0x10]);    /* imul edx, [ebp-0x10] */
            ii(0x100d_78cb, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_78cd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_78d0, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_78d3, 5); calld(0x100d_4f24, -0x29b4);            /* call 0x100d4f24 */
            ii(0x100d_78d8, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_78db, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_78dd, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_78e0, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100d_78e2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_78e4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_78e7, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100d_78e9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_78ec, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_78ee, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_78f1, 2); jmpd(0x100d_7947, 0x54); goto l_0x100d_7947; /* jmp 0x100d7947 */
        l_0x100d_78f3:
            ii(0x100d_78f3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_78f6, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_78f9, 5); calld(0x100d_4ef0, -0x2a0e);            /* call 0x100d4ef0 */
            ii(0x100d_78fe, 1); cwde();                                 /* cwde */
            ii(0x100d_78ff, 3); sub(memd_a32[ss, ebp - 0x14], eax);     /* sub [ebp-0x14], eax */
            ii(0x100d_7902, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_7905, 3); mov(eax, memd_a32[ds, edx + 0x6]);      /* mov eax, [edx+0x6] */
            ii(0x100d_7908, 5); calld(0x100d_4f58, -0x29b5);            /* call 0x100d4f58 */
            ii(0x100d_790d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_7910, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_7912, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_7915, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100d_7917, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100d_7919, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100d_791d, 4); imul(edx, memd_a32[ss, ebp - 0x14]);    /* imul edx, [ebp-0x14] */
            ii(0x100d_7921, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_7923, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7926, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_7929, 5); calld(0x100d_4f58, -0x29d6);            /* call 0x100d4f58 */
            ii(0x100d_792e, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_7931, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_7933, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_7936, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100d_7938, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_793a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_793d, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100d_793f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_7942, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_7944, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x100d_7947:
            ii(0x100d_7947, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_794a, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x100d_794c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_794f, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100d_7953, 5); calld(0x1007_6e7c, -0x6_0adc);          /* call 0x10076e7c */
            ii(0x100d_7958, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_795b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_795e, 3); movsx(edx, memw_a32[ds, edx]);          /* movsx edx, word [edx] */
            ii(0x100d_7961, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100d_7965, 5); calld(Definitions.my_min, -0x4_e1e6);   /* call 0x10089784 */
            ii(0x100d_796a, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_796d, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_7970, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_7973, 4); cmp(ax, memw_a32[ds, edx + 0x2b]);      /* cmp ax, [edx+0x2b] */
            ii(0x100d_7977, 2); if(jled(0x100d_7983, 0xa)) goto l_0x100d_7983; /* jle 0x100d7983 */
            ii(0x100d_7979, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_797c, 4); mov(ax, memw_a32[ds, eax + 0x2b]);      /* mov ax, [eax+0x2b] */
            ii(0x100d_7980, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x100d_7983:
            ii(0x100d_7983, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_7986, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_7989, 4); cmp(ax, memw_a32[ds, edx + 0x2d]);      /* cmp ax, [edx+0x2d] */
            ii(0x100d_798d, 2); if(jged(0x100d_7999, 0xa)) goto l_0x100d_7999; /* jge 0x100d7999 */
            ii(0x100d_798f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_7992, 4); mov(ax, memw_a32[ds, eax + 0x2d]);      /* mov ax, [eax+0x2d] */
            ii(0x100d_7996, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x100d_7999:
            ii(0x100d_7999, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100d_799d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_79a0, 5); calld(0x100d_7431, -0x574);             /* call 0x100d7431 */
            ii(0x100d_79a5, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100d_79a9, 2); jmpd(0x100d_79b9, 0xe); goto l_0x100d_79b9; /* jmp 0x100d79b9 */
        l_0x100d_79ab:
            ii(0x100d_79ab, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_79ae, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_79b1, 5); calld(0x100d_74bb, -0x4fb);             /* call 0x100d74bb */
            ii(0x100d_79b6, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
        l_0x100d_79b9:
            ii(0x100d_79b9, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100d_79bc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_79be, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_79bf, 1); popd(edi);                              /* pop edi */
            ii(0x100d_79c0, 1); popd(esi);                              /* pop esi */
            ii(0x100d_79c1, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_79c2, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_79c3, 1); retd(); return;                         /* ret */
        }
    }
}
