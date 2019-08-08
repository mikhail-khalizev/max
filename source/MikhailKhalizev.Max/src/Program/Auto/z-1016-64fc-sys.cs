using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("469c8485-239d-4de3-9195-098e5aeaceb9")]
        public void /* sys */ Method_1016_64fc()
        {
            ii(0x1016_64fc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_64fd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_64fe, 1); pushd(edx);                             /* push edx */
            ii(0x1016_64ff, 1); pushd(esi);                             /* push esi */
            ii(0x1016_6500, 1); pushd(edi);                             /* push edi */
            ii(0x1016_6501, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_6502, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_6505, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1016_6508, 6); mov(edx, memd_a32[ds, 0x101b_ddbc]);    /* mov edx, [0x101bddbc] */
            ii(0x1016_650e, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1016_6510, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_6512, 2); if(jnzd(0x1016_651e, 0xa)) goto l_0x1016_651e; /* jnz 0x1016651e */
            ii(0x1016_6514, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1016_6519, 5); jmpd(0x1016_669b, 0x17d); goto l_0x1016_669b; /* jmp 0x1016669b */
        l_0x1016_651e:
            ii(0x1016_651e, 3); calld_abs(memd_a32[ss, esp]);           /* call dword [esp] */
            ii(0x1016_6521, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_6524, 2); if(jnzd(0x1016_6535, 0xf)) goto l_0x1016_6535; /* jnz 0x10166535 */
            ii(0x1016_6526, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1016_652b, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_652e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_652f, 1); popd(edi);                              /* pop edi */
            ii(0x1016_6530, 1); popd(esi);                              /* pop esi */
            ii(0x1016_6531, 1); popd(edx);                              /* pop edx */
            ii(0x1016_6532, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_6533, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_6534, 1); retd(); return;                         /* ret */
        l_0x1016_6535:
            ii(0x1016_6535, 5); mov(eax, memd_a32[ds, 0x1020_88e8]);    /* mov eax, [0x102088e8] */
            ii(0x1016_653a, 6); sub(eax, memd_a32[ds, 0x1020_88e0]);    /* sub eax, [0x102088e0] */
            ii(0x1016_6540, 3); lea(esi, eax + 0x1);                    /* lea esi, [eax+0x1] */
            ii(0x1016_6543, 6); mov(ecx, memd_a32[ds, 0x1020_88e4]);    /* mov ecx, [0x102088e4] */
            ii(0x1016_6549, 5); mov(eax, memd_a32[ds, 0x1020_88ec]);    /* mov eax, [0x102088ec] */
            ii(0x1016_654e, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_6550, 6); mov(ebp, memd_a32[ds, 0x101c_b2d8]);    /* mov ebp, [0x101cb2d8] */
            ii(0x1016_6556, 3); lea(ebx, eax + 0x1);                    /* lea ebx, [eax+0x1] */
            ii(0x1016_6559, 3); cmp(ebp, 0x1);                          /* cmp ebp, 0x1 */
            ii(0x1016_655c, 2); if(jled(0x1016_6588, 0x2a)) goto l_0x1016_6588; /* jle 0x10166588 */
            ii(0x1016_655e, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1016_6563, 7); lea(edx, ebp * 4 + 0);                  /* lea edx, [ebp*4] */
        l_0x1016_656a:
            ii(0x1016_656a, 6); mov(ecx, memd_a32[ds, eax + 0x101c_b1fc]); /* mov ecx, [eax+0x101cb1fc] */
            ii(0x1016_6570, 3); cmp(esi, memd_a32[ds, ecx + 0x18]);     /* cmp esi, [ecx+0x18] */
            ii(0x1016_6573, 2); if(jld(0x1016_657a, 0x5)) goto l_0x1016_657a; /* jl 0x1016657a */
            ii(0x1016_6575, 3); cmp(ebx, memd_a32[ds, ecx + 0x1c]);     /* cmp ebx, [ecx+0x1c] */
            ii(0x1016_6578, 2); if(jged(0x1016_6581, 0x7)) goto l_0x1016_6581; /* jge 0x10166581 */
        l_0x1016_657a:
            ii(0x1016_657a, 5); mov(edi, 0x6);                          /* mov edi, 0x6 */
            ii(0x1016_657f, 2); jmpd(0x1016_6588, 0x7); goto l_0x1016_6588; /* jmp 0x10166588 */
        l_0x1016_6581:
            ii(0x1016_6581, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1016_6584, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1016_6586, 2); if(jld(0x1016_656a, -0x1e)) goto l_0x1016_656a; /* jl 0x1016656a */
        l_0x1016_6588:
            ii(0x1016_6588, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1016_658a, 2); if(jnzd(0x1016_65d6, 0x4a)) goto l_0x1016_65d6; /* jnz 0x101665d6 */
            ii(0x1016_658c, 7); test(memb_a32[ds, 0x101c_b2dc], 0x1);   /* test byte [0x101cb2dc], 0x1 */
            ii(0x1016_6593, 2); if(jzd(0x1016_65d6, 0x41)) goto l_0x1016_65d6; /* jz 0x101665d6 */
            ii(0x1016_6595, 5); mov(eax, memd_a32[ds, 0x1020_88ec]);    /* mov eax, [0x102088ec] */
            ii(0x1016_659a, 6); sub(eax, memd_a32[ds, 0x1020_88e4]);    /* sub eax, [0x102088e4] */
            ii(0x1016_65a0, 6); mov(ebx, memd_a32[ds, 0x1020_88e0]);    /* mov ebx, [0x102088e0] */
            ii(0x1016_65a6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_65a8, 5); mov(eax, memd_a32[ds, 0x1020_88e8]);    /* mov eax, [0x102088e8] */
            ii(0x1016_65ad, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1016_65af, 1); inc(edx);                               /* inc edx */
            ii(0x1016_65b0, 1); inc(eax);                               /* inc eax */
            ii(0x1016_65b1, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1016_65b4, 5); calld(Definitions.sys_malloc_internal, 0x1_bd37); /* call 0x101822f0 */
            ii(0x1016_65b9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_65bb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_65bd, 2); if(jnzd(0x1016_65c6, 0x7)) goto l_0x1016_65c6; /* jnz 0x101665c6 */
            ii(0x1016_65bf, 5); mov(edi, 0x2);                          /* mov edi, 0x2 */
            ii(0x1016_65c4, 2); jmpd(0x1016_65d6, 0x10); goto l_0x1016_65d6; /* jmp 0x101665d6 */
        l_0x1016_65c6:
            ii(0x1016_65c6, 5); mov(eax, memd_a32[ds, 0x101b_ddd8]);    /* mov eax, [0x101bddd8] */
            ii(0x1016_65cb, 5); calld(Definitions.sys_free_internal, 0x1_be84); /* call 0x10182454 */
            ii(0x1016_65d0, 6); mov(memd_a32[ds, 0x101b_ddd8], edx);    /* mov [0x101bddd8], edx */
        l_0x1016_65d6:
            ii(0x1016_65d6, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1016_65d8, 2); if(jzd(0x1016_65e2, 0x8)) goto l_0x1016_65e2; /* jz 0x101665e2 */
            ii(0x1016_65da, 6); calld_abs(memd_a32[ds, 0x101c_b2cc]);   /* call dword [0x101cb2cc] */
            ii(0x1016_65e0, 2); jmpd(0x1016_65ea, 0x8); goto l_0x1016_65ea; /* jmp 0x101665ea */
        l_0x1016_65e2:
            ii(0x1016_65e2, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1016_65e5, 5); mov(memd_a32[ds, 0x101c_b2cc], eax);    /* mov [0x101cb2cc], eax */
        l_0x1016_65ea:
            ii(0x1016_65ea, 5); calld(/* sys */ 0x1016_cc1c, 0x662d);   /* call 0x1016cc1c */
            ii(0x1016_65ef, 5); calld(Definitions.sys_display_apply_palette, 0x65c8); /* call 0x1016cbbc */
            ii(0x1016_65f4, 6); mov(edx, memd_a32[ds, 0x101c_b1fc]);    /* mov edx, [0x101cb1fc] */
            ii(0x1016_65fa, 5); mov(eax, memd_a32[ds, 0x1020_88e0]);    /* mov eax, [0x102088e0] */
            ii(0x1016_65ff, 3); mov(memd_a32[ds, edx + 0x8], eax);      /* mov [edx+0x8], eax */
            ii(0x1016_6602, 5); mov(eax, memd_a32[ds, 0x1020_88e4]);    /* mov eax, [0x102088e4] */
            ii(0x1016_6607, 3); mov(memd_a32[ds, edx + 0xc], eax);      /* mov [edx+0xc], eax */
            ii(0x1016_660a, 5); mov(eax, memd_a32[ds, 0x1020_88e8]);    /* mov eax, [0x102088e8] */
            ii(0x1016_660f, 3); mov(memd_a32[ds, edx + 0x10], eax);     /* mov [edx+0x10], eax */
            ii(0x1016_6612, 5); mov(eax, memd_a32[ds, 0x1020_88ec]);    /* mov eax, [0x102088ec] */
            ii(0x1016_6617, 6); mov(ecx, memd_a32[ds, 0x1020_88e0]);    /* mov ecx, [0x102088e0] */
            ii(0x1016_661d, 3); mov(memd_a32[ds, edx + 0x14], eax);     /* mov [edx+0x14], eax */
            ii(0x1016_6620, 6); mov(edx, memd_a32[ds, 0x1020_88e8]);    /* mov edx, [0x102088e8] */
            ii(0x1016_6626, 2); sub(edx, ecx);                          /* sub edx, ecx */
            ii(0x1016_6628, 5); mov(eax, memd_a32[ds, 0x101c_b1fc]);    /* mov eax, [0x101cb1fc] */
            ii(0x1016_662d, 1); inc(edx);                               /* inc edx */
            ii(0x1016_662e, 6); mov(esi, memd_a32[ds, 0x1020_88e4]);    /* mov esi, [0x102088e4] */
            ii(0x1016_6634, 3); mov(memd_a32[ds, eax + 0x18], edx);     /* mov [eax+0x18], edx */
            ii(0x1016_6637, 5); mov(eax, memd_a32[ds, 0x1020_88ec]);    /* mov eax, [0x102088ec] */
            ii(0x1016_663c, 2); sub(eax, esi);                          /* sub eax, esi */
            ii(0x1016_663e, 6); mov(edx, memd_a32[ds, 0x101c_b1fc]);    /* mov edx, [0x101cb1fc] */
            ii(0x1016_6644, 1); inc(eax);                               /* inc eax */
            ii(0x1016_6645, 3); mov(memd_a32[ds, edx + 0x1c], eax);     /* mov [edx+0x1c], eax */
            ii(0x1016_6648, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_664a, 5); calld(/* sys */ 0x1016_7dac, 0x175d);   /* call 0x10167dac */
            ii(0x1016_664f, 7); cmp(memd_a32[ds, 0x101b_ddbc], 0);      /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_6656, 2); if(jzd(0x1016_6666, 0xe)) goto l_0x1016_6666; /* jz 0x10166666 */
            ii(0x1016_6658, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_665a, 2); if(jzd(0x1016_6666, 0xa)) goto l_0x1016_6666; /* jz 0x10166666 */
            ii(0x1016_665c, 3); lea(edx, eax + 0x8);                    /* lea edx, [eax+0x8] */
            ii(0x1016_665f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_6661, 5); calld(/* sys */ 0x1016_7500, 0xe9a);    /* call 0x10167500 */
        l_0x1016_6666:
            ii(0x1016_6666, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_666b, 6); cmp(ecx, memd_a32[ds, 0x101c_b2d8]);    /* cmp ecx, [0x101cb2d8] */
            ii(0x1016_6671, 2); if(jged(0x1016_6699, 0x26)) goto l_0x1016_6699; /* jge 0x10166699 */
            ii(0x1016_6673, 5); mov(esi, 0x4);                          /* mov esi, 0x4 */
        l_0x1016_6678:
            ii(0x1016_6678, 6); mov(eax, memd_a32[ds, esi + 0x101c_b1fc]); /* mov eax, [esi+0x101cb1fc] */
            ii(0x1016_667e, 3); mov(ebx, memd_a32[ds, eax + 0xc]);      /* mov ebx, [eax+0xc] */
            ii(0x1016_6681, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x1016_6684, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1016_6686, 1); inc(ecx);                               /* inc ecx */
            ii(0x1016_6687, 5); calld(/* sys */ 0x1016_73c8, 0xd3c);    /* call 0x101673c8 */
            ii(0x1016_668c, 6); mov(edx, memd_a32[ds, 0x101c_b2d8]);    /* mov edx, [0x101cb2d8] */
            ii(0x1016_6692, 3); add(esi, 0x4);                          /* add esi, 0x4 */
            ii(0x1016_6695, 2); cmp(ecx, edx);                          /* cmp ecx, edx */
            ii(0x1016_6697, 2); if(jld(0x1016_6678, -0x21)) goto l_0x1016_6678; /* jl 0x10166678 */
        l_0x1016_6699:
            ii(0x1016_6699, 2); mov(eax, edi);                          /* mov eax, edi */
        l_0x1016_669b:
            ii(0x1016_669b, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_669e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_669f, 1); popd(edi);                              /* pop edi */
            ii(0x1016_66a0, 1); popd(esi);                              /* pop esi */
            ii(0x1016_66a1, 1); popd(edx);                              /* pop edx */
            ii(0x1016_66a2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_66a3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_66a4, 1); retd(); return;                         /* ret */
        }
    }
}
