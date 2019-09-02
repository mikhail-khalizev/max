using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9a00-890461f4")]
        public void /* sys */ Method_1017_9a00()
        {
            ii(0x1017_9a00, 1); push(ebp);                              /* push ebp */
            ii(0x1017_9a01, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_9a03, 1); push(ebx);                              /* push ebx */
            ii(0x1017_9a04, 1); push(ecx);                              /* push ecx */
            ii(0x1017_9a05, 1); push(esi);                              /* push esi */
            ii(0x1017_9a06, 1); push(edi);                              /* push edi */
            ii(0x1017_9a07, 6); sub(esp, 0x88);                         /* sub esp, 0x88 */
            ii(0x1017_9a0d, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_9a0f, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1017_9a11, 7); lea(edx, memd[ds, eax * 4]);            /* lea edx, [eax*4] */
            ii(0x1017_9a18, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1017_9a1a, 7); lea(eax, memd[ds, edi * 4]);            /* lea eax, [edi*4] */
            ii(0x1017_9a21, 2); sub(eax, edi);                          /* sub eax, edi */
            ii(0x1017_9a23, 3); shl(edx, 6);                            /* shl edx, 0x6 */
            ii(0x1017_9a26, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1017_9a28, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1017_9a2a, 7); lgs(eax, memd[ds, edx + 0x1020_b718]);  /* lgs eax, [edx+0x1020b718] */
            ii(0x1017_9a31, 5); mov(ax, memw[gs, eax + 0x30]);          /* mov ax, [gs:eax+0x30] */
            ii(0x1017_9a36, 4); mov(memw[ss, ebp - 0x14], ax);          /* mov [ebp-0x14], ax */
            ii(0x1017_9a3a, 1); cwde();                                 /* cwde */
            ii(0x1017_9a3b, 3); test(ah, 0x80);                         /* test ah, 0x80 */
            ii(0x1017_9a3e, 2); if(jnz(0x1017_9a47, 7)) goto l_0x1017_9a47; /* jnz 0x10179a47 */
            ii(0x1017_9a40, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_9a42, 5); jmp(0x1017_9b6f, 0x128); goto l_0x1017_9b6f; /* jmp 0x10179b6f */
        l_0x1017_9a47:
            ii(0x1017_9a47, 6); lea(ebx, memd[ss, ebp - 0x98]);         /* lea ebx, [ebp-0x98] */
            ii(0x1017_9a4d, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_9a4f, 2); mov(ecx, ds);                           /* mov ecx, ds */
            ii(0x1017_9a51, 5); call(/* sys */ 0x1019_45bc, 0x1_ab66);  /* call 0x101945bc */
            ii(0x1017_9a56, 7); mov(eax, memd[ds, esi * 4 + 0x101c_0300]); /* mov eax, [esi*4+0x101c0300] */
            ii(0x1017_9a5d, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1017_9a60, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_9a62, 6); mov(al, memb[ds, esi + 0x101c_068c]);   /* mov al, [esi+0x101c068c] */
            ii(0x1017_9a68, 7); mov(eax, memd[ds, eax * 4 + 0x101c_066c]); /* mov eax, [eax*4+0x101c066c] */
            ii(0x1017_9a6f, 1); cli();                                  /* cli */
            ii(0x1017_9a70, 6); mov(gs, memw[ds, edx + 0x1020_b71c]);   /* mov gs, [edx+0x1020b71c] */
            ii(0x1017_9a76, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1017_9a79, 6); mov(eax, memd[ds, edx + 0x1020_b718]);  /* mov eax, [edx+0x1020b718] */
            ii(0x1017_9a7f, 4); mov(edx, memd[gs, eax + 0x4c]);         /* mov edx, [gs:eax+0x4c] */
            ii(0x1017_9a83, 3); mov(memd[ss, ebp - 0x24], edx);         /* mov [ebp-0x24], edx */
            ii(0x1017_9a86, 3); mov(edx, memd[ss, ebp - 0x2c]);         /* mov edx, [ebp-0x2c] */
            ii(0x1017_9a89, 5); movsx(eax, memw[gs, eax + 0x3a]);       /* movsx eax, word [gs:eax+0x3a] */
            ii(0x1017_9a8e, 1); push(edx);                              /* push edx */
            ii(0x1017_9a8f, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1017_9a92, 5); call(/* sys */ 0x1018_dd5b, 0x1_42c4);  /* call 0x1018dd5b */
            ii(0x1017_9a97, 3); add(esp, 4);                            /* add esp, 0x4 */
            ii(0x1017_9a9a, 3); mov(ebx, memd[ss, ebp - 0x2c]);         /* mov ebx, [ebp-0x2c] */
            ii(0x1017_9a9d, 1); push(ebx);                              /* push ebx */
            ii(0x1017_9a9e, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1017_9aa1, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1017_9aa4, 5); call(/* sys */ 0x1018_dd5b, 0x1_42b2);  /* call 0x1018dd5b */
            ii(0x1017_9aa9, 3); mov(ecx, memd[ss, ebp - 0x28]);         /* mov ecx, [ebp-0x28] */
            ii(0x1017_9aac, 3); add(esp, 4);                            /* add esp, 0x4 */
            ii(0x1017_9aaf, 2); cmp(eax, ecx);                          /* cmp eax, ecx */
            ii(0x1017_9ab1, 2); if(jbe(0x1017_9ab6, 3)) goto l_0x1017_9ab6; /* jbe 0x10179ab6 */
            ii(0x1017_9ab3, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
        l_0x1017_9ab6:
            ii(0x1017_9ab6, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1017_9ab9, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x1017_9abc, 3); mov(ebx, memd[ss, ebp - 0x20]);         /* mov ebx, [ebp-0x20] */
            ii(0x1017_9abf, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1017_9ac1, 1); sti();                                  /* sti */
            ii(0x1017_9ac2, 1); cld();                                  /* cld */
            ii(0x1017_9ac3, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1017_9ac5, 2); if(ja(0x1017_9acb, 4)) goto l_0x1017_9acb; /* ja 0x10179acb */
            ii(0x1017_9ac7, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1017_9ac9, 2); jmp(0x1017_9ad1, 6); goto l_0x1017_9ad1; /* jmp 0x10179ad1 */
        l_0x1017_9acb:
            ii(0x1017_9acb, 3); mov(ecx, memd[ss, ebp - 0x18]);         /* mov ecx, [ebp-0x18] */
            ii(0x1017_9ace, 3); lea(edx, memd[ds, ebx + ecx]);          /* lea edx, [ebx+ecx] */
        l_0x1017_9ad1:
            ii(0x1017_9ad1, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1017_9ad3, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_9ad5, 4); test(memb[ss, ebp - 0x13], 4);          /* test byte [ebp-0x13], 0x4 */
            ii(0x1017_9ad9, 2); if(jz(0x1017_9b00, 0x25)) goto l_0x1017_9b00; /* jz 0x10179b00 */
            ii(0x1017_9adb, 7); lea(ebx, memd[ds, esi * 4]);            /* lea ebx, [esi*4] */
            ii(0x1017_9ae2, 7); lea(edx, memd[ds, edi * 4]);            /* lea edx, [edi*4] */
            ii(0x1017_9ae9, 2); sub(ebx, esi);                          /* sub ebx, esi */
            ii(0x1017_9aeb, 2); sub(edx, edi);                          /* sub edx, edi */
            ii(0x1017_9aed, 3); shl(ebx, 6);                            /* shl ebx, 0x6 */
            ii(0x1017_9af0, 8); lgs(edx, memd[ds, ebx + edx * 2 + 0x1020_b718]); /* lgs edx, [ebx+edx*2+0x1020b718] */
            ii(0x1017_9af8, 5); imul(eax, memd[gs, edx + 0x44]);        /* imul eax, [gs:edx+0x44] */
            ii(0x1017_9afd, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
        l_0x1017_9b00:
            ii(0x1017_9b00, 4); test(memb[ss, ebp - 0x14], 0x80);       /* test byte [ebp-0x14], 0x80 */
            ii(0x1017_9b04, 2); if(jz(0x1017_9b0e, 8)) goto l_0x1017_9b0e; /* jz 0x10179b0e */
            ii(0x1017_9b06, 4); cmp(memd[ss, ebp - 0x74], 8);           /* cmp dword [ebp-0x74], 0x8 */
            ii(0x1017_9b0a, 2); if(jnz(0x1017_9b0e, 2)) goto l_0x1017_9b0e; /* jnz 0x10179b0e */
            ii(0x1017_9b0c, 2); add(eax, eax);                          /* add eax, eax */
        l_0x1017_9b0e:
            ii(0x1017_9b0e, 4); test(memb[ss, ebp - 0x14], 0x20);       /* test byte [ebp-0x14], 0x20 */
            ii(0x1017_9b12, 2); if(jz(0x1017_9b1c, 8)) goto l_0x1017_9b1c; /* jz 0x10179b1c */
            ii(0x1017_9b14, 4); cmp(memd[ss, ebp - 0x74], 0x10);        /* cmp dword [ebp-0x74], 0x10 */
            ii(0x1017_9b18, 2); if(jnz(0x1017_9b1c, 2)) goto l_0x1017_9b1c; /* jnz 0x10179b1c */
            ii(0x1017_9b1a, 2); shr(eax, 1);                            /* shr eax, 1 */
        l_0x1017_9b1c:
            ii(0x1017_9b1c, 4); test(memb[ss, ebp - 0x14], 0x10);       /* test byte [ebp-0x14], 0x10 */
            ii(0x1017_9b20, 2); if(jz(0x1017_9b2a, 8)) goto l_0x1017_9b2a; /* jz 0x10179b2a */
            ii(0x1017_9b22, 4); cmp(memd[ss, ebp - 0x70], 0);           /* cmp dword [ebp-0x70], 0x0 */
            ii(0x1017_9b26, 2); if(jnz(0x1017_9b2a, 2)) goto l_0x1017_9b2a; /* jnz 0x10179b2a */
            ii(0x1017_9b28, 2); add(eax, eax);                          /* add eax, eax */
        l_0x1017_9b2a:
            ii(0x1017_9b2a, 7); lea(edx, memd[ds, esi * 4]);            /* lea edx, [esi*4] */
            ii(0x1017_9b31, 2); sub(edx, esi);                          /* sub edx, esi */
            ii(0x1017_9b33, 7); lea(esi, memd[ds, edi * 4]);            /* lea esi, [edi*4] */
            ii(0x1017_9b3a, 3); shl(edx, 6);                            /* shl edx, 0x6 */
            ii(0x1017_9b3d, 2); sub(esi, edi);                          /* sub esi, edi */
            ii(0x1017_9b3f, 8); lgs(edx, memd[ds, edx + esi * 2 + 0x1020_b718]); /* lgs edx, [edx+esi*2+0x1020b718] */
            ii(0x1017_9b47, 6); cmp(memw[gs, edx + 0x36], 3);           /* cmp word [gs:edx+0x36], 0x3 */
            ii(0x1017_9b4d, 2); if(jz(0x1017_9b57, 8)) goto l_0x1017_9b57; /* jz 0x10179b57 */
            ii(0x1017_9b4f, 4); cmp(memd[ss, ebp - 0x70], 0);           /* cmp dword [ebp-0x70], 0x0 */
            ii(0x1017_9b53, 2); if(jz(0x1017_9b57, 2)) goto l_0x1017_9b57; /* jz 0x10179b57 */
            ii(0x1017_9b55, 2); shr(eax, 1);                            /* shr eax, 1 */
        l_0x1017_9b57:
            ii(0x1017_9b57, 3); mov(esi, memd[ss, ebp - 0x24]);         /* mov esi, [ebp-0x24] */
            ii(0x1017_9b5a, 2); cmp(eax, esi);                          /* cmp eax, esi */
            ii(0x1017_9b5c, 2); if(jbe(0x1017_9b69, 0xb)) goto l_0x1017_9b69; /* jbe 0x10179b69 */
            ii(0x1017_9b5e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_9b60, 3); lea(esp, memd[ss, ebp - 0x10]);         /* lea esp, [ebp-0x10] */
            ii(0x1017_9b63, 1); pop(edi);                               /* pop edi */
            ii(0x1017_9b64, 1); pop(esi);                               /* pop esi */
            ii(0x1017_9b65, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_9b66, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_9b67, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_9b68, 1); ret(); return;                          /* ret */
        l_0x1017_9b69:
            ii(0x1017_9b69, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1017_9b6b, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1017_9b6d, 2); mov(eax, edx);                          /* mov eax, edx */
        l_0x1017_9b6f:
            ii(0x1017_9b6f, 3); lea(esp, memd[ss, ebp - 0x10]);         /* lea esp, [ebp-0x10] */
            ii(0x1017_9b72, 1); pop(edi);                               /* pop edi */
            ii(0x1017_9b73, 1); pop(esi);                               /* pop esi */
            ii(0x1017_9b74, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_9b75, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_9b76, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_9b77, 1); ret();                                  /* ret */
        }
    }
}
