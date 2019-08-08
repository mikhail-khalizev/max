using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("89d1473f-4856-41fb-970b-6c4935fd376f")]
        public void Method_100b_e436()
        {
            ii(0x100b_e436, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_e43b, 5); calld(Definitions.sys_check_available_stack_size, 0xa_7912); /* call 0x10165d52 */
            ii(0x100b_e440, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_e441, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_e442, 1); pushd(edx);                             /* push edx */
            ii(0x100b_e443, 1); pushd(esi);                             /* push esi */
            ii(0x100b_e444, 1); pushd(edi);                             /* push edi */
            ii(0x100b_e445, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_e446, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_e448, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_e44e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_e451, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e454, 4); cmp(memb_a32[ds, eax + 0xe], 0);        /* cmp byte [eax+0xe], 0x0 */
            ii(0x100b_e458, 2); if(jzd(0x100b_e46b, 0x11)) goto l_0x100b_e46b; /* jz 0x100be46b */
            ii(0x100b_e45a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e45d, 5); calld(0x100b_b2ef, -0x3173);            /* call 0x100bb2ef */
            ii(0x100b_e462, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100b_e466, 5); jmpd(0x100b_e5b6, 0x14b); goto l_0x100b_e5b6; /* jmp 0x100be5b6 */
        l_0x100b_e46b:
            ii(0x100b_e46b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e46e, 4); cmp(memb_a32[ds, eax + 0xf], 0);        /* cmp byte [eax+0xf], 0x0 */
            ii(0x100b_e472, 2); if(jzd(0x100b_e484, 0x10)) goto l_0x100b_e484; /* jz 0x100be484 */
            ii(0x100b_e474, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e477, 4); mov(memb_a32[ds, eax + 0x10], 0);       /* mov byte [eax+0x10], 0x0 */
            ii(0x100b_e47b, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100b_e47f, 5); jmpd(0x100b_e5b6, 0x132); goto l_0x100b_e5b6; /* jmp 0x100be5b6 */
        l_0x100b_e484:
            ii(0x100b_e484, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e487, 3); mov(al, memb_a32[ds, eax + 0x10]);      /* mov al, [eax+0x10] */
            ii(0x100b_e48a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_e48f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_e491, 2); if(jnzd(0x100b_e4a3, 0x10)) goto l_0x100b_e4a3; /* jnz 0x100be4a3 */
            ii(0x100b_e493, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e496, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_e499, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_e49e, 5); calld(0x100a_5287, -0x1_921c);          /* call 0x100a5287 */
        l_0x100b_e4a3:
            ii(0x100b_e4a3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e4a6, 3); inc(memb_a32[ds, eax + 0x10]);          /* inc byte [eax+0x10] */
            ii(0x100b_e4a9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e4ac, 3); mov(al, memb_a32[ds, eax + 0x10]);      /* mov al, [eax+0x10] */
            ii(0x100b_e4af, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_e4b4, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x100b_e4b7, 2); if(jged(0x100b_e4c2, 0x9)) goto l_0x100b_e4c2; /* jge 0x100be4c2 */
            ii(0x100b_e4b9, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x100b_e4bd, 5); jmpd(0x100b_e5b6, 0xf4); goto l_0x100b_e5b6; /* jmp 0x100be5b6 */
        l_0x100b_e4c2:
            ii(0x100b_e4c2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e4c5, 3); mov(al, memb_a32[ds, eax + 0x10]);      /* mov al, [eax+0x10] */
            ii(0x100b_e4c8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_e4cd, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x100b_e4d0, 2); if(jnzd(0x100b_e4de, 0xc)) goto l_0x100b_e4de; /* jnz 0x100be4de */
            ii(0x100b_e4d2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e4d5, 5); calld(0x100b_e145, -0x395);             /* call 0x100be145 */
            ii(0x100b_e4da, 2); test(al, al);                           /* test al, al */
            ii(0x100b_e4dc, 2); if(jzd(0x100b_e4e0, 0x2)) goto l_0x100b_e4e0; /* jz 0x100be4e0 */
        l_0x100b_e4de:
            ii(0x100b_e4de, 2); jmpd(0x100b_e4f9, 0x19); goto l_0x100b_e4f9; /* jmp 0x100be4f9 */
        l_0x100b_e4e0:
            ii(0x100b_e4e0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e4e3, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_e4e6, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_e4eb, 5); calld(0x100a_5155, -0x1_939b);          /* call 0x100a5155 */
            ii(0x100b_e4f0, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100b_e4f4, 5); jmpd(0x100b_e5b6, 0xbd); goto l_0x100b_e5b6; /* jmp 0x100be5b6 */
        l_0x100b_e4f9:
            ii(0x100b_e4f9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e4fc, 3); mov(al, memb_a32[ds, eax + 0x10]);      /* mov al, [eax+0x10] */
            ii(0x100b_e4ff, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_e504, 3); cmp(eax, 0x14);                         /* cmp eax, 0x14 */
            ii(0x100b_e507, 2); if(jnzd(0x100b_e51a, 0x11)) goto l_0x100b_e51a; /* jnz 0x100be51a */
            ii(0x100b_e509, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e50c, 5); calld(0x100b_dec7, -0x64a);             /* call 0x100bdec7 */
            ii(0x100b_e511, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100b_e515, 5); jmpd(0x100b_e5b6, 0x9c); goto l_0x100b_e5b6; /* jmp 0x100be5b6 */
        l_0x100b_e51a:
            ii(0x100b_e51a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e51d, 3); mov(al, memb_a32[ds, eax + 0x10]);      /* mov al, [eax+0x10] */
            ii(0x100b_e520, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_e525, 3); cmp(eax, 0x1e);                         /* cmp eax, 0x1e */
            ii(0x100b_e528, 2); if(jnzd(0x100b_e54d, 0x23)) goto l_0x100b_e54d; /* jnz 0x100be54d */
            ii(0x100b_e52a, 5); mov(edx, 0x101c_8184);                  /* mov edx, 0x101c8184 */
            ii(0x100b_e52f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e532, 5); calld(0x100b_e094, -0x4a3);             /* call 0x100be094 */
            ii(0x100b_e537, 5); mov(edx, 0x101c_81a8);                  /* mov edx, 0x101c81a8 */
            ii(0x100b_e53c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e53f, 5); calld(0x100b_e094, -0x4b0);             /* call 0x100be094 */
            ii(0x100b_e544, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100b_e548, 5); jmpd(0x100b_e5b6, 0x69); goto l_0x100b_e5b6; /* jmp 0x100be5b6 */
        l_0x100b_e54d:
            ii(0x100b_e54d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e550, 3); mov(al, memb_a32[ds, eax + 0x10]);      /* mov al, [eax+0x10] */
            ii(0x100b_e553, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_e558, 3); cmp(eax, 0x3c);                         /* cmp eax, 0x3c */
            ii(0x100b_e55b, 2); if(jnzd(0x100b_e573, 0x16)) goto l_0x100b_e573; /* jnz 0x100be573 */
            ii(0x100b_e55d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e560, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100b_e563, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_e568, 5); calld(0x100a_5155, -0x1_9418);          /* call 0x100a5155 */
            ii(0x100b_e56d, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100b_e571, 2); jmpd(0x100b_e5b6, 0x43); goto l_0x100b_e5b6; /* jmp 0x100be5b6 */
        l_0x100b_e573:
            ii(0x100b_e573, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e576, 3); mov(al, memb_a32[ds, eax + 0x10]);      /* mov al, [eax+0x10] */
            ii(0x100b_e579, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100b_e57e, 3); cmp(eax, 0x78);                         /* cmp eax, 0x78 */
            ii(0x100b_e581, 2); if(jled(0x100b_e5b2, 0x2f)) goto l_0x100b_e5b2; /* jle 0x100be5b2 */
            ii(0x100b_e583, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_e585, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100b_e58a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_e58c, 2); if(jzd(0x100b_e597, 0x9)) goto l_0x100b_e597; /* jz 0x100be597 */
            ii(0x100b_e58e, 7); cmp(memb_a32[ds, 0x101c_391e], 0x9);    /* cmp byte [0x101c391e], 0x9 */
            ii(0x100b_e595, 2); if(jnzd(0x100b_e599, 0x2)) goto l_0x100b_e599; /* jnz 0x100be599 */
        l_0x100b_e597:
            ii(0x100b_e597, 2); jmpd(0x100b_e5a2, 0x9); goto l_0x100b_e5a2; /* jmp 0x100be5a2 */
        l_0x100b_e599:
            ii(0x100b_e599, 5); calld(0x100b_e19e, -0x400);             /* call 0x100be19e */
            ii(0x100b_e59e, 2); test(al, al);                           /* test al, al */
            ii(0x100b_e5a0, 2); if(jzd(0x100b_e5b2, 0x10)) goto l_0x100b_e5b2; /* jz 0x100be5b2 */
        l_0x100b_e5a2:
            ii(0x100b_e5a2, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_e5a7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e5aa, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_e5ad, 5); calld(0x1010_26f8, 0x4_4146);           /* call 0x101026f8 */
        l_0x100b_e5b2:
            ii(0x100b_e5b2, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x100b_e5b6:
            ii(0x100b_e5b6, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100b_e5b9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_e5bb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_e5bc, 1); popd(edi);                              /* pop edi */
            ii(0x100b_e5bd, 1); popd(esi);                              /* pop esi */
            ii(0x100b_e5be, 1); popd(edx);                              /* pop edx */
            ii(0x100b_e5bf, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_e5c0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_e5c1, 1); retd(); return;                         /* ret */
        }
    }
}
