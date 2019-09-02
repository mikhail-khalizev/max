using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_7500-bdfc8260")]
        public void /* sys */ Method_1016_7500()
        {
            ii(0x1016_7500, 1); push(ecx);                              /* push ecx */
            ii(0x1016_7501, 1); push(esi);                              /* push esi */
            ii(0x1016_7502, 1); push(edi);                              /* push edi */
            ii(0x1016_7503, 1); push(ebp);                              /* push ebp */
            ii(0x1016_7504, 3); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1016_7507, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_7509, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1016_750b, 4); mov(memd[ss, esp + 40], ebx);           /* mov [esp+0x28], ebx */
            ii(0x1016_750f, 4); test(memb[ds, eax + 4], 8);             /* test byte [eax+0x4], 0x8 */
            ii(0x1016_7513, 6); if(jnz(0x1016_7ab5, 0x59c)) goto l_0x1016_7ab5; /* jnz 0x10167ab5 */
            ii(0x1016_7519, 4); test(memb[ds, esi + 4], 0x20);          /* test byte [esi+0x4], 0x20 */
            ii(0x1016_751d, 6); if(jz(0x1016_7651, 0x12e)) goto l_0x1016_7651; /* jz 0x10167651 */
            ii(0x1016_7523, 7); cmp(memd[ds, 0x101c_b2c4], 0);          /* cmp dword [0x101cb2c4], 0x0 */
            ii(0x1016_752a, 6); if(jz(0x1016_7651, 0x121)) goto l_0x1016_7651; /* jz 0x10167651 */
            ii(0x1016_7530, 7); cmp(memd[ds, 0x101c_b2d0], 0);          /* cmp dword [0x101cb2d0], 0x0 */
            ii(0x1016_7537, 6); if(jnz(0x1016_7651, 0x114)) goto l_0x1016_7651; /* jnz 0x10167651 */
            ii(0x1016_753d, 6); mov(edx, memd[ds, 0x101b_ddd8]);        /* mov edx, [0x101bddd8] */
            ii(0x1016_7543, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_7545, 5); call(/* sys */ 0x1016_7d38, 0x7ee);     /* call 0x10167d38 */
            ii(0x1016_754a, 3); mov(eax, memd[ss, ebp + 8]);            /* mov eax, [ebp+0x8] */
            ii(0x1016_754d, 3); sub(eax, memd[ss, ebp]);                /* sub eax, [ebp] */
            ii(0x1016_7550, 1); inc(eax);                               /* inc eax */
            ii(0x1016_7551, 3); mov(edi, memd[ss, ebp + 4]);            /* mov edi, [ebp+0x4] */
            ii(0x1016_7554, 4); mov(memd[ss, esp + 28], eax);           /* mov [esp+0x1c], eax */
            ii(0x1016_7558, 3); mov(eax, memd[ss, ebp + 12]);           /* mov eax, [ebp+0xc] */
            ii(0x1016_755b, 2); sub(eax, edi);                          /* sub eax, edi */
            ii(0x1016_755d, 3); lea(edi, memd[ds, eax + 1]);            /* lea edi, [eax+0x1] */
            ii(0x1016_7560, 5); call(/* sys */ 0x1016_c350, 0x4deb);    /* call 0x1016c350 */
            ii(0x1016_7565, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_7567, 6); if(jnz(0x1016_761c, 0xaf)) goto l_0x1016_761c; /* jnz 0x1016761c */
            ii(0x1016_756d, 3); mov(ecx, memd[ss, ebp + 12]);           /* mov ecx, [ebp+0xc] */
            ii(0x1016_7570, 3); mov(ebx, memd[ss, ebp + 8]);            /* mov ebx, [ebp+0x8] */
            ii(0x1016_7573, 3); mov(edx, memd[ss, ebp + 4]);            /* mov edx, [ebp+0x4] */
            ii(0x1016_7576, 3); mov(eax, memd[ss, ebp]);                /* mov eax, [ebp] */
            ii(0x1016_7579, 5); call(/* sys */ 0x1016_c184, 0x4c06);    /* call 0x1016c184 */
            ii(0x1016_757e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_7580, 6); if(jz(0x1016_761c, 0x96)) goto l_0x1016_761c; /* jz 0x1016761c */
            ii(0x1016_7586, 5); call(/* sys */ 0x1016_bcc4, 0x4739);    /* call 0x1016bcc4 */
            ii(0x1016_758b, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1016_758d, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_758f, 5); call(/* sys */ 0x1016_c25c, 0x4cc8);    /* call 0x1016c25c */
            ii(0x1016_7594, 2); mov(eax, ebp);                          /* mov eax, ebp */
            ii(0x1016_7596, 5); call(/* sys */ 0x1018_5dd0, 0x1_e835);  /* call 0x10185dd0 */
            ii(0x1016_759b, 4); mov(memd[ss, esp + 16], eax);           /* mov [esp+0x10], eax */
            ii(0x1016_759f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_75a1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_75a3, 6); if(jz(0x1016_7ab5, 0x50c)) goto l_0x1016_7ab5; /* jz 0x10167ab5 */
        l_0x1016_75a9:
            ii(0x1016_75a9, 3); mov(eax, memd[ds, ebx + 16]);           /* mov eax, [ebx+0x10] */
            ii(0x1016_75ac, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1016_75ae, 4); mov(memd[ss, esp + 20], eax);           /* mov [esp+0x14], eax */
            ii(0x1016_75b2, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_75b4, 5); call(/* sys */ 0x1016_9da0, 0x27e7);    /* call 0x10169da0 */
            ii(0x1016_75b9, 3); mov(edi, memd[ds, ebx + 4]);            /* mov edi, [ebx+0x4] */
            ii(0x1016_75bc, 1); push(edi);                              /* push edi */
            ii(0x1016_75bd, 2); mov(eax, memd[ds, ebx]);                /* mov eax, [ebx] */
            ii(0x1016_75bf, 1); push(eax);                              /* push eax */
            ii(0x1016_75c0, 3); mov(eax, memd[ds, ebx + 12]);           /* mov eax, [ebx+0xc] */
            ii(0x1016_75c3, 2); sub(eax, edi);                          /* sub eax, edi */
            ii(0x1016_75c5, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1016_75c7, 3); lea(edi, memd[ds, eax + 1]);            /* lea edi, [eax+0x1] */
            ii(0x1016_75ca, 2); mov(ecx, memd[ds, ebx]);                /* mov ecx, [ebx] */
            ii(0x1016_75cc, 3); mov(eax, memd[ds, ebx + 8]);            /* mov eax, [ebx+0x8] */
            ii(0x1016_75cf, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_75d1, 1); push(edi);                              /* push edi */
            ii(0x1016_75d2, 1); inc(eax);                               /* inc eax */
            ii(0x1016_75d3, 1); push(eax);                              /* push eax */
            ii(0x1016_75d4, 2); push(0);                                /* push 0x0 */
            ii(0x1016_75d6, 2); push(0);                                /* push 0x0 */
            ii(0x1016_75d8, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_75da, 3); mov(edx, memd[ss, ebp + 4]);            /* mov edx, [ebp+0x4] */
            ii(0x1016_75dd, 1); push(edi);                              /* push edi */
            ii(0x1016_75de, 4); mov(edi, memd[ss, esp + 56]);           /* mov edi, [esp+0x38] */
            ii(0x1016_75e2, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_75e4, 2); mov(ecx, edi);                          /* mov ecx, edi */
            ii(0x1016_75e6, 3); imul(ecx, eax);                         /* imul ecx, eax */
            ii(0x1016_75e9, 1); push(edi);                              /* push edi */
            ii(0x1016_75ea, 3); mov(edi, memd[ss, ebp]);                /* mov edi, [ebp] */
            ii(0x1016_75ed, 2); mov(eax, memd[ds, ebx]);                /* mov eax, [ebx] */
            ii(0x1016_75ef, 6); mov(edx, memd[ds, 0x101b_ddd8]);        /* mov edx, [0x101bddd8] */
            ii(0x1016_75f5, 2); sub(eax, edi);                          /* sub eax, edi */
            ii(0x1016_75f7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_75f9, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1016_75fb, 1); push(ecx);                              /* push ecx */
            ii(0x1016_75fc, 6); call_abs(memd[ds, 0x1020_892c]);        /* call dword [0x1020892c] */
            ii(0x1016_7602, 3); add(esp, 0x24);                         /* add esp, 0x24 */
            ii(0x1016_7605, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_7607, 4); mov(ebx, memd[ss, esp + 20]);           /* mov ebx, [esp+0x14] */
            ii(0x1016_760b, 5); call(/* sys */ 0x1018_5f28, 0x1_e918);  /* call 0x10185f28 */
            ii(0x1016_7610, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_7612, 2); if(jnz(0x1016_75a9, -0x6b)) goto l_0x1016_75a9; /* jnz 0x101675a9 */
            ii(0x1016_7614, 3); add(esp, 0x34);                         /* add esp, 0x34 */
            ii(0x1016_7617, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_7618, 1); pop(edi);                               /* pop edi */
            ii(0x1016_7619, 1); pop(esi);                               /* pop esi */
            ii(0x1016_761a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_761b, 1); ret(); return;                          /* ret */
        l_0x1016_761c:
            ii(0x1016_761c, 2); mov(edx, ebp);                          /* mov edx, ebp */
            ii(0x1016_761e, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_7620, 5); call(/* sys */ 0x1016_9da0, 0x277b);    /* call 0x10169da0 */
            ii(0x1016_7625, 3); mov(eax, memd[ss, ebp + 4]);            /* mov eax, [ebp+0x4] */
            ii(0x1016_7628, 1); push(eax);                              /* push eax */
            ii(0x1016_7629, 3); mov(edx, memd[ss, ebp]);                /* mov edx, [ebp] */
            ii(0x1016_762c, 1); push(edx);                              /* push edx */
            ii(0x1016_762d, 1); push(edi);                              /* push edi */
            ii(0x1016_762e, 4); mov(ebx, memd[ss, esp + 40]);           /* mov ebx, [esp+0x28] */
            ii(0x1016_7632, 1); push(ebx);                              /* push ebx */
            ii(0x1016_7633, 2); push(0);                                /* push 0x0 */
            ii(0x1016_7635, 2); push(0);                                /* push 0x0 */
            ii(0x1016_7637, 1); push(edi);                              /* push edi */
            ii(0x1016_7638, 1); push(ebx);                              /* push ebx */
            ii(0x1016_7639, 6); mov(esi, memd[ds, 0x101b_ddd8]);        /* mov esi, [0x101bddd8] */
            ii(0x1016_763f, 1); push(esi);                              /* push esi */
            ii(0x1016_7640, 6); call_abs(memd[ds, 0x1020_892c]);        /* call dword [0x1020892c] */
            ii(0x1016_7646, 3); add(esp, 0x24);                         /* add esp, 0x24 */
            ii(0x1016_7649, 3); add(esp, 0x34);                         /* add esp, 0x34 */
            ii(0x1016_764c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_764d, 1); pop(edi);                               /* pop edi */
            ii(0x1016_764e, 1); pop(esi);                               /* pop esi */
            ii(0x1016_764f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_7650, 1); ret(); return;                          /* ret */
        l_0x1016_7651:
            ii(0x1016_7651, 5); call(/* sys */ 0x1018_5edc, 0x1_e886);  /* call 0x10185edc */
            ii(0x1016_7656, 4); mov(memd[ss, esp + 16], eax);           /* mov [esp+0x10], eax */
            ii(0x1016_765a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_765c, 6); if(jz(0x1016_7ab5, 0x453)) goto l_0x1016_7ab5; /* jz 0x10167ab5 */
            ii(0x1016_7662, 7); mov(memd[ds, eax + 16], 0);             /* mov dword [eax+0x10], 0x0 */
            ii(0x1016_7669, 3); lea(eax, memd[ds, esi + 8]);            /* lea eax, [esi+0x8] */
            ii(0x1016_766c, 3); mov(ecx, memd[ss, ebp]);                /* mov ecx, [ebp] */
            ii(0x1016_766f, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1016_7671, 2); cmp(edx, ecx);                          /* cmp edx, ecx */
            ii(0x1016_7673, 2); if(jge(0x1016_767d, 8)) goto l_0x1016_767d; /* jge 0x1016767d */
            ii(0x1016_7675, 4); mov(ebx, memd[ss, esp + 16]);           /* mov ebx, [esp+0x10] */
            ii(0x1016_7679, 2); mov(memd[ds, ebx], ecx);                /* mov [ebx], ecx */
            ii(0x1016_767b, 2); jmp(0x1016_7683, 6); goto l_0x1016_7683; /* jmp 0x10167683 */
        l_0x1016_767d:
            ii(0x1016_767d, 4); mov(ebx, memd[ss, esp + 16]);           /* mov ebx, [esp+0x10] */
            ii(0x1016_7681, 2); mov(memd[ds, ebx], edx);                /* mov [ebx], edx */
        l_0x1016_7683:
            ii(0x1016_7683, 3); mov(edx, memd[ds, eax + 4]);            /* mov edx, [eax+0x4] */
            ii(0x1016_7686, 3); mov(edi, memd[ss, ebp + 4]);            /* mov edi, [ebp+0x4] */
            ii(0x1016_7689, 2); cmp(edx, edi);                          /* cmp edx, edi */
            ii(0x1016_768b, 2); if(jge(0x1016_7696, 9)) goto l_0x1016_7696; /* jge 0x10167696 */
            ii(0x1016_768d, 4); mov(edx, memd[ss, esp + 16]);           /* mov edx, [esp+0x10] */
            ii(0x1016_7691, 3); mov(memd[ds, edx + 4], edi);            /* mov [edx+0x4], edi */
            ii(0x1016_7694, 2); jmp(0x1016_769f, 9); goto l_0x1016_769f; /* jmp 0x1016769f */
        l_0x1016_7696:
            ii(0x1016_7696, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1016_7698, 4); mov(edx, memd[ss, esp + 16]);           /* mov edx, [esp+0x10] */
            ii(0x1016_769c, 3); mov(memd[ds, edx + 4], ebx);            /* mov [edx+0x4], ebx */
        l_0x1016_769f:
            ii(0x1016_769f, 3); mov(edx, memd[ds, eax + 8]);            /* mov edx, [eax+0x8] */
            ii(0x1016_76a2, 3); mov(ebx, memd[ss, ebp + 8]);            /* mov ebx, [ebp+0x8] */
            ii(0x1016_76a5, 2); cmp(edx, ebx);                          /* cmp edx, ebx */
            ii(0x1016_76a7, 2); if(jle(0x1016_76ab, 2)) goto l_0x1016_76ab; /* jle 0x101676ab */
            ii(0x1016_76a9, 2); mov(edx, ebx);                          /* mov edx, ebx */
        l_0x1016_76ab:
            ii(0x1016_76ab, 4); mov(ebx, memd[ss, esp + 16]);           /* mov ebx, [esp+0x10] */
            ii(0x1016_76af, 3); mov(memd[ds, ebx + 8], edx);            /* mov [ebx+0x8], edx */
            ii(0x1016_76b2, 3); mov(edx, memd[ds, eax + 12]);           /* mov edx, [eax+0xc] */
            ii(0x1016_76b5, 3); mov(ecx, memd[ss, ebp + 12]);           /* mov ecx, [ebp+0xc] */
            ii(0x1016_76b8, 2); cmp(edx, ecx);                          /* cmp edx, ecx */
            ii(0x1016_76ba, 2); if(jle(0x1016_76c5, 9)) goto l_0x1016_76c5; /* jle 0x101676c5 */
            ii(0x1016_76bc, 4); mov(eax, memd[ss, esp + 16]);           /* mov eax, [esp+0x10] */
            ii(0x1016_76c0, 3); mov(memd[ds, eax + 12], ecx);           /* mov [eax+0xc], ecx */
            ii(0x1016_76c3, 2); jmp(0x1016_76cc, 7); goto l_0x1016_76cc; /* jmp 0x101676cc */
        l_0x1016_76c5:
            ii(0x1016_76c5, 4); mov(eax, memd[ss, esp + 16]);           /* mov eax, [esp+0x10] */
            ii(0x1016_76c9, 3); mov(memd[ds, eax + 12], edx);           /* mov [eax+0xc], edx */
        l_0x1016_76cc:
            ii(0x1016_76cc, 4); mov(eax, memd[ss, esp + 16]);           /* mov eax, [esp+0x10] */
            ii(0x1016_76d0, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1016_76d2, 3); cmp(edx, memd[ds, eax + 8]);            /* cmp edx, [eax+0x8] */
            ii(0x1016_76d5, 2); if(jg(0x1016_76df, 8)) goto l_0x1016_76df; /* jg 0x101676df */
            ii(0x1016_76d7, 3); mov(edx, memd[ds, eax + 4]);            /* mov edx, [eax+0x4] */
            ii(0x1016_76da, 3); cmp(edx, memd[ds, eax + 12]);           /* cmp edx, [eax+0xc] */
            ii(0x1016_76dd, 2); if(jle(0x1016_76f0, 0x11)) goto l_0x1016_76f0; /* jle 0x101676f0 */
        l_0x1016_76df:
            ii(0x1016_76df, 4); mov(eax, memd[ss, esp + 16]);           /* mov eax, [esp+0x10] */
            ii(0x1016_76e3, 5); call(/* sys */ 0x1018_5f28, 0x1_e840);  /* call 0x10185f28 */
            ii(0x1016_76e8, 3); add(esp, 0x34);                         /* add esp, 0x34 */
            ii(0x1016_76eb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_76ec, 1); pop(edi);                               /* pop edi */
            ii(0x1016_76ed, 1); pop(esi);                               /* pop esi */
            ii(0x1016_76ee, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_76ef, 1); ret(); return;                          /* ret */
        l_0x1016_76f0:
            ii(0x1016_76f0, 5); cmp(memd[ss, esp + 40], 0);             /* cmp dword [esp+0x28], 0x0 */
            ii(0x1016_76f5, 2); if(jz(0x1016_7702, 0xb)) goto l_0x1016_7702; /* jz 0x10167702 */
            ii(0x1016_76f7, 3); mov(eax, memd[ss, ebp + 8]);            /* mov eax, [ebp+0x8] */
            ii(0x1016_76fa, 3); sub(eax, memd[ss, ebp]);                /* sub eax, [ebp] */
            ii(0x1016_76fd, 1); inc(eax);                               /* inc eax */
            ii(0x1016_76fe, 4); mov(memd[ss, esp + 36], eax);           /* mov [esp+0x24], eax */
        l_0x1016_7702:
            ii(0x1016_7702, 4); mov(ebx, memd[ss, esp + 40]);           /* mov ebx, [esp+0x28] */
            ii(0x1016_7706, 4); lea(edx, memd[ss, esp + 16]);           /* lea edx, [esp+0x10] */
            ii(0x1016_770a, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_770c, 5); call(/* sys */ 0x1016_7ad4, 0x3c3);     /* call 0x10167ad4 */
            ii(0x1016_7711, 3); cmp(memd[ds, esi], 0);                  /* cmp dword [esi], 0x0 */
            ii(0x1016_7714, 6); if(jnz(0x1016_781c, 0x102)) goto l_0x1016_781c; /* jnz 0x1016781c */
            ii(0x1016_771a, 4); mov(esi, memd[ss, esp + 16]);           /* mov esi, [esp+0x10] */
            ii(0x1016_771e, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1016_7720, 6); if(jz(0x1016_7a10, 0x2ea)) goto l_0x1016_7a10; /* jz 0x10167a10 */
        l_0x1016_7726:
            ii(0x1016_7726, 3); mov(eax, memd[ds, esi + 16]);           /* mov eax, [esi+0x10] */
            ii(0x1016_7729, 2); mov(edi, memd[ds, esi]);                /* mov edi, [esi] */
            ii(0x1016_772b, 4); mov(memd[ss, esp + 32], eax);           /* mov [esp+0x20], eax */
            ii(0x1016_772f, 3); mov(eax, memd[ds, esi + 8]);            /* mov eax, [esi+0x8] */
            ii(0x1016_7732, 2); sub(eax, edi);                          /* sub eax, edi */
            ii(0x1016_7734, 3); lea(edi, memd[ds, eax + 1]);            /* lea edi, [eax+0x1] */
            ii(0x1016_7737, 3); mov(edx, memd[ds, esi + 4]);            /* mov edx, [esi+0x4] */
            ii(0x1016_773a, 3); mov(eax, memd[ds, esi + 12]);           /* mov eax, [esi+0xc] */
            ii(0x1016_773d, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_773f, 1); inc(eax);                               /* inc eax */
            ii(0x1016_7740, 4); mov(memd[ss, esp + 44], eax);           /* mov [esp+0x2c], eax */
            ii(0x1016_7744, 3); imul(eax, edi);                         /* imul eax, edi */
            ii(0x1016_7747, 5); call(Definitions.sys_malloc_internal, 0x1_aba4); /* call 0x101822f0 */
            ii(0x1016_774c, 4); mov(memd[ss, esp + 48], eax);           /* mov [esp+0x30], eax */
            ii(0x1016_7750, 4); mov(memd[ss, esp + 24], eax);           /* mov [esp+0x18], eax */
            ii(0x1016_7754, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_7756, 6); if(jz(0x1016_780b, 0xaf)) goto l_0x1016_780b; /* jz 0x1016780b */
            ii(0x1016_775c, 6); mov(ecx, memd[ds, 0x101c_b2c8]);        /* mov ecx, [0x101cb2c8] */
            ii(0x1016_7762, 4); mov(ebx, memd[ss, esp + 44]);           /* mov ebx, [esp+0x2c] */
            ii(0x1016_7766, 1); push(ecx);                              /* push ecx */
            ii(0x1016_7767, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1016_7769, 2); mov(ecx, edi);                          /* mov ecx, edi */
            ii(0x1016_776b, 5); call(/* sys */ 0x1016_ad78, 0x3608);    /* call 0x1016ad78 */
            ii(0x1016_7770, 5); cmp(memd[ss, esp + 40], 0);             /* cmp dword [esp+0x28], 0x0 */
            ii(0x1016_7775, 2); if(jnz(0x1016_77d0, 0x59)) goto l_0x1016_77d0; /* jnz 0x101677d0 */
            ii(0x1016_7777, 6); mov(ebx, memd[ds, 0x101c_b2c4]);        /* mov ebx, [0x101cb2c4] */
            ii(0x1016_777d, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_777f, 2); if(jz(0x1016_77af, 0x2e)) goto l_0x1016_77af; /* jz 0x101677af */
            ii(0x1016_7781, 5); mov(eax, memd[ds, 0x1020_88e8]);        /* mov eax, [0x102088e8] */
            ii(0x1016_7786, 6); sub(eax, memd[ds, 0x1020_88e0]);        /* sub eax, [0x102088e0] */
            ii(0x1016_778c, 1); inc(eax);                               /* inc eax */
            ii(0x1016_778d, 3); mov(ebx, memd[ds, esi + 4]);            /* mov ebx, [esi+0x4] */
            ii(0x1016_7790, 1); push(eax);                              /* push eax */
            ii(0x1016_7791, 3); imul(eax, ebx);                         /* imul eax, ebx */
            ii(0x1016_7794, 6); mov(edx, memd[ds, 0x101b_ddd8]);        /* mov edx, [0x101bddd8] */
            ii(0x1016_779a, 2); mov(ecx, memd[ds, esi]);                /* mov ecx, [esi] */
            ii(0x1016_779c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_779e, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1016_77a0, 1); push(eax);                              /* push eax */
            ii(0x1016_77a1, 1); push(edi);                              /* push edi */
            ii(0x1016_77a2, 4); mov(esi, memd[ss, esp + 56]);           /* mov esi, [esp+0x38] */
            ii(0x1016_77a6, 1); push(esi);                              /* push esi */
            ii(0x1016_77a7, 1); push(edi);                              /* push edi */
            ii(0x1016_77a8, 4); mov(edi, memd[ss, esp + 68]);           /* mov edi, [esp+0x44] */
            ii(0x1016_77ac, 1); push(edi);                              /* push edi */
            ii(0x1016_77ad, 2); jmp(0x1016_77fa, 0x4b); goto l_0x1016_77fa; /* jmp 0x101677fa */
        l_0x1016_77af:
            ii(0x1016_77af, 3); mov(ecx, memd[ds, esi + 4]);            /* mov ecx, [esi+0x4] */
            ii(0x1016_77b2, 1); push(ecx);                              /* push ecx */
            ii(0x1016_77b3, 2); mov(eax, memd[ds, esi]);                /* mov eax, [esi] */
            ii(0x1016_77b5, 1); push(eax);                              /* push eax */
            ii(0x1016_77b6, 4); mov(edx, memd[ss, esp + 52]);           /* mov edx, [esp+0x34] */
            ii(0x1016_77ba, 1); push(edx);                              /* push edx */
            ii(0x1016_77bb, 1); push(edi);                              /* push edi */
            ii(0x1016_77bc, 1); push(ebx);                              /* push ebx */
            ii(0x1016_77bd, 1); push(ebx);                              /* push ebx */
            ii(0x1016_77be, 1); push(edx);                              /* push edx */
            ii(0x1016_77bf, 1); push(edi);                              /* push edi */
            ii(0x1016_77c0, 4); mov(ecx, memd[ss, esp + 80]);           /* mov ecx, [esp+0x50] */
            ii(0x1016_77c4, 1); push(ecx);                              /* push ecx */
            ii(0x1016_77c5, 6); call_abs(memd[ds, 0x1020_892c]);        /* call dword [0x1020892c] */
            ii(0x1016_77cb, 3); add(esp, 0x24);                         /* add esp, 0x24 */
            ii(0x1016_77ce, 2); jmp(0x1016_7802, 0x32); goto l_0x1016_7802; /* jmp 0x10167802 */
        l_0x1016_77d0:
            ii(0x1016_77d0, 3); mov(eax, memd[ds, esi + 4]);            /* mov eax, [esi+0x4] */
            ii(0x1016_77d3, 3); mov(ebx, memd[ss, ebp + 4]);            /* mov ebx, [ebp+0x4] */
            ii(0x1016_77d6, 4); mov(edx, memd[ss, esp + 36]);           /* mov edx, [esp+0x24] */
            ii(0x1016_77da, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1016_77dc, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1016_77df, 1); push(edx);                              /* push edx */
            ii(0x1016_77e0, 4); mov(edx, memd[ss, esp + 44]);           /* mov edx, [esp+0x2c] */
            ii(0x1016_77e4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_77e6, 2); mov(eax, memd[ds, esi]);                /* mov eax, [esi] */
            ii(0x1016_77e8, 3); sub(eax, memd[ss, ebp]);                /* sub eax, [ebp] */
            ii(0x1016_77eb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_77ed, 1); push(eax);                              /* push eax */
            ii(0x1016_77ee, 1); push(edi);                              /* push edi */
            ii(0x1016_77ef, 4); mov(eax, memd[ss, esp + 56]);           /* mov eax, [esp+0x38] */
            ii(0x1016_77f3, 1); push(eax);                              /* push eax */
            ii(0x1016_77f4, 1); push(edi);                              /* push edi */
            ii(0x1016_77f5, 4); mov(edx, memd[ss, esp + 68]);           /* mov edx, [esp+0x44] */
            ii(0x1016_77f9, 1); push(edx);                              /* push edx */
        l_0x1016_77fa:
            ii(0x1016_77fa, 5); call(/* sys */ 0x1016_abbc, 0x33bd);    /* call 0x1016abbc */
            ii(0x1016_77ff, 3); add(esp, 0x18);                         /* add esp, 0x18 */
        l_0x1016_7802:
            ii(0x1016_7802, 4); mov(eax, memd[ss, esp + 24]);           /* mov eax, [esp+0x18] */
            ii(0x1016_7806, 5); call(Definitions.sys_free_internal, 0x1_ac49); /* call 0x10182454 */
        l_0x1016_780b:
            ii(0x1016_780b, 4); mov(esi, memd[ss, esp + 32]);           /* mov esi, [esp+0x20] */
            ii(0x1016_780f, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1016_7811, 6); if(jnz(0x1016_7726, -0xf1)) goto l_0x1016_7726; /* jnz 0x10167726 */
            ii(0x1016_7817, 5); jmp(0x1016_7a10, 0x1f4); goto l_0x1016_7a10; /* jmp 0x10167a10 */
        l_0x1016_781c:
            ii(0x1016_781c, 4); mov(ebx, memd[ss, esp + 16]);           /* mov ebx, [esp+0x10] */
            ii(0x1016_7820, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_7822, 6); if(jz(0x1016_7a10, 0x1e8)) goto l_0x1016_7a10; /* jz 0x10167a10 */
        l_0x1016_7828:
            ii(0x1016_7828, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1016_782a, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_782c, 3); mov(edi, memd[ds, ebx + 16]);           /* mov edi, [ebx+0x10] */
            ii(0x1016_782f, 5); call(/* sys */ 0x1016_9da0, 0x256c);    /* call 0x10169da0 */
            ii(0x1016_7834, 5); cmp(memd[ss, esp + 40], 0);             /* cmp dword [esp+0x28], 0x0 */
            ii(0x1016_7839, 6); if(jnz(0x1016_7946, 0x107)) goto l_0x1016_7946; /* jnz 0x10167946 */
            ii(0x1016_783f, 7); cmp(memd[ds, 0x101c_b2c4], 0);          /* cmp dword [0x101cb2c4], 0x0 */
            ii(0x1016_7846, 6); if(jz(0x1016_78f6, 0xaa)) goto l_0x1016_78f6; /* jz 0x101678f6 */
            ii(0x1016_784c, 5); mov(eax, memd[ds, 0x1020_88e8]);        /* mov eax, [0x102088e8] */
            ii(0x1016_7851, 6); sub(eax, memd[ds, 0x1020_88e0]);        /* sub eax, [0x102088e0] */
            ii(0x1016_7857, 3); mov(cl, memb[ds, esi + 4]);             /* mov cl, [esi+0x4] */
            ii(0x1016_785a, 1); inc(eax);                               /* inc eax */
            ii(0x1016_785b, 3); test(cl, 0x20);                         /* test cl, 0x20 */
            ii(0x1016_785e, 2); if(jz(0x1016_78ad, 0x4d)) goto l_0x1016_78ad; /* jz 0x101678ad */
            ii(0x1016_7860, 3); mov(ecx, memd[ds, ebx + 4]);            /* mov ecx, [ebx+0x4] */
            ii(0x1016_7863, 1); push(eax);                              /* push eax */
            ii(0x1016_7864, 3); imul(eax, ecx);                         /* imul eax, ecx */
            ii(0x1016_7867, 6); mov(edx, memd[ds, 0x101b_ddd8]);        /* mov edx, [0x101bddd8] */
            ii(0x1016_786d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_786f, 2); add(eax, memd[ds, ebx]);                /* add eax, [ebx] */
            ii(0x1016_7871, 1); push(eax);                              /* push eax */
            ii(0x1016_7872, 3); mov(edx, memd[ds, ebx + 4]);            /* mov edx, [ebx+0x4] */
            ii(0x1016_7875, 3); mov(eax, memd[ds, ebx + 12]);           /* mov eax, [ebx+0xc] */
            ii(0x1016_7878, 3); mov(ecx, memd[ds, esi + 24]);           /* mov ecx, [esi+0x18] */
            ii(0x1016_787b, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_787d, 1); push(ecx);                              /* push ecx */
            ii(0x1016_787e, 1); inc(eax);                               /* inc eax */
            ii(0x1016_787f, 2); mov(ecx, memd[ds, ebx]);                /* mov ecx, [ebx] */
            ii(0x1016_7881, 1); push(eax);                              /* push eax */
            ii(0x1016_7882, 3); mov(eax, memd[ds, ebx + 8]);            /* mov eax, [ebx+0x8] */
            ii(0x1016_7885, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_7887, 1); inc(eax);                               /* inc eax */
            ii(0x1016_7888, 1); push(eax);                              /* push eax */
            ii(0x1016_7889, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_788b, 3); mov(edx, memd[ds, esi + 12]);           /* mov edx, [esi+0xc] */
            ii(0x1016_788e, 3); mov(ecx, memd[ds, esi + 24]);           /* mov ecx, [esi+0x18] */
            ii(0x1016_7891, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_7893, 3); imul(ecx, eax);                         /* imul ecx, eax */
            ii(0x1016_7896, 2); mov(eax, memd[ds, ebx]);                /* mov eax, [ebx] */
            ii(0x1016_7898, 3); mov(ebx, memd[ds, esi + 8]);            /* mov ebx, [esi+0x8] */
            ii(0x1016_789b, 3); mov(edx, memd[ds, esi + 44]);           /* mov edx, [esi+0x2c] */
            ii(0x1016_789e, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1016_78a0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_78a2, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1016_78a4, 1); push(eax);                              /* push eax */
            ii(0x1016_78a5, 3); call_abs(memd[ds, esi + 64]);           /* call dword [esi+0x40] */
            ii(0x1016_78a8, 5); jmp(0x1016_7a03, 0x156); goto l_0x1016_7a03; /* jmp 0x10167a03 */
        l_0x1016_78ad:
            ii(0x1016_78ad, 3); mov(edx, memd[ds, ebx + 4]);            /* mov edx, [ebx+0x4] */
            ii(0x1016_78b0, 1); push(eax);                              /* push eax */
            ii(0x1016_78b1, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1016_78b4, 6); mov(edx, memd[ds, 0x101b_ddd8]);        /* mov edx, [0x101bddd8] */
            ii(0x1016_78ba, 2); mov(ecx, memd[ds, ebx]);                /* mov ecx, [ebx] */
            ii(0x1016_78bc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_78be, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1016_78c0, 1); push(eax);                              /* push eax */
            ii(0x1016_78c1, 3); mov(eax, memd[ds, esi + 24]);           /* mov eax, [esi+0x18] */
            ii(0x1016_78c4, 3); mov(edx, memd[ds, ebx + 4]);            /* mov edx, [ebx+0x4] */
            ii(0x1016_78c7, 1); push(eax);                              /* push eax */
            ii(0x1016_78c8, 3); mov(eax, memd[ds, ebx + 12]);           /* mov eax, [ebx+0xc] */
            ii(0x1016_78cb, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_78cd, 1); inc(eax);                               /* inc eax */
            ii(0x1016_78ce, 1); push(eax);                              /* push eax */
            ii(0x1016_78cf, 3); mov(eax, memd[ds, ebx + 8]);            /* mov eax, [ebx+0x8] */
            ii(0x1016_78d2, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_78d4, 1); inc(eax);                               /* inc eax */
            ii(0x1016_78d5, 1); push(eax);                              /* push eax */
            ii(0x1016_78d6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_78d8, 3); mov(edx, memd[ds, esi + 12]);           /* mov edx, [esi+0xc] */
            ii(0x1016_78db, 3); mov(ecx, memd[ds, esi + 24]);           /* mov ecx, [esi+0x18] */
            ii(0x1016_78de, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_78e0, 3); imul(ecx, eax);                         /* imul ecx, eax */
            ii(0x1016_78e3, 2); mov(eax, memd[ds, ebx]);                /* mov eax, [ebx] */
            ii(0x1016_78e5, 3); mov(ebx, memd[ds, esi + 8]);            /* mov ebx, [esi+0x8] */
            ii(0x1016_78e8, 3); mov(edx, memd[ds, esi + 44]);           /* mov edx, [esi+0x2c] */
            ii(0x1016_78eb, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1016_78ed, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_78ef, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1016_78f1, 5); jmp(0x1016_79fd, 0x107); goto l_0x1016_79fd; /* jmp 0x101679fd */
        l_0x1016_78f6:
            ii(0x1016_78f6, 3); mov(eax, memd[ds, ebx + 4]);            /* mov eax, [ebx+0x4] */
            ii(0x1016_78f9, 3); mov(ecx, memd[ds, ebx + 4]);            /* mov ecx, [ebx+0x4] */
            ii(0x1016_78fc, 1); push(eax);                              /* push eax */
            ii(0x1016_78fd, 3); mov(eax, memd[ds, ebx + 12]);           /* mov eax, [ebx+0xc] */
            ii(0x1016_7900, 2); mov(edx, memd[ds, ebx]);                /* mov edx, [ebx] */
            ii(0x1016_7902, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_7904, 1); push(edx);                              /* push edx */
            ii(0x1016_7905, 3); lea(edx, memd[ds, eax + 1]);            /* lea edx, [eax+0x1] */
            ii(0x1016_7908, 2); mov(ecx, memd[ds, ebx]);                /* mov ecx, [ebx] */
            ii(0x1016_790a, 3); mov(eax, memd[ds, ebx + 8]);            /* mov eax, [ebx+0x8] */
            ii(0x1016_790d, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_790f, 1); push(edx);                              /* push edx */
            ii(0x1016_7910, 1); inc(eax);                               /* inc eax */
            ii(0x1016_7911, 1); push(eax);                              /* push eax */
            ii(0x1016_7912, 2); push(0);                                /* push 0x0 */
            ii(0x1016_7914, 2); push(0);                                /* push 0x0 */
            ii(0x1016_7916, 1); push(edx);                              /* push edx */
            ii(0x1016_7917, 3); mov(eax, memd[ds, esi + 24]);           /* mov eax, [esi+0x18] */
            ii(0x1016_791a, 1); push(eax);                              /* push eax */
            ii(0x1016_791b, 3); mov(edx, memd[ds, esi + 12]);           /* mov edx, [esi+0xc] */
            ii(0x1016_791e, 3); mov(eax, memd[ds, ebx + 4]);            /* mov eax, [ebx+0x4] */
            ii(0x1016_7921, 3); mov(ecx, memd[ds, esi + 24]);           /* mov ecx, [esi+0x18] */
            ii(0x1016_7924, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_7926, 3); imul(ecx, eax);                         /* imul ecx, eax */
            ii(0x1016_7929, 2); mov(eax, memd[ds, ebx]);                /* mov eax, [ebx] */
            ii(0x1016_792b, 3); mov(ebx, memd[ds, esi + 8]);            /* mov ebx, [esi+0x8] */
            ii(0x1016_792e, 3); mov(edx, memd[ds, esi + 44]);           /* mov edx, [esi+0x2c] */
            ii(0x1016_7931, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1016_7933, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_7935, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1016_7937, 1); push(eax);                              /* push eax */
            ii(0x1016_7938, 6); call_abs(memd[ds, 0x1020_892c]);        /* call dword [0x1020892c] */
            ii(0x1016_793e, 3); add(esp, 0x24);                         /* add esp, 0x24 */
            ii(0x1016_7941, 5); jmp(0x1016_7a06, 0xc0); goto l_0x1016_7a06; /* jmp 0x10167a06 */
        l_0x1016_7946:
            ii(0x1016_7946, 7); cmp(memd[ds, 0x101c_b2c4], 0);          /* cmp dword [0x101cb2c4], 0x0 */
            ii(0x1016_794d, 2); if(jz(0x1016_79ad, 0x5e)) goto l_0x1016_79ad; /* jz 0x101679ad */
            ii(0x1016_794f, 4); test(memb[ds, esi + 4], 0x20);          /* test byte [esi+0x4], 0x20 */
            ii(0x1016_7953, 2); if(jz(0x1016_79ad, 0x58)) goto l_0x1016_79ad; /* jz 0x101679ad */
            ii(0x1016_7955, 3); mov(eax, memd[ds, ebx + 4]);            /* mov eax, [ebx+0x4] */
            ii(0x1016_7958, 3); mov(edx, memd[ss, ebp + 4]);            /* mov edx, [ebp+0x4] */
            ii(0x1016_795b, 4); mov(ecx, memd[ss, esp + 36]);           /* mov ecx, [esp+0x24] */
            ii(0x1016_795f, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_7961, 3); imul(eax, ecx);                         /* imul eax, ecx */
            ii(0x1016_7964, 1); push(ecx);                              /* push ecx */
            ii(0x1016_7965, 4); mov(edx, memd[ss, esp + 44]);           /* mov edx, [esp+0x2c] */
            ii(0x1016_7969, 3); mov(ecx, memd[ss, ebp]);                /* mov ecx, [ebp] */
            ii(0x1016_796c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_796e, 2); mov(eax, memd[ds, ebx]);                /* mov eax, [ebx] */
            ii(0x1016_7970, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_7972, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_7974, 1); push(eax);                              /* push eax */
            ii(0x1016_7975, 3); mov(eax, memd[ds, esi + 24]);           /* mov eax, [esi+0x18] */
            ii(0x1016_7978, 3); mov(edx, memd[ds, ebx + 4]);            /* mov edx, [ebx+0x4] */
            ii(0x1016_797b, 1); push(eax);                              /* push eax */
            ii(0x1016_797c, 3); mov(eax, memd[ds, ebx + 12]);           /* mov eax, [ebx+0xc] */
            ii(0x1016_797f, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_7981, 1); inc(eax);                               /* inc eax */
            ii(0x1016_7982, 2); mov(ecx, memd[ds, ebx]);                /* mov ecx, [ebx] */
            ii(0x1016_7984, 1); push(eax);                              /* push eax */
            ii(0x1016_7985, 3); mov(eax, memd[ds, ebx + 8]);            /* mov eax, [ebx+0x8] */
            ii(0x1016_7988, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_798a, 1); inc(eax);                               /* inc eax */
            ii(0x1016_798b, 1); push(eax);                              /* push eax */
            ii(0x1016_798c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_798e, 3); mov(edx, memd[ds, esi + 12]);           /* mov edx, [esi+0xc] */
            ii(0x1016_7991, 3); mov(ecx, memd[ds, esi + 24]);           /* mov ecx, [esi+0x18] */
            ii(0x1016_7994, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_7996, 3); imul(ecx, eax);                         /* imul ecx, eax */
            ii(0x1016_7999, 2); mov(eax, memd[ds, ebx]);                /* mov eax, [ebx] */
            ii(0x1016_799b, 3); mov(ebx, memd[ds, esi + 8]);            /* mov ebx, [esi+0x8] */
            ii(0x1016_799e, 3); mov(edx, memd[ds, esi + 44]);           /* mov edx, [esi+0x2c] */
            ii(0x1016_79a1, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1016_79a3, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_79a5, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1016_79a7, 1); push(eax);                              /* push eax */
            ii(0x1016_79a8, 3); call_abs(memd[ds, esi + 64]);           /* call dword [esi+0x40] */
            ii(0x1016_79ab, 2); jmp(0x1016_7a03, 0x56); goto l_0x1016_7a03; /* jmp 0x10167a03 */
        l_0x1016_79ad:
            ii(0x1016_79ad, 3); mov(eax, memd[ds, ebx + 4]);            /* mov eax, [ebx+0x4] */
            ii(0x1016_79b0, 3); mov(edx, memd[ss, ebp + 4]);            /* mov edx, [ebp+0x4] */
            ii(0x1016_79b3, 4); mov(ecx, memd[ss, esp + 36]);           /* mov ecx, [esp+0x24] */
            ii(0x1016_79b7, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_79b9, 3); imul(eax, ecx);                         /* imul eax, ecx */
            ii(0x1016_79bc, 1); push(ecx);                              /* push ecx */
            ii(0x1016_79bd, 4); mov(edx, memd[ss, esp + 44]);           /* mov edx, [esp+0x2c] */
            ii(0x1016_79c1, 3); mov(ecx, memd[ss, ebp]);                /* mov ecx, [ebp] */
            ii(0x1016_79c4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_79c6, 2); mov(eax, memd[ds, ebx]);                /* mov eax, [ebx] */
            ii(0x1016_79c8, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_79ca, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_79cc, 1); push(eax);                              /* push eax */
            ii(0x1016_79cd, 3); mov(eax, memd[ds, esi + 24]);           /* mov eax, [esi+0x18] */
            ii(0x1016_79d0, 3); mov(edx, memd[ds, ebx + 4]);            /* mov edx, [ebx+0x4] */
            ii(0x1016_79d3, 1); push(eax);                              /* push eax */
            ii(0x1016_79d4, 3); mov(eax, memd[ds, ebx + 12]);           /* mov eax, [ebx+0xc] */
            ii(0x1016_79d7, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_79d9, 1); inc(eax);                               /* inc eax */
            ii(0x1016_79da, 2); mov(ecx, memd[ds, ebx]);                /* mov ecx, [ebx] */
            ii(0x1016_79dc, 1); push(eax);                              /* push eax */
            ii(0x1016_79dd, 3); mov(eax, memd[ds, ebx + 8]);            /* mov eax, [ebx+0x8] */
            ii(0x1016_79e0, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_79e2, 1); inc(eax);                               /* inc eax */
            ii(0x1016_79e3, 1); push(eax);                              /* push eax */
            ii(0x1016_79e4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_79e6, 3); sub(eax, memd[ds, esi + 12]);           /* sub eax, [esi+0xc] */
            ii(0x1016_79e9, 3); mov(edx, memd[ds, esi + 24]);           /* mov edx, [esi+0x18] */
            ii(0x1016_79ec, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1016_79ef, 3); mov(ebx, memd[ds, esi + 8]);            /* mov ebx, [esi+0x8] */
            ii(0x1016_79f2, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_79f4, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1016_79f6, 3); mov(ebx, memd[ds, esi + 44]);           /* mov ebx, [esi+0x2c] */
            ii(0x1016_79f9, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1016_79fb, 2); add(eax, edx);                          /* add eax, edx */
        l_0x1016_79fd:
            ii(0x1016_79fd, 1); push(eax);                              /* push eax */
            ii(0x1016_79fe, 5); call(/* sys */ 0x1016_abbc, 0x31b9);    /* call 0x1016abbc */
        l_0x1016_7a03:
            ii(0x1016_7a03, 3); add(esp, 0x18);                         /* add esp, 0x18 */
        l_0x1016_7a06:
            ii(0x1016_7a06, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1016_7a08, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1016_7a0a, 6); if(jnz(0x1016_7828, -0x1e8)) goto l_0x1016_7828; /* jnz 0x10167828 */
        l_0x1016_7a10:
            ii(0x1016_7a10, 4); mov(ebx, memd[ss, esp + 16]);           /* mov ebx, [esp+0x10] */
            ii(0x1016_7a14, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_7a16, 2); if(jz(0x1016_7a82, 0x6a)) goto l_0x1016_7a82; /* jz 0x10167a82 */
        l_0x1016_7a18:
            ii(0x1016_7a18, 6); mov(ecx, memd[ds, 0x101c_b2c4]);        /* mov ecx, [0x101cb2c4] */
            ii(0x1016_7a1e, 3); mov(edi, memd[ds, ebx + 16]);           /* mov edi, [ebx+0x10] */
            ii(0x1016_7a21, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_7a23, 2); if(jz(0x1016_7a75, 0x50)) goto l_0x1016_7a75; /* jz 0x10167a75 */
            ii(0x1016_7a25, 5); cmp(memd[ss, esp + 40], 0);             /* cmp dword [esp+0x28], 0x0 */
            ii(0x1016_7a2a, 2); if(jnz(0x1016_7a75, 0x49)) goto l_0x1016_7a75; /* jnz 0x10167a75 */
            ii(0x1016_7a2c, 3); mov(eax, memd[ds, ebx + 4]);            /* mov eax, [ebx+0x4] */
            ii(0x1016_7a2f, 3); mov(ecx, memd[ds, ebx + 4]);            /* mov ecx, [ebx+0x4] */
            ii(0x1016_7a32, 1); push(eax);                              /* push eax */
            ii(0x1016_7a33, 3); mov(eax, memd[ds, ebx + 12]);           /* mov eax, [ebx+0xc] */
            ii(0x1016_7a36, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_7a38, 3); lea(esi, memd[ds, eax + 1]);            /* lea esi, [eax+0x1] */
            ii(0x1016_7a3b, 2); mov(edx, memd[ds, ebx]);                /* mov edx, [ebx] */
            ii(0x1016_7a3d, 3); mov(eax, memd[ds, ebx + 8]);            /* mov eax, [ebx+0x8] */
            ii(0x1016_7a40, 1); push(edx);                              /* push edx */
            ii(0x1016_7a41, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_7a43, 1); push(esi);                              /* push esi */
            ii(0x1016_7a44, 1); inc(eax);                               /* inc eax */
            ii(0x1016_7a45, 6); mov(ecx, memd[ds, 0x1020_88e0]);        /* mov ecx, [0x102088e0] */
            ii(0x1016_7a4b, 1); push(eax);                              /* push eax */
            ii(0x1016_7a4c, 5); mov(eax, memd[ds, 0x1020_88e8]);        /* mov eax, [0x102088e8] */
            ii(0x1016_7a51, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_7a53, 3); mov(edx, memd[ds, ebx + 4]);            /* mov edx, [ebx+0x4] */
            ii(0x1016_7a56, 1); inc(eax);                               /* inc eax */
            ii(0x1016_7a57, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1016_7a5a, 2); push(0);                                /* push 0x0 */
            ii(0x1016_7a5c, 2); push(0);                                /* push 0x0 */
            ii(0x1016_7a5e, 1); push(esi);                              /* push esi */
            ii(0x1016_7a5f, 1); push(eax);                              /* push eax */
            ii(0x1016_7a60, 2); mov(esi, memd[ds, ebx]);                /* mov esi, [ebx] */
            ii(0x1016_7a62, 5); mov(eax, memd[ds, 0x101b_ddd8]);        /* mov eax, [0x101bddd8] */
            ii(0x1016_7a67, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1016_7a69, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_7a6b, 1); push(eax);                              /* push eax */
            ii(0x1016_7a6c, 6); call_abs(memd[ds, 0x1020_892c]);        /* call dword [0x1020892c] */
            ii(0x1016_7a72, 3); add(esp, 0x24);                         /* add esp, 0x24 */
        l_0x1016_7a75:
            ii(0x1016_7a75, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_7a77, 5); call(/* sys */ 0x1018_5f28, 0x1_e4ac);  /* call 0x10185f28 */
            ii(0x1016_7a7c, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1016_7a7e, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1016_7a80, 2); if(jnz(0x1016_7a18, -0x6a)) goto l_0x1016_7a18; /* jnz 0x10167a18 */
        l_0x1016_7a82:
            ii(0x1016_7a82, 7); cmp(memd[ds, 0x101c_b2d0], 0);          /* cmp dword [0x101cb2d0], 0x0 */
            ii(0x1016_7a89, 2); if(jnz(0x1016_7ab5, 0x2a)) goto l_0x1016_7ab5; /* jnz 0x10167ab5 */
            ii(0x1016_7a8b, 5); cmp(memd[ss, esp + 40], 0);             /* cmp dword [esp+0x28], 0x0 */
            ii(0x1016_7a90, 2); if(jnz(0x1016_7ab5, 0x23)) goto l_0x1016_7ab5; /* jnz 0x10167ab5 */
            ii(0x1016_7a92, 5); call(/* sys */ 0x1016_c350, 0x48b9);    /* call 0x1016c350 */
            ii(0x1016_7a97, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_7a99, 2); if(jnz(0x1016_7ab5, 0x1a)) goto l_0x1016_7ab5; /* jnz 0x10167ab5 */
            ii(0x1016_7a9b, 3); mov(ecx, memd[ss, ebp + 12]);           /* mov ecx, [ebp+0xc] */
            ii(0x1016_7a9e, 3); mov(ebx, memd[ss, ebp + 8]);            /* mov ebx, [ebp+0x8] */
            ii(0x1016_7aa1, 3); mov(edx, memd[ss, ebp + 4]);            /* mov edx, [ebp+0x4] */
            ii(0x1016_7aa4, 3); mov(eax, memd[ss, ebp]);                /* mov eax, [ebp] */
            ii(0x1016_7aa7, 5); call(/* sys */ 0x1016_c184, 0x46d8);    /* call 0x1016c184 */
            ii(0x1016_7aac, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_7aae, 2); if(jz(0x1016_7ab5, 5)) goto l_0x1016_7ab5; /* jz 0x10167ab5 */
            ii(0x1016_7ab0, 5); call(/* sys */ 0x1016_bcc4, 0x420f);    /* call 0x1016bcc4 */
        l_0x1016_7ab5:
            ii(0x1016_7ab5, 3); add(esp, 0x34);                         /* add esp, 0x34 */
            ii(0x1016_7ab8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_7ab9, 1); pop(edi);                               /* pop edi */
            ii(0x1016_7aba, 1); pop(esi);                               /* pop esi */
            ii(0x1016_7abb, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_7abc, 1); ret();                                  /* ret */
        }
    }
}
