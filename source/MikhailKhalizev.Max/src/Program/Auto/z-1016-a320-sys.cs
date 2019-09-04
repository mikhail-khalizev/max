using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_a320-d2144e49")]
        public void /* sys */ Method_1016_a320()
        {
            ii(0x1016_a320, 1); push(esi);                              /* push esi */
            ii(0x1016_a321, 1); push(edi);                              /* push edi */
            ii(0x1016_a322, 1); push(ebp);                              /* push ebp */
            ii(0x1016_a323, 3); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1016_a326, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_a328, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1016_a32a, 4); mov(memd[ss, esp + 12], ebx);           /* mov [esp+0xc], ebx */
            ii(0x1016_a32e, 4); mov(memd[ss, esp + 16], ecx);           /* mov [esp+0x10], ecx */
            ii(0x1016_a332, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
            ii(0x1016_a335, 4); mov(ah, memb[ss, esp + 54]);            /* mov ah, [esp+0x36] */
            ii(0x1016_a339, 3); test(ah, 1);                            /* test ah, 0x1 */
            ii(0x1016_a33c, 2); if(jz(0x1016_a36b, 0x2d)) goto l_0x1016_a36b; /* jz 0x1016a36b */
            ii(0x1016_a33e, 4); mov(edx, memd[ss, esp + 52]);           /* mov edx, [esp+0x34] */
            ii(0x1016_a342, 2); mov(bl, ah);                            /* mov bl, ah */
            ii(0x1016_a344, 6); and(edx, 0xfffe_ff00);                  /* and edx, 0xfffeff00 */
            ii(0x1016_a34a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_a34c, 3); and(bl, 0xfe);                          /* and bl, 0xfe */
            ii(0x1016_a34f, 5); mov(al, memb[ds, 0x1020_0520]);         /* mov al, [0x10200520] */
            ii(0x1016_a354, 4); mov(memb[ss, esp + 54], bl);            /* mov [esp+0x36], bl */
            ii(0x1016_a358, 2); or(eax, edx);                           /* or eax, edx */
            ii(0x1016_a35a, 4); mov(ebx, memd[ss, esp + 12]);           /* mov ebx, [esp+0xc] */
            ii(0x1016_a35e, 1); push(eax);                              /* push eax */
            ii(0x1016_a35f, 3); lea(eax, memd[ds, ecx + esi]);          /* lea eax, [ecx+esi] */
            ii(0x1016_a362, 2); mov(edx, edi);                          /* mov edx, edi */
            ii(0x1016_a364, 1); inc(eax);                               /* inc eax */
            ii(0x1016_a365, 6); call_abs(memd[ds, 0x101b_ddec]);        /* call dword [0x101bddec] */ /* Вызов '0x1016_a320'. */
        l_0x1016_a36b:
            ii(0x1016_a36b, 4); mov(al, memb[ss, esp + 52]);            /* mov al, [esp+0x34] */
            ii(0x1016_a36f, 4); mov(bh, memb[ss, esp + 54]);            /* mov bh, [esp+0x36] */
            ii(0x1016_a373, 4); mov(memb[ss, esp + 32], al);            /* mov [esp+0x20], al */
            ii(0x1016_a377, 3); test(bh, 4);                            /* test bh, 0x4 */
            ii(0x1016_a37a, 2); if(jz(0x1016_a386, 0xa)) goto l_0x1016_a386; /* jz 0x1016a386 */
            ii(0x1016_a37c, 6); call_abs(memd[ds, 0x101b_de08]);        /* call dword [0x101bde08] */ /* Вызов '0x1016_a568'. */
            ii(0x1016_a382, 4); mov(memd[ss, esp + 4], eax);            /* mov [esp+0x4], eax */
        l_0x1016_a386:
            ii(0x1016_a386, 2); mov(cl, memb[ds, edi]);                 /* mov cl, [edi] */
            ii(0x1016_a388, 4); mov(memd[ss, esp + 20], edi);           /* mov [esp+0x14], edi */
            ii(0x1016_a38c, 2); test(cl, cl);                           /* test cl, cl */
            ii(0x1016_a38e, 6); if(jz(0x1016_a486, 0xf2)) goto l_0x1016_a486; /* jz 0x1016a486 */
        l_0x1016_a394:
            ii(0x1016_a394, 4); mov(edx, memd[ss, esp + 20]);           /* mov edx, [esp+0x14] */
            ii(0x1016_a398, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_a39a, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1016_a39c, 6); mov(edx, memd[ds, 0x101c_f964]);        /* mov edx, [0x101cf964] */
            ii(0x1016_a3a2, 2); cmp(eax, memd[ds, edx]);                /* cmp eax, [edx] */
            ii(0x1016_a3a4, 6); if(jge(0x1016_a473, 0xc9)) goto l_0x1016_a473; /* jge 0x1016a473 */
            ii(0x1016_a3aa, 3); mov(ebp, memd[ds, edx + 12]);           /* mov ebp, [edx+0xc] */
            ii(0x1016_a3ad, 4); mov(ebp, memd[ss, ebp + eax * 8]);      /* mov ebp, [ebp+eax*8] */
            ii(0x1016_a3b1, 5); test(memb[ss, esp + 54], 4);            /* test byte [esp+0x36], 0x4 */
            ii(0x1016_a3b6, 2); if(jz(0x1016_a3dc, 0x24)) goto l_0x1016_a3dc; /* jz 0x1016a3dc */
            ii(0x1016_a3b8, 4); mov(eax, memd[ss, esp + 4]);            /* mov eax, [esp+0x4] */
            ii(0x1016_a3bc, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1016_a3be, 4); mov(memd[ss, esp + 8], eax);            /* mov [esp+0x8], eax */
            ii(0x1016_a3c2, 4); mov(eax, memd[ss, esp + 4]);            /* mov eax, [esp+0x4] */
            ii(0x1016_a3c6, 3); mov(ecx, memd[ds, edx + 8]);            /* mov ecx, [edx+0x8] */
            ii(0x1016_a3c9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_a3cb, 2); sub(edx, ecx);                          /* sub edx, ecx */
            ii(0x1016_a3cd, 2); sub(edx, ebp);                          /* sub edx, ebp */
            ii(0x1016_a3cf, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_a3d1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1016_a3d4, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1016_a3d6, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1016_a3d8, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1016_a3da, 2); jmp(0x1016_a3e8, 0xc); goto l_0x1016_a3e8; /* jmp 0x1016a3e8 */
        l_0x1016_a3dc:
            ii(0x1016_a3dc, 3); mov(edx, memd[ds, edx + 8]);            /* mov edx, [edx+0x8] */
            ii(0x1016_a3df, 3); lea(eax, memd[ds, esi + ebp]);          /* lea eax, [esi+ebp] */
            ii(0x1016_a3e2, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_a3e4, 4); mov(memd[ss, esp + 8], edx);            /* mov [esp+0x8], edx */
        l_0x1016_a3e8:
            ii(0x1016_a3e8, 4); mov(eax, memd[ss, esp + 8]);            /* mov eax, [esp+0x8] */
            ii(0x1016_a3ec, 3); mov(edi, memd[ss, esp]);                /* mov edi, [esp] */
            ii(0x1016_a3ef, 4); mov(edx, memd[ss, esp + 12]);           /* mov edx, [esp+0xc] */
            ii(0x1016_a3f3, 2); sub(eax, edi);                          /* sub eax, edi */
            ii(0x1016_a3f5, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1016_a3f7, 6); if(jg(0x1016_a486, 0x89)) goto l_0x1016_a486; /* jg 0x1016a486 */
            ii(0x1016_a3fd, 4); mov(eax, memd[ss, esp + 20]);           /* mov eax, [esp+0x14] */
            ii(0x1016_a401, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_a403, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1016_a405, 5); mov(eax, memd[ds, 0x101c_f964]);        /* mov eax, [0x101cf964] */
            ii(0x1016_a40a, 3); mov(ebx, memd[ds, eax + 12]);           /* mov ebx, [eax+0xc] */
            ii(0x1016_a40d, 3); mov(eax, memd[ds, eax + 16]);           /* mov eax, [eax+0x10] */
            ii(0x1016_a410, 4); mov(edx, memd[ds, ebx + edx * 8 + 4]);  /* mov edx, [ebx+edx*8+0x4] */
            ii(0x1016_a414, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1016_a416, 4); mov(eax, memd[ss, esp + 16]);           /* mov eax, [esp+0x10] */
            ii(0x1016_a41a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_a41c, 2); sub(eax, ebp);                          /* sub eax, ebp */
            ii(0x1016_a41e, 4); mov(memd[ss, esp + 28], ebx);           /* mov [esp+0x1c], ebx */
            ii(0x1016_a422, 4); mov(memd[ss, esp + 24], eax);           /* mov [esp+0x18], eax */
            ii(0x1016_a426, 2); jmp(0x1016_a460, 0x38); goto l_0x1016_a460; /* jmp 0x1016a460 */
        l_0x1016_a428:
            ii(0x1016_a428, 2); mov(al, 0x80);                          /* mov al, 0x80 */
            ii(0x1016_a42a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_a42c, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1016_a42e, 2); if(jle(0x1016_a450, 0x20)) goto l_0x1016_a450; /* jle 0x1016a450 */
            ii(0x1016_a430, 4); mov(ah, memb[ss, esp + 32]);            /* mov ah, [esp+0x20] */
        l_0x1016_a434:
            ii(0x1016_a434, 2); test(al, al);                           /* test al, al */
            ii(0x1016_a436, 2); if(jnz(0x1016_a43b, 3)) goto l_0x1016_a43b; /* jnz 0x1016a43b */
            ii(0x1016_a438, 2); mov(al, 0x80);                          /* mov al, 0x80 */
            ii(0x1016_a43a, 1); inc(edx);                               /* inc edx */
        l_0x1016_a43b:
            ii(0x1016_a43b, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_a43d, 3); movzx(edi, memb[ds, edx]);              /* movzx edi, byte [edx] */
            ii(0x1016_a440, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_a442, 2); test(edi, ecx);                         /* test edi, ecx */
            ii(0x1016_a444, 2); if(jz(0x1016_a448, 2)) goto l_0x1016_a448; /* jz 0x1016a448 */
            ii(0x1016_a446, 2); mov(memb[ds, esi], ah);                 /* mov [esi], ah */
        l_0x1016_a448:
            ii(0x1016_a448, 2); shr(al, 1);                             /* shr al, 1 */
            ii(0x1016_a44a, 1); inc(ebx);                               /* inc ebx */
            ii(0x1016_a44b, 1); inc(esi);                               /* inc esi */
            ii(0x1016_a44c, 2); cmp(ebx, ebp);                          /* cmp ebx, ebp */
            ii(0x1016_a44e, 2); if(jl(0x1016_a434, -0x1c)) goto l_0x1016_a434; /* jl 0x1016a434 */
        l_0x1016_a450:
            ii(0x1016_a450, 4); mov(eax, memd[ss, esp + 24]);           /* mov eax, [esp+0x18] */
            ii(0x1016_a454, 4); mov(ebx, memd[ss, esp + 28]);           /* mov ebx, [esp+0x1c] */
            ii(0x1016_a458, 1); inc(edx);                               /* inc edx */
            ii(0x1016_a459, 1); inc(ebx);                               /* inc ebx */
            ii(0x1016_a45a, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1016_a45c, 4); mov(memd[ss, esp + 28], ebx);           /* mov [esp+0x1c], ebx */
        l_0x1016_a460:
            ii(0x1016_a460, 6); mov(ebx, memd[ds, 0x101c_f964]);        /* mov ebx, [0x101cf964] */
            ii(0x1016_a466, 4); mov(eax, memd[ss, esp + 28]);           /* mov eax, [esp+0x1c] */
            ii(0x1016_a46a, 3); cmp(eax, memd[ds, ebx + 4]);            /* cmp eax, [ebx+0x4] */
            ii(0x1016_a46d, 2); if(jl(0x1016_a428, -0x47)) goto l_0x1016_a428; /* jl 0x1016a428 */
            ii(0x1016_a46f, 4); mov(esi, memd[ss, esp + 8]);            /* mov esi, [esp+0x8] */
        l_0x1016_a473:
            ii(0x1016_a473, 4); mov(edx, memd[ss, esp + 20]);           /* mov edx, [esp+0x14] */
            ii(0x1016_a477, 1); inc(edx);                               /* inc edx */
            ii(0x1016_a478, 2); mov(ch, memb[ds, edx]);                 /* mov ch, [edx] */
            ii(0x1016_a47a, 4); mov(memd[ss, esp + 20], edx);           /* mov [esp+0x14], edx */
            ii(0x1016_a47e, 2); test(ch, ch);                           /* test ch, ch */
            ii(0x1016_a480, 6); if(jnz(0x1016_a394, -0xf2)) goto l_0x1016_a394; /* jnz 0x1016a394 */
        l_0x1016_a486:
            ii(0x1016_a486, 5); test(memb[ss, esp + 54], 2);            /* test byte [esp+0x36], 0x2 */
            ii(0x1016_a48b, 2); if(jz(0x1016_a4bb, 0x2e)) goto l_0x1016_a4bb; /* jz 0x1016a4bb */
            ii(0x1016_a48d, 6); mov(edx, memd[ds, 0x101c_f964]);        /* mov edx, [0x101cf964] */
            ii(0x1016_a493, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_a495, 3); mov(edx, memd[ds, edx + 4]);            /* mov edx, [edx+0x4] */
            ii(0x1016_a498, 4); mov(esi, memd[ss, esp + 16]);           /* mov esi, [esp+0x10] */
            ii(0x1016_a49c, 1); dec(edx);                               /* dec edx */
            ii(0x1016_a49d, 3); imul(edx, esi);                         /* imul edx, esi */
            ii(0x1016_a4a0, 3); mov(ecx, memd[ss, esp]);                /* mov ecx, [esp] */
            ii(0x1016_a4a3, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_a4a5, 3); lea(esi, memd[ds, ecx + edx]);          /* lea esi, [ecx+edx] */
            ii(0x1016_a4a8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_a4aa, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_a4ac, 2); if(jle(0x1016_a4bb, 0xd)) goto l_0x1016_a4bb; /* jle 0x1016a4bb */
            ii(0x1016_a4ae, 4); mov(bl, memb[ss, esp + 32]);            /* mov bl, [esp+0x20] */
        l_0x1016_a4b2:
            ii(0x1016_a4b2, 1); inc(esi);                               /* inc esi */
            ii(0x1016_a4b3, 1); inc(edx);                               /* inc edx */
            ii(0x1016_a4b4, 3); mov(memb[ds, esi - 1], bl);             /* mov [esi-0x1], bl */
            ii(0x1016_a4b7, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1016_a4b9, 2); if(jl(0x1016_a4b2, -9)) goto l_0x1016_a4b2; /* jl 0x1016a4b2 */
        l_0x1016_a4bb:
            ii(0x1016_a4bb, 3); add(esp, 0x24);                         /* add esp, 0x24 */
            ii(0x1016_a4be, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_a4bf, 1); pop(edi);                               /* pop edi */
            ii(0x1016_a4c0, 1); pop(esi);                               /* pop esi */
            ii(0x1016_a4c1, 3); ret(4);                                 /* ret 0x4 */
        }
    }
}
