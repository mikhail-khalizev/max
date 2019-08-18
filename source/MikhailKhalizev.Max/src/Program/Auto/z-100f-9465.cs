using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ef91e9ce-4f58-412c-9a0a-9d0869fcc9b2")]
        public void Method_100f_9465()
        {
            ii(0x100f_9465, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100f_946a, 5); calld(Definitions.sys_check_available_stack_size, 0x6_c8e3); /* call 0x10165d52 */
            ii(0x100f_946f, 1); pushd(esi);                             /* push esi */
            ii(0x100f_9470, 1); pushd(edi);                             /* push edi */
            ii(0x100f_9471, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_9472, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_9474, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100f_947a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_947d, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100f_9480, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100f_9483, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100f_9486, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100f_948a, 2); if(jzd(0x100f_94a3, 0x17)) goto l_0x100f_94a3; /* jz 0x100f94a3 */
            ii(0x100f_948c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_948f, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100f_9492, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_9497, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_9499, 6); mov(dl, memb_a32[ds, 0x101c_37da]);     /* mov dl, [0x101c37da] */
            ii(0x100f_949f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_94a1, 2); if(jnzd(0x100f_94a5, 0x2)) goto l_0x100f_94a5; /* jnz 0x100f94a5 */
        l_0x100f_94a3:
            ii(0x100f_94a3, 2); jmpd(0x100f_94c1, 0x1c); goto l_0x100f_94c1; /* jmp 0x100f94c1 */
        l_0x100f_94a5:
            ii(0x100f_94a5, 4); movsx(ecx, memw_a32[ss, ebp - 0x4]);    /* movsx ecx, word [ebp-0x4] */
            ii(0x100f_94a9, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x100f_94ad, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100f_94b0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_94b3, 5); calld(0x100f_927b, -0x23d);             /* call 0x100f927b */
            ii(0x100f_94b8, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x100f_94bc, 5); jmpd(0x100f_95d7, 0x116); goto l_0x100f_95d7; /* jmp 0x100f95d7 */
        l_0x100f_94c1:
            ii(0x100f_94c1, 7); cmp(memb_a32[ds, 0x101c_391e], 0x9);    /* cmp byte [0x101c391e], 0x9 */
            ii(0x100f_94c8, 2); if(jnzd(0x100f_94d6, 0xc)) goto l_0x100f_94d6; /* jnz 0x100f94d6 */
            ii(0x100f_94ca, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_94cc, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100f_94d1, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_94d4, 2); if(jnzd(0x100f_94f3, 0x1d)) goto l_0x100f_94f3; /* jnz 0x100f94f3 */
        l_0x100f_94d6:
            ii(0x100f_94d6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_94d8, 5); mov(al, memb_a32[ds, 0x101c_37c8]);     /* mov al, [0x101c37c8] */
            ii(0x100f_94dd, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_94e3, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_94e9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_94ee, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_94f1, 2); if(jzd(0x100f_9504, 0x11)) goto l_0x100f_9504; /* jz 0x100f9504 */
        l_0x100f_94f3:
            ii(0x100f_94f3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_94f6, 5); calld(0x100f_92fe, -0x1fd);             /* call 0x100f92fe */
            ii(0x100f_94fb, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x100f_94ff, 5); jmpd(0x100f_95d7, 0xd3); goto l_0x100f_95d7; /* jmp 0x100f95d7 */
        l_0x100f_9504:
            ii(0x100f_9504, 7); cmp(memb_a32[ds, 0x101c_3918], 0);      /* cmp byte [0x101c3918], 0x0 */
            ii(0x100f_950b, 2); if(jzd(0x100f_9513, 0x6)) goto l_0x100f_9513; /* jz 0x100f9513 */
            ii(0x100f_950d, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100f_9511, 2); if(jnzd(0x100f_9515, 0x2)) goto l_0x100f_9515; /* jnz 0x100f9515 */
        l_0x100f_9513:
            ii(0x100f_9513, 2); jmpd(0x100f_951b, 0x6); goto l_0x100f_951b; /* jmp 0x100f951b */
        l_0x100f_9515:
            ii(0x100f_9515, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100f_9519, 2); if(jnzd(0x100f_9520, 0x5)) goto l_0x100f_9520; /* jnz 0x100f9520 */
        l_0x100f_951b:
            ii(0x100f_951b, 5); jmpd(0x100f_95d3, 0xb3); goto l_0x100f_95d3; /* jmp 0x100f95d3 */
        l_0x100f_9520:
            ii(0x100f_9520, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_9523, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_9525, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100f_9528, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_952a, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_952f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_9531, 2); if(jzd(0x100f_953c, 0x9)) goto l_0x100f_953c; /* jz 0x100f953c */
            ii(0x100f_9533, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x100f_9537, 5); jmpd(0x100f_95d7, 0x9b); goto l_0x100f_95d7; /* jmp 0x100f95d7 */
        l_0x100f_953c:
            ii(0x100f_953c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_953f, 5); calld(0x1007_6188, -0x8_33bc);          /* call 0x10076188 */
            ii(0x100f_9544, 3); cmp(eax, memd_a32[ss, ebp - 0x10]);     /* cmp eax, [ebp-0x10] */
            ii(0x100f_9547, 2); if(jnzd(0x100f_9556, 0xd)) goto l_0x100f_9556; /* jnz 0x100f9556 */
            ii(0x100f_9549, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_954c, 5); calld(0x1014_b6bd, 0x5_216c);           /* call 0x1014b6bd */
            ii(0x100f_9551, 5); jmpd(0x100f_95c8, 0x72); goto l_0x100f_95c8; /* jmp 0x100f95c8 */
        l_0x100f_9556:
            ii(0x100f_9556, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_9559, 3); cmp(eax, memd_a32[ss, ebp - 0x10]);     /* cmp eax, [ebp-0x10] */
            ii(0x100f_955c, 2); if(jzd(0x100f_9569, 0xb)) goto l_0x100f_9569; /* jz 0x100f9569 */
            ii(0x100f_955e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_9561, 6); test(memw_a32[ds, eax + 0x12], 0x1c0);  /* test word [eax+0x12], 0x1c0 */
            ii(0x100f_9567, 2); if(jnzd(0x100f_956b, 0x2)) goto l_0x100f_956b; /* jnz 0x100f956b */
        l_0x100f_9569:
            ii(0x100f_9569, 2); jmpd(0x100f_9576, 0xb); goto l_0x100f_9576; /* jmp 0x100f9576 */
        l_0x100f_956b:
            ii(0x100f_956b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_956e, 6); test(memw_a32[ds, eax + 0x12], 0x1c0);  /* test word [eax+0x12], 0x1c0 */
            ii(0x100f_9574, 2); if(jnzd(0x100f_9578, 0x2)) goto l_0x100f_9578; /* jnz 0x100f9578 */
        l_0x100f_9576:
            ii(0x100f_9576, 2); jmpd(0x100f_9581, 0x9); goto l_0x100f_9581; /* jmp 0x100f9581 */
        l_0x100f_9578:
            ii(0x100f_9578, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_957b, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1);     /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100f_957f, 2); if(jzd(0x100f_9583, 0x2)) goto l_0x100f_9583; /* jz 0x100f9583 */
        l_0x100f_9581:
            ii(0x100f_9581, 2); jmpd(0x100f_958c, 0x9); goto l_0x100f_958c; /* jmp 0x100f958c */
        l_0x100f_9583:
            ii(0x100f_9583, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_9586, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1);     /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100f_958a, 2); if(jzd(0x100f_958e, 0x2)) goto l_0x100f_958e; /* jz 0x100f958e */
        l_0x100f_958c:
            ii(0x100f_958c, 2); jmpd(0x100f_95c8, 0x3a); goto l_0x100f_95c8; /* jmp 0x100f95c8 */
        l_0x100f_958e:
            ii(0x100f_958e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_9591, 5); calld(0x1007_61d4, -0x8_33c2);          /* call 0x100761d4 */
            ii(0x100f_9596, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100f_9599, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100f_959d, 2); if(jzd(0x100f_95ad, 0xe)) goto l_0x100f_95ad; /* jz 0x100f95ad */
            ii(0x100f_959f, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_95a2, 5); calld(0x1007_6b90, -0x8_2a17);          /* call 0x10076b90 */
            ii(0x100f_95a7, 1); cwde();                                 /* cwde */
            ii(0x100f_95a8, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x100f_95ab, 2); if(jged(0x100f_95c8, 0x1b)) goto l_0x100f_95c8; /* jge 0x100f95c8 */
        l_0x100f_95ad:
            ii(0x100f_95ad, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_95b0, 5); calld(0x1014_b6bd, 0x5_2108);           /* call 0x1014b6bd */
            ii(0x100f_95b5, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100f_95b8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_95bb, 5); calld(0x1014_b64e, 0x5_208e);           /* call 0x1014b64e */
            ii(0x100f_95c0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_95c3, 5); calld(0x1007_5c12, -0x8_39b6);          /* call 0x10075c12 */
        l_0x100f_95c8:
            ii(0x100f_95c8, 5); calld(0x100f_f5c1, 0x5ff4);             /* call 0x100ff5c1 */
            ii(0x100f_95cd, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x100f_95d1, 2); jmpd(0x100f_95d7, 0x4); goto l_0x100f_95d7; /* jmp 0x100f95d7 */
        l_0x100f_95d3:
            ii(0x100f_95d3, 4); mov(memb_a32[ss, ebp - 0x14], 0x1);     /* mov byte [ebp-0x14], 0x1 */
        l_0x100f_95d7:
            ii(0x100f_95d7, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100f_95da, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_95dc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_95dd, 1); popd(edi);                              /* pop edi */
            ii(0x100f_95de, 1); popd(esi);                              /* pop esi */
            ii(0x100f_95df, 1); retd(); return;                         /* ret */
        }
    }
}
