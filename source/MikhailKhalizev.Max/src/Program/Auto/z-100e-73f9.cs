using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_73f9-539e76ec")]
        public void Method_100e_73f9()
        {
            ii(0x100e_73f9, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x100e_73fe, 5); calld(Definitions.sys_check_available_stack_size, 0x7_e94f); /* call 0x10165d52 */
            ii(0x100e_7403, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_7404, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_7405, 1); pushd(edx);                             /* push edx */
            ii(0x100e_7406, 1); pushd(esi);                             /* push esi */
            ii(0x100e_7407, 1); pushd(edi);                             /* push edi */
            ii(0x100e_7408, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_7409, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_740b, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100e_7411, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_7414, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_7417, 5); calld(0x1007_6338, -0x7_10e4);          /* call 0x10076338 */
            ii(0x100e_741c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_741e, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_7421, 5); calld(0x1007_64b8, -0x7_0f6e);          /* call 0x100764b8 */
            ii(0x100e_7426, 5); mov(eax, 0x23);                         /* mov eax, 0x23 */
            ii(0x100e_742b, 5); calld(0x100e_883d, 0x140d);             /* call 0x100e883d */
            ii(0x100e_7430, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x100e_7433, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_7436, 2); jmpd(0x100e_7440, 0x8); goto l_0x100e_7440; /* jmp 0x100e7440 */
        l_0x100e_7438:
            ii(0x100e_7438, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_743b, 5); calld(0x1007_6bf8, -0x7_0848);          /* call 0x10076bf8 */
        l_0x100e_7440:
            ii(0x100e_7440, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_7442, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_7445, 5); calld(0x1013_ad71, 0x5_3927);           /* call 0x1013ad71 */
            ii(0x100e_744a, 2); test(al, al);                           /* test al, al */
            ii(0x100e_744c, 6); if(jzd(0x100e_75f0, 0x19e)) goto l_0x100e_75f0; /* jz 0x100e75f0 */
            ii(0x100e_7452, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_7454, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100e_7459, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100e_745c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_745f, 5); calld(0x1007_63a0, -0x7_10c4);          /* call 0x100763a0 */
            ii(0x100e_7464, 5); calld(0x1007_6074, -0x7_13f5);          /* call 0x10076074 */
            ii(0x100e_7469, 2); test(al, al);                           /* test al, al */
            ii(0x100e_746b, 2); if(jnzd(0x100e_7476, 0x9)) goto l_0x100e_7476; /* jnz 0x100e7476 */
            ii(0x100e_746d, 7); cmp(memb_a32[ds, 0x101c_3980], 0);      /* cmp byte [0x101c3980], 0x0 */
            ii(0x100e_7474, 2); if(jzd(0x100e_748f, 0x19)) goto l_0x100e_748f; /* jz 0x100e748f */
        l_0x100e_7476:
            ii(0x100e_7476, 7); cmp(memd_a32[ds, 0x101c_38c0], 0x4);    /* cmp dword [0x101c38c0], 0x4 */
            ii(0x100e_747d, 2); if(jgd(0x100e_748d, 0xe)) goto l_0x100e_748d; /* jg 0x100e748d */
            ii(0x100e_747f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_7482, 5); calld(0x1007_63a0, -0x7_10e7);          /* call 0x100763a0 */
            ii(0x100e_7487, 4); test(memb_a32[ds, eax + 0x12], 0x1);    /* test byte [eax+0x12], 0x1 */
            ii(0x100e_748b, 2); if(jnzd(0x100e_748f, 0x2)) goto l_0x100e_748f; /* jnz 0x100e748f */
        l_0x100e_748d:
            ii(0x100e_748d, 2); jmpd(0x100e_7491, 0x2); goto l_0x100e_7491; /* jmp 0x100e7491 */
        l_0x100e_748f:
            ii(0x100e_748f, 2); jmpd(0x100e_749f, 0xe); goto l_0x100e_749f; /* jmp 0x100e749f */
        l_0x100e_7491:
            ii(0x100e_7491, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_7494, 5); calld(0x1007_63a0, -0x7_10f9);          /* call 0x100763a0 */
            ii(0x100e_7499, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x100e_749d, 2); if(jnzd(0x100e_74a1, 0x2)) goto l_0x100e_74a1; /* jnz 0x100e74a1 */
        l_0x100e_749f:
            ii(0x100e_749f, 2); jmpd(0x100e_74af, 0xe); goto l_0x100e_74af; /* jmp 0x100e74af */
        l_0x100e_74a1:
            ii(0x100e_74a1, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_74a4, 5); calld(0x1007_63a0, -0x7_1109);          /* call 0x100763a0 */
            ii(0x100e_74a9, 4); test(memb_a32[ds, eax + 0x14], 0x40);   /* test byte [eax+0x14], 0x40 */
            ii(0x100e_74ad, 2); if(jnzd(0x100e_74b4, 0x5)) goto l_0x100e_74b4; /* jnz 0x100e74b4 */
        l_0x100e_74af:
            ii(0x100e_74af, 5); jmpd(0x100e_75eb, 0x137); goto l_0x100e_75eb; /* jmp 0x100e75eb */
        l_0x100e_74b4:
            ii(0x100e_74b4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_74b6, 5); mov(al, memb_a32[ds, 0x101c_37d1]);     /* mov al, [0x101c37d1] */
            ii(0x100e_74bb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_74bd, 2); if(jzd(0x100e_74d1, 0x12)) goto l_0x100e_74d1; /* jz 0x100e74d1 */
            ii(0x100e_74bf, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_74c2, 5); calld(0x1007_63a0, -0x7_1127);          /* call 0x100763a0 */
            ii(0x100e_74c7, 4); test(memb_a32[ds, eax + 0x14], 0x6);    /* test byte [eax+0x14], 0x6 */
            ii(0x100e_74cb, 6); if(jzd(0x100e_75eb, 0x11a)) goto l_0x100e_75eb; /* jz 0x100e75eb */
        l_0x100e_74d1:
            ii(0x100e_74d1, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_74d4, 5); calld(0x1007_63a0, -0x7_1139);          /* call 0x100763a0 */
            ii(0x100e_74d9, 4); test(memb_a32[ds, eax + 0x13], 0x20);   /* test byte [eax+0x13], 0x20 */
            ii(0x100e_74dd, 2); if(jzd(0x100e_74e8, 0x9)) goto l_0x100e_74e8; /* jz 0x100e74e8 */
            ii(0x100e_74df, 7); mov(memd_a32[ss, ebp - 0x8], 0x1);      /* mov dword [ebp-0x8], 0x1 */
            ii(0x100e_74e6, 2); jmpd(0x100e_7534, 0x4c); goto l_0x100e_7534; /* jmp 0x100e7534 */
        l_0x100e_74e8:
            ii(0x100e_74e8, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_74eb, 5); calld(0x1007_63a0, -0x7_1150);          /* call 0x100763a0 */
            ii(0x100e_74f0, 4); test(memb_a32[ds, eax + 0x13], 0x10);   /* test byte [eax+0x13], 0x10 */
            ii(0x100e_74f4, 2); if(jzd(0x100e_74ff, 0x9)) goto l_0x100e_74ff; /* jz 0x100e74ff */
            ii(0x100e_74f6, 7); mov(memd_a32[ss, ebp - 0x8], 0x2);      /* mov dword [ebp-0x8], 0x2 */
            ii(0x100e_74fd, 2); jmpd(0x100e_7534, 0x35); goto l_0x100e_7534; /* jmp 0x100e7534 */
        l_0x100e_74ff:
            ii(0x100e_74ff, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_7502, 5); calld(0x1007_63a0, -0x7_1167);          /* call 0x100763a0 */
            ii(0x100e_7507, 4); test(memb_a32[ds, eax + 0x13], 0x8);    /* test byte [eax+0x13], 0x8 */
            ii(0x100e_750b, 2); if(jzd(0x100e_7516, 0x9)) goto l_0x100e_7516; /* jz 0x100e7516 */
            ii(0x100e_750d, 7); mov(memd_a32[ss, ebp - 0x8], 0x3);      /* mov dword [ebp-0x8], 0x3 */
            ii(0x100e_7514, 2); jmpd(0x100e_7534, 0x1e); goto l_0x100e_7534; /* jmp 0x100e7534 */
        l_0x100e_7516:
            ii(0x100e_7516, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_7519, 5); calld(0x1007_63a0, -0x7_117e);          /* call 0x100763a0 */
            ii(0x100e_751e, 4); test(memb_a32[ds, eax + 0x13], 0x4);    /* test byte [eax+0x13], 0x4 */
            ii(0x100e_7522, 2); if(jzd(0x100e_752d, 0x9)) goto l_0x100e_752d; /* jz 0x100e752d */
            ii(0x100e_7524, 7); mov(memd_a32[ss, ebp - 0x8], 0xff);     /* mov dword [ebp-0x8], 0xff */
            ii(0x100e_752b, 2); jmpd(0x100e_7534, 0x7); goto l_0x100e_7534; /* jmp 0x100e7534 */
        l_0x100e_752d:
            ii(0x100e_752d, 7); mov(memd_a32[ss, ebp - 0x8], 0x4);      /* mov dword [ebp-0x8], 0x4 */
        l_0x100e_7534:
            ii(0x100e_7534, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_7537, 5); calld(0x1007_63a0, -0x7_119c);          /* call 0x100763a0 */
            ii(0x100e_753c, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x100e_7540, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_7543, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_7546, 5); calld(0x1007_63a0, -0x7_11ab);          /* call 0x100763a0 */
            ii(0x100e_754b, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x100e_754f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_7552, 7); cmp(memb_a32[ds, 0x101c_37d0], 0);      /* cmp byte [0x101c37d0], 0x0 */
            ii(0x100e_7559, 2); if(jzd(0x100e_7569, 0xe)) goto l_0x100e_7569; /* jz 0x100e7569 */
            ii(0x100e_755b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_755e, 5); calld(0x1007_63a0, -0x7_11c3);          /* call 0x100763a0 */
            ii(0x100e_7563, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x100e_7567, 2); if(jzd(0x100e_75d3, 0x6a)) goto l_0x100e_75d3; /* jz 0x100e75d3 */
        l_0x100e_7569:
            ii(0x100e_7569, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100e_756d, 3); cmp(eax, 0x6f);                         /* cmp eax, 0x6f */
            ii(0x100e_7570, 2); if(jld(0x100e_7579, 0x7)) goto l_0x100e_7579; /* jl 0x100e7579 */
            ii(0x100e_7572, 7); mov(memd_a32[ss, ebp - 0xc], 0x6e);     /* mov dword [ebp-0xc], 0x6e */
        l_0x100e_7579:
            ii(0x100e_7579, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100e_757d, 3); cmp(eax, 0x6f);                         /* cmp eax, 0x6f */
            ii(0x100e_7580, 2); if(jld(0x100e_7589, 0x7)) goto l_0x100e_7589; /* jl 0x100e7589 */
            ii(0x100e_7582, 7); mov(memd_a32[ss, ebp - 0x10], 0x6e);    /* mov dword [ebp-0x10], 0x6e */
        l_0x100e_7589:
            ii(0x100e_7589, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100e_758d, 6); imul(eax, eax, 0x280);                  /* imul eax, eax, 0x280 */
            ii(0x100e_7593, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100e_7597, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_7599, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100e_759c, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100e_759f, 3); add(edx, memd_a32[ss, ebp - 0x1c]);     /* add edx, [ebp-0x1c] */
            ii(0x100e_75a2, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100e_75a5, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
            ii(0x100e_75a7, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100e_75aa, 3); add(edx, memd_a32[ss, ebp - 0x1c]);     /* add edx, [ebp-0x1c] */
            ii(0x100e_75ad, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100e_75b0, 3); mov(memb_a32[ds, edx + 0x1], al);       /* mov [edx+0x1], al */
            ii(0x100e_75b3, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100e_75b6, 3); add(edx, memd_a32[ss, ebp - 0x1c]);     /* add edx, [ebp-0x1c] */
            ii(0x100e_75b9, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100e_75bc, 6); mov(memb_a32[ds, edx + 0x280], al);     /* mov [edx+0x280], al */
            ii(0x100e_75c2, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100e_75c5, 3); add(edx, memd_a32[ss, ebp - 0x1c]);     /* add edx, [ebp-0x1c] */
            ii(0x100e_75c8, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100e_75cb, 6); mov(memb_a32[ds, edx + 0x281], al);     /* mov [edx+0x281], al */
            ii(0x100e_75d1, 2); jmpd(0x100e_75eb, 0x18); goto l_0x100e_75eb; /* jmp 0x100e75eb */
        l_0x100e_75d3:
            ii(0x100e_75d3, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100e_75d7, 6); imul(eax, edx, 0x280);                  /* imul eax, edx, 0x280 */
            ii(0x100e_75dd, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100e_75e1, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_75e3, 3); add(edx, memd_a32[ss, ebp - 0x14]);     /* add edx, [ebp-0x14] */
            ii(0x100e_75e6, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100e_75e9, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
        l_0x100e_75eb:
            ii(0x100e_75eb, 5); jmpd(0x100e_7438, -0x1b8); goto l_0x100e_7438; /* jmp 0x100e7438 */
        l_0x100e_75f0:
            ii(0x100e_75f0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_75f2, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_75f5, 5); calld(0x1007_5f6c, -0x7_168e);          /* call 0x10075f6c */
            ii(0x100e_75fa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_75fc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_75fd, 1); popd(edi);                              /* pop edi */
            ii(0x100e_75fe, 1); popd(esi);                              /* pop esi */
            ii(0x100e_75ff, 1); popd(edx);                              /* pop edx */
            ii(0x100e_7600, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_7601, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_7602, 1); retd();                                 /* ret */
        }
    }
}
