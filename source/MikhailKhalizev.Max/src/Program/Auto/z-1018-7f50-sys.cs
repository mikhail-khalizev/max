using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_7f50-86cc12d1")]
        public void /* sys */ Method_1018_7f50()
        {
            ii(0x1018_7f50, 1); push(ecx);                              /* push ecx */
            ii(0x1018_7f51, 1); push(esi);                              /* push esi */
            ii(0x1018_7f52, 1); push(edi);                              /* push edi */
            ii(0x1018_7f53, 1); push(ebp);                              /* push ebp */
            ii(0x1018_7f54, 3); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1018_7f57, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
            ii(0x1018_7f5a, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1018_7f5c, 2); mov(edi, ebx);                          /* mov edi, ebx */
            ii(0x1018_7f5e, 5); mov(ebx, 0xfee);                        /* mov ebx, 0xfee */
            ii(0x1018_7f63, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1018_7f68, 5); mov(eax, 0x1020_a6e8);                  /* mov eax, 0x1020a6e8 */
            ii(0x1018_7f6d, 5); call(Definitions.sys_memset, -0x2_2192); /* call 0x10165de0 */
            ii(0x1018_7f72, 5); mov(edx, 0xfee);                        /* mov edx, 0xfee */
            ii(0x1018_7f77, 5); mov(ebx, 0x1020_a2d8);                  /* mov ebx, 0x1020a2d8 */
            ii(0x1018_7f7c, 6); mov(memd[ds, 0x1020_a6dc], edi);        /* mov [0x1020a6dc], edi */
            ii(0x1018_7f82, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_7f88, 6); mov(memd[ds, 0x1020_a6e4], ebx);        /* mov [0x1020a6e4], ebx */
            ii(0x1018_7f8e, 6); mov(memd[ds, 0x1020_a6d8], ebx);        /* mov [0x1020a6d8], ebx */
        l_0x1018_7f94:
            ii(0x1018_7f94, 6); mov(ebx, memd[ds, 0x1020_a6e4]);        /* mov ebx, [0x1020a6e4] */
            ii(0x1018_7f9a, 6); mov(ebp, memd[ds, 0x1020_a6d8]);        /* mov ebp, [0x1020a6d8] */
            ii(0x1018_7fa0, 2); sub(ebx, ebp);                          /* sub ebx, ebp */
            ii(0x1018_7fa2, 3); cmp(edi, 0x10);                         /* cmp edi, 0x10 */
            ii(0x1018_7fa5, 6); if(jbe(0x1018_85fb, 0x650)) goto l_0x1018_85fb; /* jbe 0x101885fb */
            ii(0x1018_7fab, 7); cmp(memd[ds, 0x1020_a6dc], 0);          /* cmp dword [0x1020a6dc], 0x0 */
            ii(0x1018_7fb2, 6); if(jbe(0x1018_805b, 0xa3)) goto l_0x1018_805b; /* jbe 0x1018805b */
            ii(0x1018_7fb8, 3); cmp(ebx, 0x11);                         /* cmp ebx, 0x11 */
            ii(0x1018_7fbb, 6); if(jge(0x1018_805b, 0x9a)) goto l_0x1018_805b; /* jge 0x1018805b */
            ii(0x1018_7fc1, 6); cmp(ebp, memd[ds, 0x1020_a6e4]);        /* cmp ebp, [0x1020a6e4] */
            ii(0x1018_7fc7, 2); if(jz(0x1018_7ffb, 0x32)) goto l_0x1018_7ffb; /* jz 0x10187ffb */
            ii(0x1018_7fc9, 5); mov(eax, 0x1020_a2d8);                  /* mov eax, 0x1020a2d8 */
            ii(0x1018_7fce, 2); mov(edx, ebp);                          /* mov edx, ebp */
            ii(0x1018_7fd0, 5); call(/* sys */ 0x1016_6177, -0x2_1e5e); /* call 0x10166177 */
            ii(0x1018_7fd5, 5); mov(eax, memd[ds, 0x1020_a6e4]);        /* mov eax, [0x1020a6e4] */
            ii(0x1018_7fda, 6); mov(ebp, memd[ds, 0x1020_a6d8]);        /* mov ebp, [0x1020a6d8] */
            ii(0x1018_7fe0, 5); mov(edx, 0x1020_a2d8);                  /* mov edx, 0x1020a2d8 */
            ii(0x1018_7fe5, 2); sub(eax, ebp);                          /* sub eax, ebp */
            ii(0x1018_7fe7, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_7fe9, 5); mov(eax, 0x1020_a2d8);                  /* mov eax, 0x1020a2d8 */
            ii(0x1018_7fee, 6); mov(memd[ds, 0x1020_a6e4], edx);        /* mov [0x1020a6e4], edx */
            ii(0x1018_7ff4, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_7ff9, 2); jmp(0x1018_800c, 0x11); goto l_0x1018_800c; /* jmp 0x1018800c */
        l_0x1018_7ffb:
            ii(0x1018_7ffb, 5); mov(ebx, 0x1020_a2d8);                  /* mov ebx, 0x1020a2d8 */
            ii(0x1018_8000, 6); mov(memd[ds, 0x1020_a6e4], ebx);        /* mov [0x1020a6e4], ebx */
            ii(0x1018_8006, 6); mov(memd[ds, 0x1020_a6d8], ebx);        /* mov [0x1020a6d8], ebx */
        l_0x1018_800c:
            ii(0x1018_800c, 6); mov(ebx, memd[ds, 0x1020_a6e4]);        /* mov ebx, [0x1020a6e4] */
            ii(0x1018_8012, 5); mov(eax, 0x400);                        /* mov eax, 0x400 */
            ii(0x1018_8017, 6); sub(ebx, 0x1020_a2d8);                  /* sub ebx, 0x1020a2d8 */
            ii(0x1018_801d, 3); mov(ecx, memd[ss, esp]);                /* mov ecx, [esp] */
            ii(0x1018_8020, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1018_8022, 6); mov(edx, memd[ds, 0x1020_a6dc]);        /* mov edx, [0x1020a6dc] */
            ii(0x1018_8028, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_802a, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_802c, 2); if(jbe(0x1018_8030, 0x2)) goto l_0x1018_8030; /* jbe 0x10188030 */
            ii(0x1018_802e, 2); mov(ebx, edx);                          /* mov ebx, edx */
        l_0x1018_8030:
            ii(0x1018_8030, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1018_8035, 5); mov(eax, memd[ds, 0x1020_a6e4]);        /* mov eax, [0x1020a6e4] */
            ii(0x1018_803a, 5); call(Definitions.sys_fread, -0x1_5ad3); /* call 0x1017256c */
            ii(0x1018_803f, 6); mov(ebx, memd[ds, 0x1020_a6e4]);        /* mov ebx, [0x1020a6e4] */
            ii(0x1018_8045, 6); mov(ecx, memd[ds, 0x1020_a6dc]);        /* mov ecx, [0x1020a6dc] */
            ii(0x1018_804b, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1018_804d, 2); sub(ecx, eax);                          /* sub ecx, eax */
            ii(0x1018_804f, 6); mov(memd[ds, 0x1020_a6e4], ebx);        /* mov [0x1020a6e4], ebx */
            ii(0x1018_8055, 6); mov(memd[ds, 0x1020_a6dc], ecx);        /* mov [0x1020a6dc], ecx */
        l_0x1018_805b:
            ii(0x1018_805b, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_8060, 1); dec(edi);                               /* dec edi */
            ii(0x1018_8061, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_8063, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8064, 4); mov(memb[ss, esp + 0xc], dl);           /* mov [esp+0xc], dl */
            ii(0x1018_8068, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_806d, 3); test(dl, 0x1);                          /* test dl, 0x1 */
            ii(0x1018_8070, 2); if(jz(0x1018_80a6, 0x34)) goto l_0x1018_80a6; /* jz 0x101880a6 */
            ii(0x1018_8072, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_8074, 1); dec(edi);                               /* dec edi */
            ii(0x1018_8075, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8076, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1018_8078, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8079, 3); mov(memb[ds, esi - 0x1], al);           /* mov [esi-0x1], al */
            ii(0x1018_807c, 5); mov(eax, memd[ds, 0x1020_a6e0]);        /* mov eax, [0x1020a6e0] */
            ii(0x1018_8081, 6); mov(memd[ds, 0x1020_a6d8], edx);        /* mov [0x1020a6d8], edx */
            ii(0x1018_8087, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8088, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_808b, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1018_808d, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_8092, 6); and(ebp, 0xfff);                        /* and ebp, 0xfff */
            ii(0x1018_8098, 6); mov(memb[ds, eax + 0x1020_a6e7], bl);   /* mov [eax+0x1020a6e7], bl */
            ii(0x1018_809e, 6); mov(memd[ds, 0x1020_a6e0], ebp);        /* mov [0x1020a6e0], ebp */
            ii(0x1018_80a4, 2); jmp(0x1018_8112, 0x6c); goto l_0x1018_8112; /* jmp 0x10188112 */
        l_0x1018_80a6:
            ii(0x1018_80a6, 1); inc(eax);                               /* inc eax */
            ii(0x1018_80a7, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_80aa, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_80ac, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_80ae, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_80b3, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_80b5, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_80b8, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_80bb, 1); inc(eax);                               /* inc eax */
            ii(0x1018_80bc, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_80bf, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_80c4, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_80c6, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_80c9, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_80cc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_80ce, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_80d0, 2); jmp(0x1018_810a, 0x38); goto l_0x1018_810a; /* jmp 0x1018810a */
        l_0x1018_80d2:
            ii(0x1018_80d2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_80d4, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_80d7, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_80d9, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_80df, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_80e5, 2); mov(memb[ds, esi], dl);                 /* mov [esi], dl */
            ii(0x1018_80e7, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_80ed, 1); inc(edx);                               /* inc edx */
            ii(0x1018_80ee, 2); mov(bl, memb[ds, esi]);                 /* mov bl, [esi] */
            ii(0x1018_80f0, 1); inc(esi);                               /* inc esi */
            ii(0x1018_80f1, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_80f7, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_80fd, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_8103, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8104, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
        l_0x1018_810a:
            ii(0x1018_810a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_810c, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_810e, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_8110, 2); if(jl(0x1018_80d2, -0x40)) goto l_0x1018_80d2; /* jl 0x101880d2 */
        l_0x1018_8112:
            ii(0x1018_8112, 5); test(memb[ss, esp + 0xc], 0x2);         /* test byte [esp+0xc], 0x2 */
            ii(0x1018_8117, 2); if(jz(0x1018_8151, 0x38)) goto l_0x1018_8151; /* jz 0x10188151 */
            ii(0x1018_8119, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_811e, 1); inc(esi);                               /* inc esi */
            ii(0x1018_811f, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_8121, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_8124, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_812a, 1); dec(edi);                               /* dec edi */
            ii(0x1018_812b, 1); inc(edx);                               /* inc edx */
            ii(0x1018_812c, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_812f, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8130, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_8136, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1018_8138, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_813e, 6); and(ebx, 0xfff);                        /* and ebx, 0xfff */
            ii(0x1018_8144, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8149, 6); mov(memd[ds, 0x1020_a6e0], ebx);        /* mov [0x1020a6e0], ebx */
            ii(0x1018_814f, 2); jmp(0x1018_81c6, 0x75); goto l_0x1018_81c6; /* jmp 0x101881c6 */
        l_0x1018_8151:
            ii(0x1018_8151, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_8156, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8157, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_815a, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_815c, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_815e, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_8161, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8163, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8168, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_816b, 1); inc(eax);                               /* inc eax */
            ii(0x1018_816c, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_816f, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8174, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_8176, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_8179, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_817c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_817e, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_8180, 2); jmp(0x1018_81be, 0x3c); goto l_0x1018_81be; /* jmp 0x101881be */
        l_0x1018_8182:
            ii(0x1018_8182, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8184, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_8187, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_8189, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_818f, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8190, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_8196, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_8199, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_819f, 1); inc(eax);                               /* inc eax */
            ii(0x1018_81a0, 1); inc(edx);                               /* inc edx */
            ii(0x1018_81a1, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_81a4, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1018_81a6, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_81ac, 6); and(ebp, 0xfff);                        /* and ebp, 0xfff */
            ii(0x1018_81b2, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_81b8, 6); mov(memd[ds, 0x1020_a6e0], ebp);        /* mov [0x1020a6e0], ebp */
        l_0x1018_81be:
            ii(0x1018_81be, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_81c0, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_81c2, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_81c4, 2); if(jl(0x1018_8182, -0x44)) goto l_0x1018_8182; /* jl 0x10188182 */
        l_0x1018_81c6:
            ii(0x1018_81c6, 5); test(memb[ss, esp + 0xc], 0x4);         /* test byte [esp+0xc], 0x4 */
            ii(0x1018_81cb, 2); if(jz(0x1018_8201, 0x34)) goto l_0x1018_8201; /* jz 0x10188201 */
            ii(0x1018_81cd, 6); mov(edx, memd[ds, 0x1020_a6d8]);        /* mov edx, [0x1020a6d8] */
            ii(0x1018_81d3, 1); inc(esi);                               /* inc esi */
            ii(0x1018_81d4, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1018_81d6, 3); mov(memb[ds, esi - 0x1], al);           /* mov [esi-0x1], al */
            ii(0x1018_81d9, 5); mov(eax, memd[ds, 0x1020_a6e0]);        /* mov eax, [0x1020a6e0] */
            ii(0x1018_81de, 1); dec(edi);                               /* dec edi */
            ii(0x1018_81df, 1); inc(eax);                               /* inc eax */
            ii(0x1018_81e0, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_81e3, 1); inc(edx);                               /* inc edx */
            ii(0x1018_81e4, 6); mov(memb[ds, eax + 0x1020_a6e7], bl);   /* mov [eax+0x1020a6e7], bl */
            ii(0x1018_81ea, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_81ef, 5); and(eax, 0xfff);                        /* and eax, 0xfff */
            ii(0x1018_81f4, 6); mov(memd[ds, 0x1020_a6d8], edx);        /* mov [0x1020a6d8], edx */
            ii(0x1018_81fa, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_81ff, 2); jmp(0x1018_8272, 0x71); goto l_0x1018_8272; /* jmp 0x10188272 */
        l_0x1018_8201:
            ii(0x1018_8201, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_8206, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8207, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_820a, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_820c, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_820e, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_8211, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8213, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8218, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_821b, 1); inc(eax);                               /* inc eax */
            ii(0x1018_821c, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_821f, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8224, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_8226, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_8229, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_822c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_822e, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_8230, 2); jmp(0x1018_826a, 0x38); goto l_0x1018_826a; /* jmp 0x1018826a */
        l_0x1018_8232:
            ii(0x1018_8232, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8234, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_8237, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_8239, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_823f, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_8245, 2); mov(memb[ds, esi], dl);                 /* mov [esi], dl */
            ii(0x1018_8247, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_824d, 1); inc(edx);                               /* inc edx */
            ii(0x1018_824e, 2); mov(bl, memb[ds, esi]);                 /* mov bl, [esi] */
            ii(0x1018_8250, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8251, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_8257, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_825d, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_8263, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8264, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
        l_0x1018_826a:
            ii(0x1018_826a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_826c, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_826e, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_8270, 2); if(jl(0x1018_8232, -0x40)) goto l_0x1018_8232; /* jl 0x10188232 */
        l_0x1018_8272:
            ii(0x1018_8272, 5); test(memb[ss, esp + 0xc], 0x8);         /* test byte [esp+0xc], 0x8 */
            ii(0x1018_8277, 2); if(jz(0x1018_82b1, 0x38)) goto l_0x1018_82b1; /* jz 0x101882b1 */
            ii(0x1018_8279, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_827e, 1); inc(esi);                               /* inc esi */
            ii(0x1018_827f, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_8281, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_8284, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_828a, 1); dec(edi);                               /* dec edi */
            ii(0x1018_828b, 1); inc(edx);                               /* inc edx */
            ii(0x1018_828c, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_828f, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8290, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_8296, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1018_8298, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_829e, 6); and(ebx, 0xfff);                        /* and ebx, 0xfff */
            ii(0x1018_82a4, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_82a9, 6); mov(memd[ds, 0x1020_a6e0], ebx);        /* mov [0x1020a6e0], ebx */
            ii(0x1018_82af, 2); jmp(0x1018_8326, 0x75); goto l_0x1018_8326; /* jmp 0x10188326 */
        l_0x1018_82b1:
            ii(0x1018_82b1, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_82b6, 1); inc(eax);                               /* inc eax */
            ii(0x1018_82b7, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_82ba, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_82bc, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_82be, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_82c1, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_82c3, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_82c8, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_82cb, 1); inc(eax);                               /* inc eax */
            ii(0x1018_82cc, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_82cf, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_82d4, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_82d6, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_82d9, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_82dc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_82de, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_82e0, 2); jmp(0x1018_831e, 0x3c); goto l_0x1018_831e; /* jmp 0x1018831e */
        l_0x1018_82e2:
            ii(0x1018_82e2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_82e4, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_82e7, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_82e9, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_82ef, 1); inc(esi);                               /* inc esi */
            ii(0x1018_82f0, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_82f6, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_82f9, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_82ff, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8300, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8301, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_8304, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1018_8306, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_830c, 6); and(ebp, 0xfff);                        /* and ebp, 0xfff */
            ii(0x1018_8312, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_8318, 6); mov(memd[ds, 0x1020_a6e0], ebp);        /* mov [0x1020a6e0], ebp */
        l_0x1018_831e:
            ii(0x1018_831e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8320, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8322, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_8324, 2); if(jl(0x1018_82e2, -0x44)) goto l_0x1018_82e2; /* jl 0x101882e2 */
        l_0x1018_8326:
            ii(0x1018_8326, 5); test(memb[ss, esp + 0xc], 0x10);        /* test byte [esp+0xc], 0x10 */
            ii(0x1018_832b, 2); if(jz(0x1018_8361, 0x34)) goto l_0x1018_8361; /* jz 0x10188361 */
            ii(0x1018_832d, 6); mov(edx, memd[ds, 0x1020_a6d8]);        /* mov edx, [0x1020a6d8] */
            ii(0x1018_8333, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8334, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1018_8336, 3); mov(memb[ds, esi - 0x1], al);           /* mov [esi-0x1], al */
            ii(0x1018_8339, 5); mov(eax, memd[ds, 0x1020_a6e0]);        /* mov eax, [0x1020a6e0] */
            ii(0x1018_833e, 1); dec(edi);                               /* dec edi */
            ii(0x1018_833f, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8340, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_8343, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8344, 6); mov(memb[ds, eax + 0x1020_a6e7], bl);   /* mov [eax+0x1020a6e7], bl */
            ii(0x1018_834a, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_834f, 5); and(eax, 0xfff);                        /* and eax, 0xfff */
            ii(0x1018_8354, 6); mov(memd[ds, 0x1020_a6d8], edx);        /* mov [0x1020a6d8], edx */
            ii(0x1018_835a, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_835f, 2); jmp(0x1018_83d2, 0x71); goto l_0x1018_83d2; /* jmp 0x101883d2 */
        l_0x1018_8361:
            ii(0x1018_8361, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_8366, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8367, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_836a, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_836c, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_836e, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_8371, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8373, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8378, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_837b, 1); inc(eax);                               /* inc eax */
            ii(0x1018_837c, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_837f, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8384, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_8386, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_8389, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_838c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_838e, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_8390, 2); jmp(0x1018_83ca, 0x38); goto l_0x1018_83ca; /* jmp 0x101883ca */
        l_0x1018_8392:
            ii(0x1018_8392, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8394, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_8397, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_8399, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_839f, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_83a5, 2); mov(memb[ds, esi], dl);                 /* mov [esi], dl */
            ii(0x1018_83a7, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_83ad, 1); inc(edx);                               /* inc edx */
            ii(0x1018_83ae, 2); mov(bl, memb[ds, esi]);                 /* mov bl, [esi] */
            ii(0x1018_83b0, 1); inc(esi);                               /* inc esi */
            ii(0x1018_83b1, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_83b7, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_83bd, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_83c3, 1); inc(eax);                               /* inc eax */
            ii(0x1018_83c4, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
        l_0x1018_83ca:
            ii(0x1018_83ca, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_83cc, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_83ce, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_83d0, 2); if(jl(0x1018_8392, -0x40)) goto l_0x1018_8392; /* jl 0x10188392 */
        l_0x1018_83d2:
            ii(0x1018_83d2, 5); test(memb[ss, esp + 0xc], 0x20);        /* test byte [esp+0xc], 0x20 */
            ii(0x1018_83d7, 2); if(jz(0x1018_8411, 0x38)) goto l_0x1018_8411; /* jz 0x10188411 */
            ii(0x1018_83d9, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_83de, 1); inc(esi);                               /* inc esi */
            ii(0x1018_83df, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_83e1, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_83e4, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_83ea, 1); dec(edi);                               /* dec edi */
            ii(0x1018_83eb, 1); inc(edx);                               /* inc edx */
            ii(0x1018_83ec, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_83ef, 1); inc(eax);                               /* inc eax */
            ii(0x1018_83f0, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_83f6, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1018_83f8, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_83fe, 6); and(ebx, 0xfff);                        /* and ebx, 0xfff */
            ii(0x1018_8404, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8409, 6); mov(memd[ds, 0x1020_a6e0], ebx);        /* mov [0x1020a6e0], ebx */
            ii(0x1018_840f, 2); jmp(0x1018_8486, 0x75); goto l_0x1018_8486; /* jmp 0x10188486 */
        l_0x1018_8411:
            ii(0x1018_8411, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_8416, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8417, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_841a, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_841c, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_841e, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_8421, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8423, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8428, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_842b, 1); inc(eax);                               /* inc eax */
            ii(0x1018_842c, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_842f, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8434, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_8436, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_8439, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_843c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_843e, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_8440, 2); jmp(0x1018_847e, 0x3c); goto l_0x1018_847e; /* jmp 0x1018847e */
        l_0x1018_8442:
            ii(0x1018_8442, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8444, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_8447, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_8449, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_844f, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8450, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_8456, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_8459, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_845f, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8460, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8461, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_8464, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1018_8466, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_846c, 6); and(ebp, 0xfff);                        /* and ebp, 0xfff */
            ii(0x1018_8472, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_8478, 6); mov(memd[ds, 0x1020_a6e0], ebp);        /* mov [0x1020a6e0], ebp */
        l_0x1018_847e:
            ii(0x1018_847e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8480, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8482, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_8484, 2); if(jl(0x1018_8442, -0x44)) goto l_0x1018_8442; /* jl 0x10188442 */
        l_0x1018_8486:
            ii(0x1018_8486, 5); test(memb[ss, esp + 0xc], 0x40);        /* test byte [esp+0xc], 0x40 */
            ii(0x1018_848b, 2); if(jz(0x1018_84c3, 0x36)) goto l_0x1018_84c3; /* jz 0x101884c3 */
            ii(0x1018_848d, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_8492, 1); dec(edi);                               /* dec edi */
            ii(0x1018_8493, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8494, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_8496, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8497, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_849a, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_84a0, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_84a5, 1); inc(edx);                               /* inc edx */
            ii(0x1018_84a6, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_84a9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_84ab, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_84b1, 5); and(eax, 0xfff);                        /* and eax, 0xfff */
            ii(0x1018_84b6, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_84bc, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_84c1, 2); jmp(0x1018_8534, 0x71); goto l_0x1018_8534; /* jmp 0x10188534 */
        l_0x1018_84c3:
            ii(0x1018_84c3, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_84c8, 1); inc(eax);                               /* inc eax */
            ii(0x1018_84c9, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_84cc, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_84ce, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_84d0, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_84d3, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_84d5, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_84da, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_84dd, 1); inc(eax);                               /* inc eax */
            ii(0x1018_84de, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_84e1, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_84e6, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_84e8, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_84eb, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_84ee, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_84f0, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_84f2, 2); jmp(0x1018_852c, 0x38); goto l_0x1018_852c; /* jmp 0x1018852c */
        l_0x1018_84f4:
            ii(0x1018_84f4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_84f6, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_84f9, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_84fb, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_8501, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_8507, 2); mov(memb[ds, esi], dl);                 /* mov [esi], dl */
            ii(0x1018_8509, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_850f, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8510, 2); mov(bl, memb[ds, esi]);                 /* mov bl, [esi] */
            ii(0x1018_8512, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8513, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_8519, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_851f, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_8525, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8526, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
        l_0x1018_852c:
            ii(0x1018_852c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_852e, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8530, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_8532, 2); if(jl(0x1018_84f4, -0x40)) goto l_0x1018_84f4; /* jl 0x101884f4 */
        l_0x1018_8534:
            ii(0x1018_8534, 5); test(memb[ss, esp + 0xc], 0x80);        /* test byte [esp+0xc], 0x80 */
            ii(0x1018_8539, 2); if(jz(0x1018_8576, 0x3b)) goto l_0x1018_8576; /* jz 0x10188576 */
            ii(0x1018_853b, 6); mov(edx, memd[ds, 0x1020_a6d8]);        /* mov edx, [0x1020a6d8] */
            ii(0x1018_8541, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8542, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1018_8544, 3); mov(memb[ds, esi - 0x1], al);           /* mov [esi-0x1], al */
            ii(0x1018_8547, 5); mov(eax, memd[ds, 0x1020_a6e0]);        /* mov eax, [0x1020a6e0] */
            ii(0x1018_854c, 1); dec(edi);                               /* dec edi */
            ii(0x1018_854d, 1); inc(eax);                               /* inc eax */
            ii(0x1018_854e, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_8551, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8552, 6); mov(memb[ds, eax + 0x1020_a6e7], bl);   /* mov [eax+0x1020a6e7], bl */
            ii(0x1018_8558, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_855a, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_855f, 6); and(ebx, 0xfff);                        /* and ebx, 0xfff */
            ii(0x1018_8565, 6); mov(memd[ds, 0x1020_a6d8], edx);        /* mov [0x1020a6d8], edx */
            ii(0x1018_856b, 6); mov(memd[ds, 0x1020_a6e0], ebx);        /* mov [0x1020a6e0], ebx */
            ii(0x1018_8571, 5); jmp(0x1018_7f94, -0x5e2); goto l_0x1018_7f94; /* jmp 0x10187f94 */
        l_0x1018_8576:
            ii(0x1018_8576, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_857b, 1); inc(eax);                               /* inc eax */
            ii(0x1018_857c, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_857f, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_8581, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_8583, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_8586, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8588, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_858d, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_8590, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8591, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_8594, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8599, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_859b, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_859e, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_85a1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_85a3, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_85a5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_85a7, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_85a9, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_85ab, 6); if(jge(0x1018_7f94, -0x61d)) goto l_0x1018_7f94; /* jge 0x10187f94 */
        l_0x1018_85b1:
            ii(0x1018_85b1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_85b3, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_85b6, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_85b8, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_85be, 1); inc(esi);                               /* inc esi */
            ii(0x1018_85bf, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_85c5, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_85c8, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_85ce, 1); inc(eax);                               /* inc eax */
            ii(0x1018_85cf, 1); inc(edx);                               /* inc edx */
            ii(0x1018_85d0, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_85d3, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1018_85d5, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_85db, 6); and(ebp, 0xfff);                        /* and ebp, 0xfff */
            ii(0x1018_85e1, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_85e7, 6); mov(memd[ds, 0x1020_a6e0], ebp);        /* mov [0x1020a6e0], ebp */
            ii(0x1018_85ed, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_85ef, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_85f1, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_85f3, 6); if(jge(0x1018_7f94, -0x665)) goto l_0x1018_7f94; /* jge 0x10187f94 */
            ii(0x1018_85f9, 2); jmp(0x1018_85b1, -0x4a); goto l_0x1018_85b1; /* jmp 0x101885b1 */
        l_0x1018_85fb:
            ii(0x1018_85fb, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_85fd, 6); if(jz(0x1018_9245, 0xc42)) goto l_0x1018_9245; /* jz 0x10189245 */
            ii(0x1018_8603, 7); cmp(memd[ds, 0x1020_a6dc], 0);          /* cmp dword [0x1020a6dc], 0x0 */
            ii(0x1018_860a, 6); if(jbe(0x1018_86b3, 0xa3)) goto l_0x1018_86b3; /* jbe 0x101886b3 */
            ii(0x1018_8610, 3); cmp(ebx, 0x11);                         /* cmp ebx, 0x11 */
            ii(0x1018_8613, 6); if(jge(0x1018_86b3, 0x9a)) goto l_0x1018_86b3; /* jge 0x101886b3 */
            ii(0x1018_8619, 6); cmp(ebp, memd[ds, 0x1020_a6e4]);        /* cmp ebp, [0x1020a6e4] */
            ii(0x1018_861f, 2); if(jz(0x1018_8653, 0x32)) goto l_0x1018_8653; /* jz 0x10188653 */
            ii(0x1018_8621, 5); mov(eax, 0x1020_a2d8);                  /* mov eax, 0x1020a2d8 */
            ii(0x1018_8626, 2); mov(edx, ebp);                          /* mov edx, ebp */
            ii(0x1018_8628, 5); call(/* sys */ 0x1016_6177, -0x2_24b6); /* call 0x10166177 */
            ii(0x1018_862d, 5); mov(eax, memd[ds, 0x1020_a6e4]);        /* mov eax, [0x1020a6e4] */
            ii(0x1018_8632, 6); mov(ebp, memd[ds, 0x1020_a6d8]);        /* mov ebp, [0x1020a6d8] */
            ii(0x1018_8638, 5); mov(edx, 0x1020_a2d8);                  /* mov edx, 0x1020a2d8 */
            ii(0x1018_863d, 2); sub(eax, ebp);                          /* sub eax, ebp */
            ii(0x1018_863f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_8641, 5); mov(eax, 0x1020_a2d8);                  /* mov eax, 0x1020a2d8 */
            ii(0x1018_8646, 6); mov(memd[ds, 0x1020_a6e4], edx);        /* mov [0x1020a6e4], edx */
            ii(0x1018_864c, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8651, 2); jmp(0x1018_8664, 0x11); goto l_0x1018_8664; /* jmp 0x10188664 */
        l_0x1018_8653:
            ii(0x1018_8653, 5); mov(ebx, 0x1020_a2d8);                  /* mov ebx, 0x1020a2d8 */
            ii(0x1018_8658, 6); mov(memd[ds, 0x1020_a6e4], ebx);        /* mov [0x1020a6e4], ebx */
            ii(0x1018_865e, 6); mov(memd[ds, 0x1020_a6d8], ebx);        /* mov [0x1020a6d8], ebx */
        l_0x1018_8664:
            ii(0x1018_8664, 6); mov(ebx, memd[ds, 0x1020_a6e4]);        /* mov ebx, [0x1020a6e4] */
            ii(0x1018_866a, 5); mov(eax, 0x400);                        /* mov eax, 0x400 */
            ii(0x1018_866f, 6); sub(ebx, 0x1020_a2d8);                  /* sub ebx, 0x1020a2d8 */
            ii(0x1018_8675, 3); mov(ecx, memd[ss, esp]);                /* mov ecx, [esp] */
            ii(0x1018_8678, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1018_867a, 6); mov(edx, memd[ds, 0x1020_a6dc]);        /* mov edx, [0x1020a6dc] */
            ii(0x1018_8680, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_8682, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_8684, 2); if(jbe(0x1018_8688, 0x2)) goto l_0x1018_8688; /* jbe 0x10188688 */
            ii(0x1018_8686, 2); mov(ebx, edx);                          /* mov ebx, edx */
        l_0x1018_8688:
            ii(0x1018_8688, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1018_868d, 5); mov(eax, memd[ds, 0x1020_a6e4]);        /* mov eax, [0x1020a6e4] */
            ii(0x1018_8692, 5); call(Definitions.sys_fread, -0x1_612b); /* call 0x1017256c */
            ii(0x1018_8697, 6); mov(ebx, memd[ds, 0x1020_a6e4]);        /* mov ebx, [0x1020a6e4] */
            ii(0x1018_869d, 6); mov(ecx, memd[ds, 0x1020_a6dc]);        /* mov ecx, [0x1020a6dc] */
            ii(0x1018_86a3, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1018_86a5, 2); sub(ecx, eax);                          /* sub ecx, eax */
            ii(0x1018_86a7, 6); mov(memd[ds, 0x1020_a6e4], ebx);        /* mov [0x1020a6e4], ebx */
            ii(0x1018_86ad, 6); mov(memd[ds, 0x1020_a6dc], ecx);        /* mov [0x1020a6dc], ecx */
        l_0x1018_86b3:
            ii(0x1018_86b3, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_86b8, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_86ba, 1); inc(eax);                               /* inc eax */
            ii(0x1018_86bb, 4); mov(memb[ss, esp + 0x4], dl);           /* mov [esp+0x4], dl */
            ii(0x1018_86bf, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_86c4, 1); dec(edi);                               /* dec edi */
            ii(0x1018_86c5, 6); if(jz(0x1018_9245, 0xb7a)) goto l_0x1018_9245; /* jz 0x10189245 */
            ii(0x1018_86cb, 3); test(dl, 0x1);                          /* test dl, 0x1 */
            ii(0x1018_86ce, 2); if(jz(0x1018_8704, 0x34)) goto l_0x1018_8704; /* jz 0x10188704 */
            ii(0x1018_86d0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_86d2, 1); dec(edi);                               /* dec edi */
            ii(0x1018_86d3, 1); inc(esi);                               /* inc esi */
            ii(0x1018_86d4, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1018_86d6, 1); inc(edx);                               /* inc edx */
            ii(0x1018_86d7, 3); mov(memb[ds, esi - 0x1], al);           /* mov [esi-0x1], al */
            ii(0x1018_86da, 5); mov(eax, memd[ds, 0x1020_a6e0]);        /* mov eax, [0x1020a6e0] */
            ii(0x1018_86df, 6); mov(memd[ds, 0x1020_a6d8], edx);        /* mov [0x1020a6d8], edx */
            ii(0x1018_86e5, 1); inc(eax);                               /* inc eax */
            ii(0x1018_86e6, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_86e9, 2); mov(ebp, eax);                          /* mov ebp, eax */
            ii(0x1018_86eb, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_86f0, 6); and(ebp, 0xfff);                        /* and ebp, 0xfff */
            ii(0x1018_86f6, 6); mov(memb[ds, eax + 0x1020_a6e7], bl);   /* mov [eax+0x1020a6e7], bl */
            ii(0x1018_86fc, 6); mov(memd[ds, 0x1020_a6e0], ebp);        /* mov [0x1020a6e0], ebp */
            ii(0x1018_8702, 2); jmp(0x1018_8770, 0x6c); goto l_0x1018_8770; /* jmp 0x10188770 */
        l_0x1018_8704:
            ii(0x1018_8704, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8705, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_8708, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_870a, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_870c, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8711, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8713, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_8716, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_8719, 1); inc(eax);                               /* inc eax */
            ii(0x1018_871a, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_871d, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8722, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_8724, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_8727, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_872a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_872c, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_872e, 2); jmp(0x1018_8768, 0x38); goto l_0x1018_8768; /* jmp 0x10188768 */
        l_0x1018_8730:
            ii(0x1018_8730, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8732, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_8735, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_8737, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_873d, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_8743, 2); mov(memb[ds, esi], dl);                 /* mov [esi], dl */
            ii(0x1018_8745, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_874b, 1); inc(edx);                               /* inc edx */
            ii(0x1018_874c, 2); mov(bl, memb[ds, esi]);                 /* mov bl, [esi] */
            ii(0x1018_874e, 1); inc(esi);                               /* inc esi */
            ii(0x1018_874f, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_8755, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_875b, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_8761, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8762, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
        l_0x1018_8768:
            ii(0x1018_8768, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_876a, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_876c, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_876e, 2); if(jl(0x1018_8730, -0x40)) goto l_0x1018_8730; /* jl 0x10188730 */
        l_0x1018_8770:
            ii(0x1018_8770, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_8772, 6); if(jz(0x1018_9245, 0xacd)) goto l_0x1018_9245; /* jz 0x10189245 */
            ii(0x1018_8778, 5); test(memb[ss, esp + 0x4], 0x2);         /* test byte [esp+0x4], 0x2 */
            ii(0x1018_877d, 2); if(jz(0x1018_87b7, 0x38)) goto l_0x1018_87b7; /* jz 0x101887b7 */
            ii(0x1018_877f, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_8784, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8785, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_8787, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_878a, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_8790, 1); dec(edi);                               /* dec edi */
            ii(0x1018_8791, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8792, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_8795, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8796, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_879c, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1018_879e, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_87a4, 6); and(ebx, 0xfff);                        /* and ebx, 0xfff */
            ii(0x1018_87aa, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_87af, 6); mov(memd[ds, 0x1020_a6e0], ebx);        /* mov [0x1020a6e0], ebx */
            ii(0x1018_87b5, 2); jmp(0x1018_882c, 0x75); goto l_0x1018_882c; /* jmp 0x1018882c */
        l_0x1018_87b7:
            ii(0x1018_87b7, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_87bc, 1); inc(eax);                               /* inc eax */
            ii(0x1018_87bd, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_87c0, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_87c2, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_87c4, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_87c7, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_87c9, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_87ce, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_87d1, 1); inc(eax);                               /* inc eax */
            ii(0x1018_87d2, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_87d5, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_87da, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_87dc, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_87df, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_87e2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_87e4, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_87e6, 2); jmp(0x1018_8824, 0x3c); goto l_0x1018_8824; /* jmp 0x10188824 */
        l_0x1018_87e8:
            ii(0x1018_87e8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_87ea, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_87ed, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_87ef, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_87f5, 1); inc(esi);                               /* inc esi */
            ii(0x1018_87f6, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_87fc, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_87ff, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_8805, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8806, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8807, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_880a, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1018_880c, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_8812, 6); and(ebp, 0xfff);                        /* and ebp, 0xfff */
            ii(0x1018_8818, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_881e, 6); mov(memd[ds, 0x1020_a6e0], ebp);        /* mov [0x1020a6e0], ebp */
        l_0x1018_8824:
            ii(0x1018_8824, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8826, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8828, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_882a, 2); if(jl(0x1018_87e8, -0x44)) goto l_0x1018_87e8; /* jl 0x101887e8 */
        l_0x1018_882c:
            ii(0x1018_882c, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_882e, 6); if(jz(0x1018_9245, 0xa11)) goto l_0x1018_9245; /* jz 0x10189245 */
            ii(0x1018_8834, 5); test(memb[ss, esp + 0x4], 0x4);         /* test byte [esp+0x4], 0x4 */
            ii(0x1018_8839, 2); if(jz(0x1018_8871, 0x36)) goto l_0x1018_8871; /* jz 0x10188871 */
            ii(0x1018_883b, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_8840, 1); dec(edi);                               /* dec edi */
            ii(0x1018_8841, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8842, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_8844, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8845, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_8848, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_884e, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8853, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8854, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_8857, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_8859, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_885f, 5); and(eax, 0xfff);                        /* and eax, 0xfff */
            ii(0x1018_8864, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_886a, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_886f, 2); jmp(0x1018_88e2, 0x71); goto l_0x1018_88e2; /* jmp 0x101888e2 */
        l_0x1018_8871:
            ii(0x1018_8871, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_8876, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8877, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_887a, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_887c, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_887e, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_8881, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8883, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8888, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_888b, 1); inc(eax);                               /* inc eax */
            ii(0x1018_888c, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_888f, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8894, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_8896, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_8899, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_889c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_889e, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_88a0, 2); jmp(0x1018_88da, 0x38); goto l_0x1018_88da; /* jmp 0x101888da */
        l_0x1018_88a2:
            ii(0x1018_88a2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_88a4, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_88a7, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_88a9, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_88af, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_88b5, 2); mov(memb[ds, esi], dl);                 /* mov [esi], dl */
            ii(0x1018_88b7, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_88bd, 1); inc(edx);                               /* inc edx */
            ii(0x1018_88be, 2); mov(bl, memb[ds, esi]);                 /* mov bl, [esi] */
            ii(0x1018_88c0, 1); inc(esi);                               /* inc esi */
            ii(0x1018_88c1, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_88c7, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_88cd, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_88d3, 1); inc(eax);                               /* inc eax */
            ii(0x1018_88d4, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
        l_0x1018_88da:
            ii(0x1018_88da, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_88dc, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_88de, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_88e0, 2); if(jl(0x1018_88a2, -0x40)) goto l_0x1018_88a2; /* jl 0x101888a2 */
        l_0x1018_88e2:
            ii(0x1018_88e2, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_88e4, 6); if(jz(0x1018_9245, 0x95b)) goto l_0x1018_9245; /* jz 0x10189245 */
            ii(0x1018_88ea, 5); test(memb[ss, esp + 0x4], 0x8);         /* test byte [esp+0x4], 0x8 */
            ii(0x1018_88ef, 2); if(jz(0x1018_8929, 0x38)) goto l_0x1018_8929; /* jz 0x10188929 */
            ii(0x1018_88f1, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_88f6, 1); inc(esi);                               /* inc esi */
            ii(0x1018_88f7, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_88f9, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_88fc, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_8902, 1); dec(edi);                               /* dec edi */
            ii(0x1018_8903, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8904, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_8907, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8908, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_890e, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1018_8910, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_8916, 6); and(ebx, 0xfff);                        /* and ebx, 0xfff */
            ii(0x1018_891c, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8921, 6); mov(memd[ds, 0x1020_a6e0], ebx);        /* mov [0x1020a6e0], ebx */
            ii(0x1018_8927, 2); jmp(0x1018_899e, 0x75); goto l_0x1018_899e; /* jmp 0x1018899e */
        l_0x1018_8929:
            ii(0x1018_8929, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_892e, 1); inc(eax);                               /* inc eax */
            ii(0x1018_892f, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_8932, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_8934, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_8936, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_8939, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_893b, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8940, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_8943, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8944, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_8947, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_894c, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_894e, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_8951, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_8954, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_8956, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_8958, 2); jmp(0x1018_8996, 0x3c); goto l_0x1018_8996; /* jmp 0x10188996 */
        l_0x1018_895a:
            ii(0x1018_895a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_895c, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_895f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_8961, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_8967, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8968, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_896e, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_8971, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_8977, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8978, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8979, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_897c, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1018_897e, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_8984, 6); and(ebp, 0xfff);                        /* and ebp, 0xfff */
            ii(0x1018_898a, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_8990, 6); mov(memd[ds, 0x1020_a6e0], ebp);        /* mov [0x1020a6e0], ebp */
        l_0x1018_8996:
            ii(0x1018_8996, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8998, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_899a, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_899c, 2); if(jl(0x1018_895a, -0x44)) goto l_0x1018_895a; /* jl 0x1018895a */
        l_0x1018_899e:
            ii(0x1018_899e, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_89a0, 6); if(jz(0x1018_9245, 0x89f)) goto l_0x1018_9245; /* jz 0x10189245 */
            ii(0x1018_89a6, 5); test(memb[ss, esp + 0x4], 0x10);        /* test byte [esp+0x4], 0x10 */
            ii(0x1018_89ab, 2); if(jz(0x1018_89e3, 0x36)) goto l_0x1018_89e3; /* jz 0x101889e3 */
            ii(0x1018_89ad, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_89b2, 1); dec(edi);                               /* dec edi */
            ii(0x1018_89b3, 1); inc(esi);                               /* inc esi */
            ii(0x1018_89b4, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_89b6, 1); inc(eax);                               /* inc eax */
            ii(0x1018_89b7, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_89ba, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_89c0, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_89c5, 1); inc(edx);                               /* inc edx */
            ii(0x1018_89c6, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_89c9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_89cb, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_89d1, 5); and(eax, 0xfff);                        /* and eax, 0xfff */
            ii(0x1018_89d6, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_89dc, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_89e1, 2); jmp(0x1018_8a54, 0x71); goto l_0x1018_8a54; /* jmp 0x10188a54 */
        l_0x1018_89e3:
            ii(0x1018_89e3, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_89e8, 1); inc(eax);                               /* inc eax */
            ii(0x1018_89e9, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_89ec, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_89ee, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_89f0, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_89f3, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_89f5, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_89fa, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_89fd, 1); inc(eax);                               /* inc eax */
            ii(0x1018_89fe, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_8a01, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8a06, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_8a08, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_8a0b, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_8a0e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_8a10, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_8a12, 2); jmp(0x1018_8a4c, 0x38); goto l_0x1018_8a4c; /* jmp 0x10188a4c */
        l_0x1018_8a14:
            ii(0x1018_8a14, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8a16, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_8a19, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_8a1b, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_8a21, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_8a27, 2); mov(memb[ds, esi], dl);                 /* mov [esi], dl */
            ii(0x1018_8a29, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_8a2f, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8a30, 2); mov(bl, memb[ds, esi]);                 /* mov bl, [esi] */
            ii(0x1018_8a32, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8a33, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_8a39, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_8a3f, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_8a45, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8a46, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
        l_0x1018_8a4c:
            ii(0x1018_8a4c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8a4e, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8a50, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_8a52, 2); if(jl(0x1018_8a14, -0x40)) goto l_0x1018_8a14; /* jl 0x10188a14 */
        l_0x1018_8a54:
            ii(0x1018_8a54, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_8a56, 6); if(jz(0x1018_9245, 0x7e9)) goto l_0x1018_9245; /* jz 0x10189245 */
            ii(0x1018_8a5c, 5); test(memb[ss, esp + 0x4], 0x20);        /* test byte [esp+0x4], 0x20 */
            ii(0x1018_8a61, 2); if(jz(0x1018_8a9b, 0x38)) goto l_0x1018_8a9b; /* jz 0x10188a9b */
            ii(0x1018_8a63, 6); mov(edx, memd[ds, 0x1020_a6d8]);        /* mov edx, [0x1020a6d8] */
            ii(0x1018_8a69, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8a6a, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1018_8a6c, 3); mov(memb[ds, esi - 0x1], al);           /* mov [esi-0x1], al */
            ii(0x1018_8a6f, 5); mov(eax, memd[ds, 0x1020_a6e0]);        /* mov eax, [0x1020a6e0] */
            ii(0x1018_8a74, 1); dec(edi);                               /* dec edi */
            ii(0x1018_8a75, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8a76, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_8a79, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8a7a, 6); mov(memb[ds, eax + 0x1020_a6e7], bl);   /* mov [eax+0x1020a6e7], bl */
            ii(0x1018_8a80, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_8a82, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_8a87, 6); and(ebx, 0xfff);                        /* and ebx, 0xfff */
            ii(0x1018_8a8d, 6); mov(memd[ds, 0x1020_a6d8], edx);        /* mov [0x1020a6d8], edx */
            ii(0x1018_8a93, 6); mov(memd[ds, 0x1020_a6e0], ebx);        /* mov [0x1020a6e0], ebx */
            ii(0x1018_8a99, 2); jmp(0x1018_8b10, 0x75); goto l_0x1018_8b10; /* jmp 0x10188b10 */
        l_0x1018_8a9b:
            ii(0x1018_8a9b, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_8aa0, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8aa1, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_8aa4, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_8aa6, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_8aa8, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_8aab, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8aad, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8ab2, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_8ab5, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8ab6, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_8ab9, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8abe, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_8ac0, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_8ac3, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_8ac6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_8ac8, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_8aca, 2); jmp(0x1018_8b08, 0x3c); goto l_0x1018_8b08; /* jmp 0x10188b08 */
        l_0x1018_8acc:
            ii(0x1018_8acc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8ace, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_8ad1, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_8ad3, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_8ad9, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8ada, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_8ae0, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_8ae3, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_8ae9, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8aea, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8aeb, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_8aee, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1018_8af0, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_8af6, 6); and(ebp, 0xfff);                        /* and ebp, 0xfff */
            ii(0x1018_8afc, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_8b02, 6); mov(memd[ds, 0x1020_a6e0], ebp);        /* mov [0x1020a6e0], ebp */
        l_0x1018_8b08:
            ii(0x1018_8b08, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8b0a, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8b0c, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_8b0e, 2); if(jl(0x1018_8acc, -0x44)) goto l_0x1018_8acc; /* jl 0x10188acc */
        l_0x1018_8b10:
            ii(0x1018_8b10, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_8b12, 6); if(jz(0x1018_9245, 0x72d)) goto l_0x1018_9245; /* jz 0x10189245 */
            ii(0x1018_8b18, 5); test(memb[ss, esp + 0x4], 0x40);        /* test byte [esp+0x4], 0x40 */
            ii(0x1018_8b1d, 2); if(jz(0x1018_8b53, 0x34)) goto l_0x1018_8b53; /* jz 0x10188b53 */
            ii(0x1018_8b1f, 6); mov(edx, memd[ds, 0x1020_a6d8]);        /* mov edx, [0x1020a6d8] */
            ii(0x1018_8b25, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8b26, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1018_8b28, 3); mov(memb[ds, esi - 0x1], al);           /* mov [esi-0x1], al */
            ii(0x1018_8b2b, 5); mov(eax, memd[ds, 0x1020_a6e0]);        /* mov eax, [0x1020a6e0] */
            ii(0x1018_8b30, 1); dec(edi);                               /* dec edi */
            ii(0x1018_8b31, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8b32, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_8b35, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8b36, 6); mov(memb[ds, eax + 0x1020_a6e7], bl);   /* mov [eax+0x1020a6e7], bl */
            ii(0x1018_8b3c, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_8b41, 5); and(eax, 0xfff);                        /* and eax, 0xfff */
            ii(0x1018_8b46, 6); mov(memd[ds, 0x1020_a6d8], edx);        /* mov [0x1020a6d8], edx */
            ii(0x1018_8b4c, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_8b51, 2); jmp(0x1018_8bc4, 0x71); goto l_0x1018_8bc4; /* jmp 0x10188bc4 */
        l_0x1018_8b53:
            ii(0x1018_8b53, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_8b58, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8b59, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_8b5c, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_8b5e, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_8b60, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_8b63, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8b65, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8b6a, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_8b6d, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8b6e, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_8b71, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8b76, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_8b78, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_8b7b, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_8b7e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_8b80, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_8b82, 2); jmp(0x1018_8bbc, 0x38); goto l_0x1018_8bbc; /* jmp 0x10188bbc */
        l_0x1018_8b84:
            ii(0x1018_8b84, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8b86, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_8b89, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_8b8b, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_8b91, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_8b97, 2); mov(memb[ds, esi], dl);                 /* mov [esi], dl */
            ii(0x1018_8b99, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_8b9f, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8ba0, 2); mov(bl, memb[ds, esi]);                 /* mov bl, [esi] */
            ii(0x1018_8ba2, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8ba3, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_8ba9, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_8baf, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_8bb5, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8bb6, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
        l_0x1018_8bbc:
            ii(0x1018_8bbc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8bbe, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8bc0, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_8bc2, 2); if(jl(0x1018_8b84, -0x40)) goto l_0x1018_8b84; /* jl 0x10188b84 */
        l_0x1018_8bc4:
            ii(0x1018_8bc4, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_8bc6, 6); if(jz(0x1018_9245, 0x679)) goto l_0x1018_9245; /* jz 0x10189245 */
            ii(0x1018_8bcc, 5); test(memb[ss, esp + 0x4], 0x80);        /* test byte [esp+0x4], 0x80 */
            ii(0x1018_8bd1, 2); if(jz(0x1018_8c0b, 0x38)) goto l_0x1018_8c0b; /* jz 0x10188c0b */
            ii(0x1018_8bd3, 6); mov(edx, memd[ds, 0x1020_a6d8]);        /* mov edx, [0x1020a6d8] */
            ii(0x1018_8bd9, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8bda, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1018_8bdc, 3); mov(memb[ds, esi - 0x1], al);           /* mov [esi-0x1], al */
            ii(0x1018_8bdf, 5); mov(eax, memd[ds, 0x1020_a6e0]);        /* mov eax, [0x1020a6e0] */
            ii(0x1018_8be4, 1); dec(edi);                               /* dec edi */
            ii(0x1018_8be5, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8be6, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_8be9, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8bea, 6); mov(memb[ds, eax + 0x1020_a6e7], bl);   /* mov [eax+0x1020a6e7], bl */
            ii(0x1018_8bf0, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_8bf2, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_8bf7, 6); and(ebx, 0xfff);                        /* and ebx, 0xfff */
            ii(0x1018_8bfd, 6); mov(memd[ds, 0x1020_a6d8], edx);        /* mov [0x1020a6d8], edx */
            ii(0x1018_8c03, 6); mov(memd[ds, 0x1020_a6e0], ebx);        /* mov [0x1020a6e0], ebx */
            ii(0x1018_8c09, 2); jmp(0x1018_8c80, 0x75); goto l_0x1018_8c80; /* jmp 0x10188c80 */
        l_0x1018_8c0b:
            ii(0x1018_8c0b, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_8c10, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8c11, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_8c14, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_8c16, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_8c18, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_8c1b, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8c1d, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8c22, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_8c25, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8c26, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_8c29, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8c2e, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_8c30, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_8c33, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_8c36, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_8c38, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_8c3a, 2); jmp(0x1018_8c78, 0x3c); goto l_0x1018_8c78; /* jmp 0x10188c78 */
        l_0x1018_8c3c:
            ii(0x1018_8c3c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8c3e, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_8c41, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_8c43, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_8c49, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8c4a, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_8c50, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_8c53, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_8c59, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8c5a, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8c5b, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_8c5e, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1018_8c60, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_8c66, 6); and(ebp, 0xfff);                        /* and ebp, 0xfff */
            ii(0x1018_8c6c, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_8c72, 6); mov(memd[ds, 0x1020_a6e0], ebp);        /* mov [0x1020a6e0], ebp */
        l_0x1018_8c78:
            ii(0x1018_8c78, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8c7a, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8c7c, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_8c7e, 2); if(jl(0x1018_8c3c, -0x44)) goto l_0x1018_8c3c; /* jl 0x10188c3c */
        l_0x1018_8c80:
            ii(0x1018_8c80, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_8c82, 6); if(jz(0x1018_9245, 0x5bd)) goto l_0x1018_9245; /* jz 0x10189245 */
            ii(0x1018_8c88, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_8c8d, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_8c8f, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8c90, 4); mov(memb[ss, esp + 0x8], dl);           /* mov [esp+0x8], dl */
            ii(0x1018_8c94, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8c99, 1); dec(edi);                               /* dec edi */
            ii(0x1018_8c9a, 6); if(jz(0x1018_9245, 0x5a5)) goto l_0x1018_9245; /* jz 0x10189245 */
            ii(0x1018_8ca0, 3); test(dl, 0x1);                          /* test dl, 0x1 */
            ii(0x1018_8ca3, 2); if(jz(0x1018_8cd5, 0x30)) goto l_0x1018_8cd5; /* jz 0x10188cd5 */
            ii(0x1018_8ca5, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8ca6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_8ca8, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1018_8caa, 3); mov(memb[ds, esi - 0x1], al);           /* mov [esi-0x1], al */
            ii(0x1018_8cad, 5); mov(eax, memd[ds, 0x1020_a6e0]);        /* mov eax, [0x1020a6e0] */
            ii(0x1018_8cb2, 1); dec(edi);                               /* dec edi */
            ii(0x1018_8cb3, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8cb4, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_8cb7, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8cb8, 6); mov(memb[ds, eax + 0x1020_a6e7], bl);   /* mov [eax+0x1020a6e7], bl */
            ii(0x1018_8cbe, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_8cc3, 5); and(eax, 0xfff);                        /* and eax, 0xfff */
            ii(0x1018_8cc8, 6); mov(memd[ds, 0x1020_a6d8], edx);        /* mov [0x1020a6d8], edx */
            ii(0x1018_8cce, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_8cd3, 2); jmp(0x1018_8d41, 0x6c); goto l_0x1018_8d41; /* jmp 0x10188d41 */
        l_0x1018_8cd5:
            ii(0x1018_8cd5, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8cd6, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_8cd9, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_8cdb, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_8cdd, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8ce2, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8ce4, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_8ce7, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_8cea, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8ceb, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_8cee, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8cf3, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_8cf5, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_8cf8, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_8cfb, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_8cfd, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_8cff, 2); jmp(0x1018_8d39, 0x38); goto l_0x1018_8d39; /* jmp 0x10188d39 */
        l_0x1018_8d01:
            ii(0x1018_8d01, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8d03, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_8d06, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_8d08, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_8d0e, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_8d14, 2); mov(memb[ds, esi], dl);                 /* mov [esi], dl */
            ii(0x1018_8d16, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_8d1c, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8d1d, 2); mov(bl, memb[ds, esi]);                 /* mov bl, [esi] */
            ii(0x1018_8d1f, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8d20, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_8d26, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_8d2c, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_8d32, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8d33, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
        l_0x1018_8d39:
            ii(0x1018_8d39, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8d3b, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8d3d, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_8d3f, 2); if(jl(0x1018_8d01, -0x40)) goto l_0x1018_8d01; /* jl 0x10188d01 */
        l_0x1018_8d41:
            ii(0x1018_8d41, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_8d43, 6); if(jz(0x1018_9245, 0x4fc)) goto l_0x1018_9245; /* jz 0x10189245 */
            ii(0x1018_8d49, 5); test(memb[ss, esp + 0x8], 0x2);         /* test byte [esp+0x8], 0x2 */
            ii(0x1018_8d4e, 2); if(jz(0x1018_8d88, 0x38)) goto l_0x1018_8d88; /* jz 0x10188d88 */
            ii(0x1018_8d50, 6); mov(edx, memd[ds, 0x1020_a6d8]);        /* mov edx, [0x1020a6d8] */
            ii(0x1018_8d56, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8d57, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1018_8d59, 3); mov(memb[ds, esi - 0x1], al);           /* mov [esi-0x1], al */
            ii(0x1018_8d5c, 5); mov(eax, memd[ds, 0x1020_a6e0]);        /* mov eax, [0x1020a6e0] */
            ii(0x1018_8d61, 1); dec(edi);                               /* dec edi */
            ii(0x1018_8d62, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8d63, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_8d66, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8d67, 6); mov(memb[ds, eax + 0x1020_a6e7], bl);   /* mov [eax+0x1020a6e7], bl */
            ii(0x1018_8d6d, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_8d6f, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_8d74, 6); and(ebx, 0xfff);                        /* and ebx, 0xfff */
            ii(0x1018_8d7a, 6); mov(memd[ds, 0x1020_a6d8], edx);        /* mov [0x1020a6d8], edx */
            ii(0x1018_8d80, 6); mov(memd[ds, 0x1020_a6e0], ebx);        /* mov [0x1020a6e0], ebx */
            ii(0x1018_8d86, 2); jmp(0x1018_8dfd, 0x75); goto l_0x1018_8dfd; /* jmp 0x10188dfd */
        l_0x1018_8d88:
            ii(0x1018_8d88, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_8d8d, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8d8e, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_8d91, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_8d93, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_8d95, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_8d98, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8d9a, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8d9f, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_8da2, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8da3, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_8da6, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8dab, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_8dad, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_8db0, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_8db3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_8db5, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_8db7, 2); jmp(0x1018_8df5, 0x3c); goto l_0x1018_8df5; /* jmp 0x10188df5 */
        l_0x1018_8db9:
            ii(0x1018_8db9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8dbb, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_8dbe, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_8dc0, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_8dc6, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8dc7, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_8dcd, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_8dd0, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_8dd6, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8dd7, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8dd8, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_8ddb, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1018_8ddd, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_8de3, 6); and(ebp, 0xfff);                        /* and ebp, 0xfff */
            ii(0x1018_8de9, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_8def, 6); mov(memd[ds, 0x1020_a6e0], ebp);        /* mov [0x1020a6e0], ebp */
        l_0x1018_8df5:
            ii(0x1018_8df5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8df7, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8df9, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_8dfb, 2); if(jl(0x1018_8db9, -0x44)) goto l_0x1018_8db9; /* jl 0x10188db9 */
        l_0x1018_8dfd:
            ii(0x1018_8dfd, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_8dff, 6); if(jz(0x1018_9245, 0x440)) goto l_0x1018_9245; /* jz 0x10189245 */
            ii(0x1018_8e05, 5); test(memb[ss, esp + 0x8], 0x4);         /* test byte [esp+0x8], 0x4 */
            ii(0x1018_8e0a, 2); if(jz(0x1018_8e42, 0x36)) goto l_0x1018_8e42; /* jz 0x10188e42 */
            ii(0x1018_8e0c, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_8e11, 1); dec(edi);                               /* dec edi */
            ii(0x1018_8e12, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8e13, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_8e15, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8e16, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_8e19, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_8e1f, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8e24, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8e25, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_8e28, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_8e2a, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_8e30, 5); and(eax, 0xfff);                        /* and eax, 0xfff */
            ii(0x1018_8e35, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_8e3b, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_8e40, 2); jmp(0x1018_8eb3, 0x71); goto l_0x1018_8eb3; /* jmp 0x10188eb3 */
        l_0x1018_8e42:
            ii(0x1018_8e42, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_8e47, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8e48, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_8e4b, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_8e4d, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_8e4f, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_8e52, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8e54, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8e59, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_8e5c, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8e5d, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_8e60, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8e65, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_8e67, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_8e6a, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_8e6d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_8e6f, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_8e71, 2); jmp(0x1018_8eab, 0x38); goto l_0x1018_8eab; /* jmp 0x10188eab */
        l_0x1018_8e73:
            ii(0x1018_8e73, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8e75, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_8e78, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_8e7a, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_8e80, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_8e86, 2); mov(memb[ds, esi], dl);                 /* mov [esi], dl */
            ii(0x1018_8e88, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_8e8e, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8e8f, 2); mov(bl, memb[ds, esi]);                 /* mov bl, [esi] */
            ii(0x1018_8e91, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8e92, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_8e98, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_8e9e, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_8ea4, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8ea5, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
        l_0x1018_8eab:
            ii(0x1018_8eab, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8ead, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8eaf, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_8eb1, 2); if(jl(0x1018_8e73, -0x40)) goto l_0x1018_8e73; /* jl 0x10188e73 */
        l_0x1018_8eb3:
            ii(0x1018_8eb3, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_8eb5, 6); if(jz(0x1018_9245, 0x38a)) goto l_0x1018_9245; /* jz 0x10189245 */
            ii(0x1018_8ebb, 5); test(memb[ss, esp + 0x8], 0x8);         /* test byte [esp+0x8], 0x8 */
            ii(0x1018_8ec0, 2); if(jz(0x1018_8efa, 0x38)) goto l_0x1018_8efa; /* jz 0x10188efa */
            ii(0x1018_8ec2, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_8ec7, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8ec8, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_8eca, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_8ecd, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_8ed3, 1); dec(edi);                               /* dec edi */
            ii(0x1018_8ed4, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8ed5, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_8ed8, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8ed9, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_8edf, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1018_8ee1, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_8ee7, 6); and(ebx, 0xfff);                        /* and ebx, 0xfff */
            ii(0x1018_8eed, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8ef2, 6); mov(memd[ds, 0x1020_a6e0], ebx);        /* mov [0x1020a6e0], ebx */
            ii(0x1018_8ef8, 2); jmp(0x1018_8f6f, 0x75); goto l_0x1018_8f6f; /* jmp 0x10188f6f */
        l_0x1018_8efa:
            ii(0x1018_8efa, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_8eff, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8f00, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_8f03, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_8f05, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_8f07, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_8f0a, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8f0c, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8f11, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_8f14, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8f15, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_8f18, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8f1d, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_8f1f, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_8f22, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_8f25, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_8f27, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_8f29, 2); jmp(0x1018_8f67, 0x3c); goto l_0x1018_8f67; /* jmp 0x10188f67 */
        l_0x1018_8f2b:
            ii(0x1018_8f2b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8f2d, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_8f30, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_8f32, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_8f38, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8f39, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_8f3f, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_8f42, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_8f48, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8f49, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8f4a, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_8f4d, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1018_8f4f, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_8f55, 6); and(ebp, 0xfff);                        /* and ebp, 0xfff */
            ii(0x1018_8f5b, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_8f61, 6); mov(memd[ds, 0x1020_a6e0], ebp);        /* mov [0x1020a6e0], ebp */
        l_0x1018_8f67:
            ii(0x1018_8f67, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8f69, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8f6b, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_8f6d, 2); if(jl(0x1018_8f2b, -0x44)) goto l_0x1018_8f2b; /* jl 0x10188f2b */
        l_0x1018_8f6f:
            ii(0x1018_8f6f, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_8f71, 6); if(jz(0x1018_9245, 0x2ce)) goto l_0x1018_9245; /* jz 0x10189245 */
            ii(0x1018_8f77, 5); test(memb[ss, esp + 0x8], 0x10);        /* test byte [esp+0x8], 0x10 */
            ii(0x1018_8f7c, 2); if(jz(0x1018_8fb2, 0x34)) goto l_0x1018_8fb2; /* jz 0x10188fb2 */
            ii(0x1018_8f7e, 6); mov(edx, memd[ds, 0x1020_a6d8]);        /* mov edx, [0x1020a6d8] */
            ii(0x1018_8f84, 1); inc(esi);                               /* inc esi */
            ii(0x1018_8f85, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1018_8f87, 3); mov(memb[ds, esi - 0x1], al);           /* mov [esi-0x1], al */
            ii(0x1018_8f8a, 5); mov(eax, memd[ds, 0x1020_a6e0]);        /* mov eax, [0x1020a6e0] */
            ii(0x1018_8f8f, 1); dec(edi);                               /* dec edi */
            ii(0x1018_8f90, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8f91, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_8f94, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8f95, 6); mov(memb[ds, eax + 0x1020_a6e7], bl);   /* mov [eax+0x1020a6e7], bl */
            ii(0x1018_8f9b, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_8fa0, 5); and(eax, 0xfff);                        /* and eax, 0xfff */
            ii(0x1018_8fa5, 6); mov(memd[ds, 0x1020_a6d8], edx);        /* mov [0x1020a6d8], edx */
            ii(0x1018_8fab, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_8fb0, 2); jmp(0x1018_9023, 0x71); goto l_0x1018_9023; /* jmp 0x10189023 */
        l_0x1018_8fb2:
            ii(0x1018_8fb2, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_8fb7, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8fb8, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_8fbb, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_8fbd, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_8fbf, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_8fc2, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_8fc4, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8fc9, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_8fcc, 1); inc(eax);                               /* inc eax */
            ii(0x1018_8fcd, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_8fd0, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_8fd5, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_8fd7, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_8fda, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_8fdd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_8fdf, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_8fe1, 2); jmp(0x1018_901b, 0x38); goto l_0x1018_901b; /* jmp 0x1018901b */
        l_0x1018_8fe3:
            ii(0x1018_8fe3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_8fe5, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_8fe8, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_8fea, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_8ff0, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_8ff6, 2); mov(memb[ds, esi], dl);                 /* mov [esi], dl */
            ii(0x1018_8ff8, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_8ffe, 1); inc(edx);                               /* inc edx */
            ii(0x1018_8fff, 2); mov(bl, memb[ds, esi]);                 /* mov bl, [esi] */
            ii(0x1018_9001, 1); inc(esi);                               /* inc esi */
            ii(0x1018_9002, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_9008, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_900e, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_9014, 1); inc(eax);                               /* inc eax */
            ii(0x1018_9015, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
        l_0x1018_901b:
            ii(0x1018_901b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_901d, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_901f, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_9021, 2); if(jl(0x1018_8fe3, -0x40)) goto l_0x1018_8fe3; /* jl 0x10188fe3 */
        l_0x1018_9023:
            ii(0x1018_9023, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_9025, 6); if(jz(0x1018_9245, 0x21a)) goto l_0x1018_9245; /* jz 0x10189245 */
            ii(0x1018_902b, 5); test(memb[ss, esp + 0x8], 0x20);        /* test byte [esp+0x8], 0x20 */
            ii(0x1018_9030, 2); if(jz(0x1018_906a, 0x38)) goto l_0x1018_906a; /* jz 0x1018906a */
            ii(0x1018_9032, 6); mov(edx, memd[ds, 0x1020_a6d8]);        /* mov edx, [0x1020a6d8] */
            ii(0x1018_9038, 1); inc(esi);                               /* inc esi */
            ii(0x1018_9039, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1018_903b, 3); mov(memb[ds, esi - 0x1], al);           /* mov [esi-0x1], al */
            ii(0x1018_903e, 5); mov(eax, memd[ds, 0x1020_a6e0]);        /* mov eax, [0x1020a6e0] */
            ii(0x1018_9043, 1); dec(edi);                               /* dec edi */
            ii(0x1018_9044, 1); inc(eax);                               /* inc eax */
            ii(0x1018_9045, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_9048, 1); inc(edx);                               /* inc edx */
            ii(0x1018_9049, 6); mov(memb[ds, eax + 0x1020_a6e7], bl);   /* mov [eax+0x1020a6e7], bl */
            ii(0x1018_904f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_9051, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_9056, 6); and(ebx, 0xfff);                        /* and ebx, 0xfff */
            ii(0x1018_905c, 6); mov(memd[ds, 0x1020_a6d8], edx);        /* mov [0x1020a6d8], edx */
            ii(0x1018_9062, 6); mov(memd[ds, 0x1020_a6e0], ebx);        /* mov [0x1020a6e0], ebx */
            ii(0x1018_9068, 2); jmp(0x1018_90df, 0x75); goto l_0x1018_90df; /* jmp 0x101890df */
        l_0x1018_906a:
            ii(0x1018_906a, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_906f, 1); inc(eax);                               /* inc eax */
            ii(0x1018_9070, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_9073, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_9075, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_9077, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_907a, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_907c, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_9081, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_9084, 1); inc(eax);                               /* inc eax */
            ii(0x1018_9085, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_9088, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_908d, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_908f, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_9092, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_9095, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_9097, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_9099, 2); jmp(0x1018_90d7, 0x3c); goto l_0x1018_90d7; /* jmp 0x101890d7 */
        l_0x1018_909b:
            ii(0x1018_909b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_909d, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_90a0, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_90a2, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_90a8, 1); inc(esi);                               /* inc esi */
            ii(0x1018_90a9, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_90af, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_90b2, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_90b8, 1); inc(eax);                               /* inc eax */
            ii(0x1018_90b9, 1); inc(edx);                               /* inc edx */
            ii(0x1018_90ba, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_90bd, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1018_90bf, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_90c5, 6); and(ebp, 0xfff);                        /* and ebp, 0xfff */
            ii(0x1018_90cb, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_90d1, 6); mov(memd[ds, 0x1020_a6e0], ebp);        /* mov [0x1020a6e0], ebp */
        l_0x1018_90d7:
            ii(0x1018_90d7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_90d9, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_90db, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_90dd, 2); if(jl(0x1018_909b, -0x44)) goto l_0x1018_909b; /* jl 0x1018909b */
        l_0x1018_90df:
            ii(0x1018_90df, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_90e1, 6); if(jz(0x1018_9245, 0x15e)) goto l_0x1018_9245; /* jz 0x10189245 */
            ii(0x1018_90e7, 5); test(memb[ss, esp + 0x8], 0x40);        /* test byte [esp+0x8], 0x40 */
            ii(0x1018_90ec, 2); if(jz(0x1018_9122, 0x34)) goto l_0x1018_9122; /* jz 0x10189122 */
            ii(0x1018_90ee, 6); mov(edx, memd[ds, 0x1020_a6d8]);        /* mov edx, [0x1020a6d8] */
            ii(0x1018_90f4, 1); inc(esi);                               /* inc esi */
            ii(0x1018_90f5, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1018_90f7, 3); mov(memb[ds, esi - 0x1], al);           /* mov [esi-0x1], al */
            ii(0x1018_90fa, 5); mov(eax, memd[ds, 0x1020_a6e0]);        /* mov eax, [0x1020a6e0] */
            ii(0x1018_90ff, 1); dec(edi);                               /* dec edi */
            ii(0x1018_9100, 1); inc(eax);                               /* inc eax */
            ii(0x1018_9101, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_9104, 1); inc(edx);                               /* inc edx */
            ii(0x1018_9105, 6); mov(memb[ds, eax + 0x1020_a6e7], bl);   /* mov [eax+0x1020a6e7], bl */
            ii(0x1018_910b, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_9110, 5); and(eax, 0xfff);                        /* and eax, 0xfff */
            ii(0x1018_9115, 6); mov(memd[ds, 0x1020_a6d8], edx);        /* mov [0x1020a6d8], edx */
            ii(0x1018_911b, 5); mov(memd[ds, 0x1020_a6e0], eax);        /* mov [0x1020a6e0], eax */
            ii(0x1018_9120, 2); jmp(0x1018_9193, 0x71); goto l_0x1018_9193; /* jmp 0x10189193 */
        l_0x1018_9122:
            ii(0x1018_9122, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_9127, 1); inc(eax);                               /* inc eax */
            ii(0x1018_9128, 3); sub(edi, 0x2);                          /* sub edi, 0x2 */
            ii(0x1018_912b, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_912d, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_912f, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_9132, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_9134, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_9139, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_913c, 1); inc(eax);                               /* inc eax */
            ii(0x1018_913d, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_9140, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_9145, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_9147, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_914a, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_914d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_914f, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_9151, 2); jmp(0x1018_918b, 0x38); goto l_0x1018_918b; /* jmp 0x1018918b */
        l_0x1018_9153:
            ii(0x1018_9153, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_9155, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_9158, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_915a, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_9160, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_9166, 2); mov(memb[ds, esi], dl);                 /* mov [esi], dl */
            ii(0x1018_9168, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_916e, 1); inc(edx);                               /* inc edx */
            ii(0x1018_916f, 2); mov(bl, memb[ds, esi]);                 /* mov bl, [esi] */
            ii(0x1018_9171, 1); inc(esi);                               /* inc esi */
            ii(0x1018_9172, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_9178, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_917e, 6); and(edx, 0xfff);                        /* and edx, 0xfff */
            ii(0x1018_9184, 1); inc(eax);                               /* inc eax */
            ii(0x1018_9185, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
        l_0x1018_918b:
            ii(0x1018_918b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_918d, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_918f, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_9191, 2); if(jl(0x1018_9153, -0x40)) goto l_0x1018_9153; /* jl 0x10189153 */
        l_0x1018_9193:
            ii(0x1018_9193, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1018_9195, 6); if(jz(0x1018_9245, 0xaa)) goto l_0x1018_9245; /* jz 0x10189245 */
            ii(0x1018_919b, 5); test(memb[ss, esp + 0x8], 0x80);        /* test byte [esp+0x8], 0x80 */
            ii(0x1018_91a0, 2); if(jz(0x1018_91d6, 0x34)) goto l_0x1018_91d6; /* jz 0x101891d6 */
            ii(0x1018_91a2, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_91a7, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_91a9, 2); mov(memb[ds, esi], dl);                 /* mov [esi], dl */
            ii(0x1018_91ab, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_91b1, 1); inc(edx);                               /* inc edx */
            ii(0x1018_91b2, 2); mov(bl, memb[ds, esi]);                 /* mov bl, [esi] */
            ii(0x1018_91b4, 1); inc(eax);                               /* inc eax */
            ii(0x1018_91b5, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_91bb, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1018_91bd, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_91c3, 6); and(ebx, 0xfff);                        /* and ebx, 0xfff */
            ii(0x1018_91c9, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_91ce, 6); mov(memd[ds, 0x1020_a6e0], ebx);        /* mov [0x1020a6e0], ebx */
            ii(0x1018_91d4, 2); jmp(0x1018_9245, 0x6f); goto l_0x1018_9245; /* jmp 0x10189245 */
        l_0x1018_91d6:
            ii(0x1018_91d6, 5); mov(eax, memd[ds, 0x1020_a6d8]);        /* mov eax, [0x1020a6d8] */
            ii(0x1018_91db, 1); inc(eax);                               /* inc eax */
            ii(0x1018_91dc, 5); mov(edi, 0xfff);                        /* mov edi, 0xfff */
            ii(0x1018_91e1, 2); xor(ch, ch);                            /* xor ch, ch */
            ii(0x1018_91e3, 2); mov(bh, memb[ds, eax]);                 /* mov bh, [eax] */
            ii(0x1018_91e5, 3); mov(cl, memb[ds, eax - 0x1]);           /* mov cl, [eax-0x1] */
            ii(0x1018_91e8, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_91ea, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_91ef, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1018_91f2, 1); inc(eax);                               /* inc eax */
            ii(0x1018_91f3, 3); and(bh, 0xf);                           /* and bh, 0xf */
            ii(0x1018_91f6, 5); mov(memd[ds, 0x1020_a6d8], eax);        /* mov [0x1020a6d8], eax */
            ii(0x1018_91fb, 2); xor(dh, dh);                            /* xor dh, dh */
            ii(0x1018_91fd, 3); add(bh, 0x3);                           /* add bh, 0x3 */
            ii(0x1018_9200, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1018_9203, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_9205, 2); or(ecx, edx);                           /* or ecx, edx */
            ii(0x1018_9207, 2); jmp(0x1018_923d, 0x34); goto l_0x1018_923d; /* jmp 0x1018923d */
        l_0x1018_9209:
            ii(0x1018_9209, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_920b, 3); mov(dx, cx);                            /* mov dx, cx */
            ii(0x1018_920e, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_9210, 2); and(edx, edi);                          /* and edx, edi */
            ii(0x1018_9212, 1); inc(esi);                               /* inc esi */
            ii(0x1018_9213, 6); mov(dl, memb[ds, edx + 0x1020_a6e8]);   /* mov dl, [edx+0x1020a6e8] */
            ii(0x1018_9219, 3); mov(memb[ds, esi - 0x1], dl);           /* mov [esi-0x1], dl */
            ii(0x1018_921c, 6); mov(edx, memd[ds, 0x1020_a6e0]);        /* mov edx, [0x1020a6e0] */
            ii(0x1018_9222, 1); inc(eax);                               /* inc eax */
            ii(0x1018_9223, 1); inc(edx);                               /* inc edx */
            ii(0x1018_9224, 3); mov(bl, memb[ds, esi - 0x1]);           /* mov bl, [esi-0x1] */
            ii(0x1018_9227, 2); mov(ebp, edx);                          /* mov ebp, edx */
            ii(0x1018_9229, 6); mov(memd[ds, 0x1020_a6e0], edx);        /* mov [0x1020a6e0], edx */
            ii(0x1018_922f, 2); and(ebp, edi);                          /* and ebp, edi */
            ii(0x1018_9231, 6); mov(memb[ds, edx + 0x1020_a6e7], bl);   /* mov [edx+0x1020a6e7], bl */
            ii(0x1018_9237, 6); mov(memd[ds, 0x1020_a6e0], ebp);        /* mov [0x1020a6e0], ebp */
        l_0x1018_923d:
            ii(0x1018_923d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_923f, 2); mov(dl, bh);                            /* mov dl, bh */
            ii(0x1018_9241, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1018_9243, 2); if(jl(0x1018_9209, -0x3c)) goto l_0x1018_9209; /* jl 0x10189209 */
        l_0x1018_9245:
            ii(0x1018_9245, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1018_9248, 1); pop(ebp);                               /* pop ebp */
            ii(0x1018_9249, 1); pop(edi);                               /* pop edi */
            ii(0x1018_924a, 1); pop(esi);                               /* pop esi */
            ii(0x1018_924b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_924c, 1); ret();                                  /* ret */
        }
    }
}
