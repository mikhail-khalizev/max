using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("de03cac6-79f3-4a82-adf5-c5c557af3e63")]
        public void /* sys */ Method_1018_63bc()
        {
            ii(0x1018_63bc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_63bd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_63be, 1); pushd(edx);                             /* push edx */
            ii(0x1018_63bf, 1); pushd(esi);                             /* push esi */
            ii(0x1018_63c0, 1); pushd(edi);                             /* push edi */
            ii(0x1018_63c1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_63c2, 5); mov(eax, memd_a32[ds, 0x101b_e85c]);    /* mov eax, [0x101be85c] */
            ii(0x1018_63c7, 2); xor(ebp, ebp);                          /* xor ebp, ebp */
            ii(0x1018_63c9, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1018_63cc, 2); if(jbd(0x1018_63d5, 0x7)) goto l_0x1018_63d5; /* jb 0x101863d5 */
            ii(0x1018_63ce, 2); if(jbed(0x1018_641d, 0x4d)) goto l_0x1018_641d; /* jbe 0x1018641d */
            ii(0x1018_63d0, 5); jmpd(0x1018_6615, 0x240); goto l_0x1018_6615; /* jmp 0x10186615 */
        l_0x1018_63d5:
            ii(0x1018_63d5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_63d7, 6); if(jnzd(0x1018_6615, 0x238)) goto l_0x1018_6615; /* jnz 0x10186615 */
            ii(0x1018_63dd, 6); mov(edx, memd_a32[ds, 0x101b_e864]);    /* mov edx, [0x101be864] */
            ii(0x1018_63e3, 1); inc(edx);                               /* inc edx */
            ii(0x1018_63e4, 5); mov(eax, memd_a32[ds, 0x101b_e870]);    /* mov eax, [0x101be870] */
            ii(0x1018_63e9, 6); mov(memd_a32[ds, 0x101b_e864], edx);    /* mov [0x101be864], edx */
            ii(0x1018_63ef, 5); calld(/* sys */ 0x1016_b898, -0x1_ab5c); /* call 0x1016b898 */
            ii(0x1018_63f4, 6); mov(ebx, memd_a32[ds, 0x101b_e858]);    /* mov ebx, [0x101be858] */
            ii(0x1018_63fa, 5); mov(memd_a32[ds, 0x101b_e860], eax);    /* mov [0x101be860], eax */
            ii(0x1018_63ff, 6); cmp(ebx, 0xfff);                        /* cmp ebx, 0xfff */
            ii(0x1018_6405, 3); setz(al);                               /* setz al */
            ii(0x1018_6408, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_640d, 6); if(jzd(0x1018_6615, 0x202)) goto l_0x1018_6615; /* jz 0x10186615 */
            ii(0x1018_6413, 5); calld(/* sys */ 0x1018_66ac, 0x294);    /* call 0x101866ac */
            ii(0x1018_6418, 5); jmpd(0x1018_6615, 0x1f8); goto l_0x1018_6615; /* jmp 0x10186615 */
        l_0x1018_641d:
            ii(0x1018_641d, 5); mov(eax, memd_a32[ds, 0x101b_e858]);    /* mov eax, [0x101be858] */
            ii(0x1018_6422, 6); cmp(eax, memd_a32[ds, 0x101b_e87c]);    /* cmp eax, [0x101be87c] */
            ii(0x1018_6428, 2); if(jld(0x1018_6441, 0x17)) goto l_0x1018_6441; /* jl 0x10186441 */
            ii(0x1018_642a, 5); calld(/* sys */ 0x1018_6738, 0x309);    /* call 0x10186738 */
            ii(0x1018_642f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_6431, 2); if(jnzd(0x1018_6441, 0xe)) goto l_0x1018_6441; /* jnz 0x10186441 */
            ii(0x1018_6433, 5); calld(/* sys */ 0x1018_62e4, -0x154);   /* call 0x101862e4 */
            ii(0x1018_6438, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1018_643a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_643b, 1); popd(edi);                              /* pop edi */
            ii(0x1018_643c, 1); popd(esi);                              /* pop esi */
            ii(0x1018_643d, 1); popd(edx);                              /* pop edx */
            ii(0x1018_643e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_643f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_6440, 1); retd(); return;                         /* ret */
        l_0x1018_6441:
            ii(0x1018_6441, 6); mov(edx, memd_a32[ds, 0x101b_e858]);    /* mov edx, [0x101be858] */
            ii(0x1018_6447, 7); lea(eax, edx * 4 + 0);                  /* lea eax, [edx*4] */
            ii(0x1018_644e, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1018_6450, 6); mov(edx, memd_a32[ds, 0x101b_e854]);    /* mov edx, [0x101be854] */
            ii(0x1018_6456, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1018_6459, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_645b, 6); mov(ebx, memd_a32[ds, 0x1020_a2c4]);    /* mov ebx, [0x1020a2c4] */
            ii(0x1018_6461, 3); cmp(ebx, memd_a32[ds, edx + 0x8]);      /* cmp ebx, [edx+0x8] */
            ii(0x1018_6464, 2); if(jaed(0x1018_64a1, 0x3b)) goto l_0x1018_64a1; /* jae 0x101864a1 */
            ii(0x1018_6466, 6); mov(ecx, memd_a32[ds, 0x1020_a2c0]);    /* mov ecx, [0x1020a2c0] */
            ii(0x1018_646c, 5); mov(eax, memd_a32[ds, 0x101b_e864]);    /* mov eax, [0x101be864] */
            ii(0x1018_6471, 3); mov(ebx, memd_a32[ds, edx + 0x4]);      /* mov ebx, [edx+0x4] */
            ii(0x1018_6474, 6); mov(esi, memd_a32[ds, 0x1020_a2c4]);    /* mov esi, [0x1020a2c4] */
            ii(0x1018_647a, 2); sub(ebx, ecx);                          /* sub ebx, ecx */
            ii(0x1018_647c, 2); sub(eax, esi);                          /* sub eax, esi */
            ii(0x1018_647e, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x1018_6481, 6); mov(edi, memd_a32[ds, 0x1020_a2c4]);    /* mov edi, [0x1020a2c4] */
            ii(0x1018_6487, 3); mov(esi, memd_a32[ds, edx + 0x8]);      /* mov esi, [edx+0x8] */
            ii(0x1018_648a, 2); sub(esi, edi);                          /* sub esi, edi */
            ii(0x1018_648c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_648e, 2); div(esi);                               /* div esi */
            ii(0x1018_6490, 3); lea(edx, ecx + eax);                    /* lea edx, [ecx+eax] */
        l_0x1018_6493:
            ii(0x1018_6493, 5); mov(eax, memd_a32[ds, 0x101b_e870]);    /* mov eax, [0x101be870] */
            ii(0x1018_6498, 5); calld(/* sys */ 0x1016_b898, -0x1_ac05); /* call 0x1016b898 */
            ii(0x1018_649d, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_649f, 2); if(jbd(0x1018_6493, -0xe)) goto l_0x1018_6493; /* jb 0x10186493 */
        l_0x1018_64a1:
            ii(0x1018_64a1, 6); inc(memd_a32[ds, 0x101b_e864]);         /* inc dword [0x101be864] */
        l_0x1018_64a7:
            ii(0x1018_64a7, 7); imul(eax, memd_a32[ds, 0x101b_e858], 0x18); /* imul eax, [0x101be858], 0x18 */
            ii(0x1018_64ae, 6); mov(edx, memd_a32[ds, 0x101b_e854]);    /* mov edx, [0x101be854] */
            ii(0x1018_64b4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_64b6, 5); mov(eax, memd_a32[ds, 0x101b_e864]);    /* mov eax, [0x101be864] */
            ii(0x1018_64bb, 3); cmp(eax, memd_a32[ds, edx + 0x8]);      /* cmp eax, [edx+0x8] */
            ii(0x1018_64be, 6); if(jbd(0x1018_6615, 0x151)) goto l_0x1018_6615; /* jb 0x10186615 */
            ii(0x1018_64c4, 5); mov(eax, memd_a32[ds, 0x101b_e870]);    /* mov eax, [0x101be870] */
            ii(0x1018_64c9, 5); calld(/* sys */ 0x1016_b898, -0x1_ac36); /* call 0x1016b898 */
            ii(0x1018_64ce, 7); imul(ebx, memd_a32[ds, 0x101b_e858], 0x18); /* imul ebx, [0x101be858], 0x18 */
            ii(0x1018_64d5, 6); mov(edx, memd_a32[ds, 0x101b_e854]);    /* mov edx, [0x101be854] */
            ii(0x1018_64db, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x1018_64dd, 3); mov(ebx, memd_a32[ds, edx + 0x4]);      /* mov ebx, [edx+0x4] */
            ii(0x1018_64e0, 3); add(ebx, 0x5);                          /* add ebx, 0x5 */
            ii(0x1018_64e3, 5); mov(memd_a32[ds, 0x101b_e860], eax);    /* mov [0x101be860], eax */
            ii(0x1018_64e8, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1018_64ea, 2); if(jad(0x1018_64f6, 0xa)) goto l_0x1018_64f6; /* ja 0x101864f6 */
            ii(0x1018_64ec, 3); mov(edx, memd_a32[ds, edx + 0x4]);      /* mov edx, [edx+0x4] */
            ii(0x1018_64ef, 3); sub(edx, 0x5);                          /* sub edx, 0x5 */
            ii(0x1018_64f2, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_64f4, 2); if(jaed(0x1018_651d, 0x27)) goto l_0x1018_651d; /* jae 0x1018651d */
        l_0x1018_64f6:
            ii(0x1018_64f6, 7); imul(eax, memd_a32[ds, 0x101b_e858], 0x18); /* imul eax, [0x101be858], 0x18 */
            ii(0x1018_64fd, 6); mov(edx, memd_a32[ds, 0x101b_e854]);    /* mov edx, [0x101be854] */
            ii(0x1018_6503, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_6505, 5); mov(eax, memd_a32[ds, 0x101b_e860]);    /* mov eax, [0x101be860] */
            ii(0x1018_650a, 3); mov(ecx, memd_a32[ds, edx + 0x4]);      /* mov ecx, [edx+0x4] */
            ii(0x1018_650d, 6); mov(esi, memd_a32[ds, 0x101b_e870]);    /* mov esi, [0x101be870] */
            ii(0x1018_6513, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1018_6515, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1018_6517, 6); mov(memd_a32[ds, 0x101b_e870], esi);    /* mov [0x101be870], esi */
        l_0x1018_651d:
            ii(0x1018_651d, 7); imul(edx, memd_a32[ds, 0x101b_e858], 0x18); /* imul edx, [0x101be858], 0x18 */
            ii(0x1018_6524, 5); mov(eax, memd_a32[ds, 0x101b_e854]);    /* mov eax, [0x101be854] */
            ii(0x1018_6529, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_652b, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1018_652d, 3); cmp(edx, 0x3);                          /* cmp edx, 0x3 */
            ii(0x1018_6530, 6); if(jad(0x1018_65ea, 0xb4)) goto l_0x1018_65ea; /* ja 0x101865ea */
            ii(0x1018_6536, 8); 
            switch (jmpd_abs_switch(memd_a32[cs, edx * 4 + /* sys */ 0x1018_63ac]))
            {
                case 0x1018_653e:
                    goto l_0x1018_653e;
                case 0x1018_65c7:
                    goto l_0x1018_65c7;
                case 0x1018_65d7:
                    goto l_0x1018_65d7;
                case 0x1018_65ea:
                    goto l_0x1018_65ea;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:edx*4+0x101863ac] */
        l_0x1018_653e:
            ii(0x1018_653e, 10); mov(memd_a32[ds, 0x101b_e85c], 0x2);   /* mov dword [0x101be85c], 0x2 */
            ii(0x1018_6548, 5); calld(/* sys */ 0x1017_2d30, -0x1_381d); /* call 0x10172d30 */
            ii(0x1018_654d, 7); imul(edx, memd_a32[ds, 0x101b_e858], 0x18); /* imul edx, [0x101be858], 0x18 */
            ii(0x1018_6554, 5); mov(memd_a32[ds, 0x101b_e888], eax);    /* mov [0x101be888], eax */
            ii(0x1018_6559, 5); mov(eax, memd_a32[ds, 0x101b_e854]);    /* mov eax, [0x101be854] */
            ii(0x1018_655e, 4); mov(eax, memd_a32[ds, edx + eax + 0x14]); /* mov eax, [edx+eax+0x14] */
            ii(0x1018_6562, 5); calld(/* sys */ 0x1017_2cb8, -0x1_38af); /* call 0x10172cb8 */
        l_0x1018_6567:
            ii(0x1018_6567, 5); calld(/* sys */ 0x1016_c348, -0x1_a224); /* call 0x1016c348 */
            ii(0x1018_656c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_656e, 2); if(jzd(0x1018_6577, 0x7)) goto l_0x1018_6577; /* jz 0x10186577 */
            ii(0x1018_6570, 5); calld(/* sys */ 0x1016_be9c, -0x1_a6d9); /* call 0x1016be9c */
            ii(0x1018_6575, 2); jmpd(0x1018_6567, -0x10); goto l_0x1018_6567; /* jmp 0x10186567 */
        l_0x1018_6577:
            ii(0x1018_6577, 10); mov(memd_a32[ds, 0x101b_e85c], 0x1);   /* mov dword [0x101be85c], 0x1 */
            ii(0x1018_6581, 5); calld(/* sys */ 0x1016_be34, -0x1_a752); /* call 0x1016be34 */
            ii(0x1018_6586, 7); imul(edx, memd_a32[ds, 0x101b_e858], 0x18); /* imul edx, [0x101be858], 0x18 */
            ii(0x1018_658d, 5); mov(eax, memd_a32[ds, 0x101b_e854]);    /* mov eax, [0x101be854] */
            ii(0x1018_6592, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_6594, 3); mov(edx, memd_a32[ds, eax + 0x10]);     /* mov edx, [eax+0x10] */
            ii(0x1018_6597, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x1018_659a, 5); calld(/* sys */ 0x1016_c2bc, -0x1_a2e3); /* call 0x1016c2bc */
            ii(0x1018_659f, 5); calld(/* sys */ 0x1016_bcc4, -0x1_a8e0); /* call 0x1016bcc4 */
            ii(0x1018_65a4, 5); calld(/* sys */ 0x1017_2bf0, -0x1_39b9); /* call 0x10172bf0 */
            ii(0x1018_65a9, 5); mov(eax, memd_a32[ds, 0x101b_e884]);    /* mov eax, [0x101be884] */
            ii(0x1018_65ae, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1018_65b0, 5); mov(memd_a32[ds, 0x101b_e868], eax);    /* mov [0x101be868], eax */
            ii(0x1018_65b5, 5); calld(/* sys */ 0x1016_b7b8, -0x1_ae02); /* call 0x1016b7b8 */
            ii(0x1018_65ba, 5); mov(memd_a32[ds, 0x101b_e870], eax);    /* mov [0x101be870], eax */
            ii(0x1018_65bf, 6); mov(memd_a32[ds, 0x101b_e864], edi);    /* mov [0x101be864], edi */
            ii(0x1018_65c5, 2); jmpd(0x1018_65ea, 0x23); goto l_0x1018_65ea; /* jmp 0x101865ea */
        l_0x1018_65c7:
            ii(0x1018_65c7, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x1018_65cb, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1018_65d0, 5); calld(/* sys */ 0x1017_2e04, -0x1_37d1); /* call 0x10172e04 */
            ii(0x1018_65d5, 2); jmpd(0x1018_65ea, 0x13); goto l_0x1018_65ea; /* jmp 0x101865ea */
        l_0x1018_65d7:
            ii(0x1018_65d7, 3); mov(ebx, memd_a32[ds, eax + 0x14]);     /* mov ebx, [eax+0x14] */
            ii(0x1018_65da, 3); mov(edx, memd_a32[ds, eax + 0x10]);     /* mov edx, [eax+0x10] */
            ii(0x1018_65dd, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x1018_65e0, 5); mov(ebp, 0x3);                          /* mov ebp, 0x3 */
            ii(0x1018_65e5, 5); calld(/* sys */ 0x1016_bfb8, -0x1_a632); /* call 0x1016bfb8 */
        l_0x1018_65ea:
            ii(0x1018_65ea, 6); mov(edx, memd_a32[ds, 0x101b_e858]);    /* mov edx, [0x101be858] */
            ii(0x1018_65f0, 3); imul(eax, edx, 0x18);                   /* imul eax, edx, 0x18 */
            ii(0x1018_65f3, 5); mov(ecx, 0x6);                          /* mov ecx, 0x6 */
            ii(0x1018_65f8, 6); mov(esi, memd_a32[ds, 0x101b_e854]);    /* mov esi, [0x101be854] */
            ii(0x1018_65fe, 5); mov(edi, 0x1020_a2bc);                  /* mov edi, 0x1020a2bc */
            ii(0x1018_6603, 3); lea(ebx, edx + 0x1);                    /* lea ebx, [edx+0x1] */
            ii(0x1018_6606, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1018_6608, 6); mov(memd_a32[ds, 0x101b_e858], ebx);    /* mov [0x101be858], ebx */
            ii(0x1018_660e, 2); rep_a32(() => movsd_a32());             /* rep movsd */
            ii(0x1018_6610, 5); jmpd(0x1018_64a7, -0x16e); goto l_0x1018_64a7; /* jmp 0x101864a7 */
        l_0x1018_6615:
            ii(0x1018_6615, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1018_6617, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_6618, 1); popd(edi);                              /* pop edi */
            ii(0x1018_6619, 1); popd(esi);                              /* pop esi */
            ii(0x1018_661a, 1); popd(edx);                              /* pop edx */
            ii(0x1018_661b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_661c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_661d, 1); retd(); return;                         /* ret */
        }
    }
}
