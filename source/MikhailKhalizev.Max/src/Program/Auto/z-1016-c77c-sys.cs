using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e8a0681d-6cbe-4ba2-b628-507382f5afaa")]
        public void /* sys */ Method_1016_c77c()
        {
            ii(0x1016_c77c, 1); sti();                                  /* sti */
            ii(0x1016_c77d, 3); and(esp, -0x4 /* 0xfc */);              /* and esp, 0xfffffffc */
            ii(0x1016_c780, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1016_c782, 6); mov(memd_a32[ds, 0x101b_e574], ebx);    /* mov [0x101be574], ebx */
            ii(0x1016_c788, 6); mov(memd_a32[ds, 0x101b_e560], ebx);    /* mov [0x101be560], ebx */
            ii(0x1016_c78e, 4); mov(ax, 0x24);                          /* mov ax, 0x24 */
            ii(0x1016_c792, 6); mov(memw_a32[ds, 0x101b_e56c], ax);     /* mov [0x101be56c], ax */
            ii(0x1016_c798, 5); mov(ebx, 0x5048_4152);                  /* mov ebx, 0x50484152 */
            ii(0x1016_c79d, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1016_c79f, 2); mov(ah, 0x30);                          /* mov ah, 0x30 */
            ii(0x1016_c7a1, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1016_c7a3, 5); mov(memb_a32[ds, 0x101b_e597], al);     /* mov [0x101be597], al */
            ii(0x1016_c7a8, 6); mov(memb_a32[ds, 0x101b_e598], ah);     /* mov [0x101be598], ah */
            ii(0x1016_c7ae, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_c7b0, 2); sub(esi, esi);                          /* sub esi, esi */
            ii(0x1016_c7b2, 5); mov(edi, 0x81);                         /* mov edi, 0x81 */
            ii(0x1016_c7b7, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x1016_c7ba, 4); cmp(ax, 0x4458);                        /* cmp ax, 0x4458 */
            ii(0x1016_c7be, 2); if(jnzd(0x1016_c7fe, 0x3e)) goto l_0x1016_c7fe; /* jnz 0x1016c7fe */
            ii(0x1016_c7c0, 3); sub(bl, 0x30);                          /* sub bl, 0x30 */
            ii(0x1016_c7c3, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1016_c7c5, 2); mov(ah, 0);                             /* mov ah, 0x0 */
            ii(0x1016_c7c7, 1); pushd(eax);                             /* push eax */
            ii(0x1016_c7c8, 7); mov(es, memw_a32[ds, 0x101b_e56c]);     /* mov es, [0x101be56c] */
            ii(0x1016_c7cf, 7); mov(ebx, memd_a32[es, 0x5c]);           /* mov ebx, [es:0x5c] */
            ii(0x1016_c7d6, 6); add(ebx, 0xfff);                        /* add ebx, 0xfff */
            ii(0x1016_c7dc, 6); and(ebx, 0xffff_f000);                  /* and ebx, 0xfffff000 */
            ii(0x1016_c7e2, 6); mov(memd_a32[ds, 0x101b_e560], ebx);    /* mov [0x101be560], ebx */
            ii(0x1016_c7e8, 3); shr(ebx, 0xc);                          /* shr ebx, 0xc */
            ii(0x1016_c7eb, 3); mov(ax, ds);                            /* mov ax, ds */
            ii(0x1016_c7ee, 2); mov(es, eax);                           /* mov es, eax */
            ii(0x1016_c7f0, 2); mov(ah, 0x4a);                          /* mov ah, 0x4a */
            ii(0x1016_c7f2, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1016_c7f4, 1); popd(eax);                              /* pop eax */
            ii(0x1016_c7f5, 3); mov(bx, ds);                            /* mov bx, ds */
            ii(0x1016_c7f8, 4); mov(cx, 0x2c);                          /* mov cx, 0x2c */
            ii(0x1016_c7fc, 2); jmpd(0x1016_c836, 0x38); goto l_0x1016_c836; /* jmp 0x1016c836 */
        l_0x1016_c7fe:
            ii(0x1016_c7fe, 4); cmp(ax, 0x4243);                        /* cmp ax, 0x4243 */
            ii(0x1016_c802, 2); if(jnzd(0x1016_c838, 0x34)) goto l_0x1016_c838; /* jnz 0x1016c838 */
            ii(0x1016_c804, 6); mov(memd_a32[ds, 0x101b_de8c], edx);    /* mov [0x101bde8c], edx */
            ii(0x1016_c80a, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1016_c80c, 3); mov(edx, memd_a32[ds, esi + 0x1c]);     /* mov edx, [esi+0x1c] */
            ii(0x1016_c80f, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1016_c811, 2); sub(ebx, edx);                          /* sub ebx, edx */
            ii(0x1016_c813, 2); mov(ah, 0x4a);                          /* mov ah, 0x4a */
            ii(0x1016_c815, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1016_c817, 3); mov(bx, ds);                            /* mov bx, ds */
            ii(0x1016_c81a, 7); mov(memw_a32[ds, 0x101b_e56c], ds);     /* mov [0x101be56c], ds */
            ii(0x1016_c821, 3); mov(eax, memd_a32[ds, esi + 0x10]);     /* mov eax, [esi+0x10] */
            ii(0x1016_c824, 2); add(edi, eax);                          /* add edi, eax */
            ii(0x1016_c826, 2); sub(esi, esi);                          /* sub esi, esi */
            ii(0x1016_c828, 4); mov(si, memw_a32[ds, eax + 0x2c]);      /* mov si, [eax+0x2c] */
            ii(0x1016_c82c, 3); shl(esi, 0x4);                          /* shl esi, 0x4 */
            ii(0x1016_c82f, 3); mov(cx, ds);                            /* mov cx, ds */
            ii(0x1016_c832, 2); mov(al, 0x9);                           /* mov al, 0x9 */
            ii(0x1016_c834, 2); mov(ah, 0);                             /* mov ah, 0x0 */
        l_0x1016_c836:
            ii(0x1016_c836, 2); jmpd(0x1016_c891, 0x59); goto l_0x1016_c891; /* jmp 0x1016c891 */
        l_0x1016_c838:
            ii(0x1016_c838, 4); mov(dx, 0x78);                          /* mov dx, 0x78 */
            ii(0x1016_c83c, 4); mov(ax, 0xff00);                        /* mov ax, 0xff00 */
            ii(0x1016_c840, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1016_c842, 2); cmp(al, 0);                             /* cmp al, 0x0 */
            ii(0x1016_c844, 2); if(jzd(0x1016_c87a, 0x34)) goto l_0x1016_c87a; /* jz 0x1016c87a */
            ii(0x1016_c846, 3); mov(ax, gs);                            /* mov ax, gs */
            ii(0x1016_c849, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1016_c84d, 2); if(jzd(0x1016_c855, 0x6)) goto l_0x1016_c855; /* jz 0x1016c855 */
            ii(0x1016_c84f, 6); mov(memw_a32[ds, 0x101b_de90], ax);     /* mov [0x101bde90], ax */
        l_0x1016_c855:
            ii(0x1016_c855, 4); mov(ax, 0x6);                           /* mov ax, 0x6 */
            ii(0x1016_c859, 3); mov(bx, ds);                            /* mov bx, ds */
            ii(0x1016_c85c, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1016_c85e, 2); mov(al, 0x1);                           /* mov al, 0x1 */
            ii(0x1016_c860, 2); mov(ah, 0);                             /* mov ah, 0x0 */
            ii(0x1016_c862, 3); or(dx, cx);                             /* or dx, cx */
            ii(0x1016_c865, 2); if(jzd(0x1016_c869, 0x2)) goto l_0x1016_c869; /* jz 0x1016c869 */
            ii(0x1016_c867, 2); mov(ah, 0x1);                           /* mov ah, 0x1 */
        l_0x1016_c869:
            ii(0x1016_c869, 7); mov(memw_a32[ds, 0x101b_e56c], es);     /* mov [0x101be56c], es */
            ii(0x1016_c870, 8); mov(cx, memw_a32[es, 0x2c]);            /* mov cx, [es:0x2c] */
            ii(0x1016_c878, 2); jmpd(0x1016_c891, 0x17); goto l_0x1016_c891; /* jmp 0x1016c891 */
        l_0x1016_c87a:
            ii(0x1016_c87a, 3); mov(dx, ds);                            /* mov dx, ds */
            ii(0x1016_c87d, 4); mov(cx, 0x24);                          /* mov cx, 0x24 */
            ii(0x1016_c881, 2); mov(ds, ecx);                           /* mov ds, ecx */
            ii(0x1016_c883, 4); mov(cx, 0x2c);                          /* mov cx, 0x2c */
            ii(0x1016_c887, 2); mov(ds, edx);                           /* mov ds, edx */
            ii(0x1016_c889, 4); mov(bx, 0x17);                          /* mov bx, 0x17 */
            ii(0x1016_c88d, 2); mov(al, 0);                             /* mov al, 0x0 */
            ii(0x1016_c88f, 2); mov(ah, 0);                             /* mov ah, 0x0 */
        l_0x1016_c891:
            ii(0x1016_c891, 5); mov(memb_a32[ds, 0x101b_e58e], al);     /* mov [0x101be58e], al */
            ii(0x1016_c896, 6); mov(memb_a32[ds, 0x101b_e58f], ah);     /* mov [0x101be58f], ah */
            ii(0x1016_c89c, 2); mov(es, ebx);                           /* mov es, ebx */
            ii(0x1016_c89e, 8); mov(memw_a32[es, /* sys */ 0x1016_c9d9], ds); /* mov [es:0x1016c9d9], ds */
            ii(0x1016_c8a6, 6); mov(memd_a32[ds, 0x101b_e591], esi);    /* mov [0x101be591], esi */
            ii(0x1016_c8ac, 7); mov(memw_a32[ds, 0x101b_e595], cx);     /* mov [0x101be595], cx */
            ii(0x1016_c8b3, 1); pushd(esi);                             /* push esi */
            ii(0x1016_c8b4, 7); mov(es, memw_a32[ds, 0x101b_e56c]);     /* mov es, [0x101be56c] */
            ii(0x1016_c8bb, 6); mov(edx, 0x1020_c170);                  /* mov edx, 0x1020c170 */
            ii(0x1016_c8c1, 3); add(edx, 0xf);                          /* add edx, 0xf */
            ii(0x1016_c8c4, 3); and(dl, 0xf0);                          /* and dl, 0xf0 */
            ii(0x1016_c8c7, 2); sub(ecx, ecx);                          /* sub ecx, ecx */
            ii(0x1016_c8c9, 4); mov(cl, memb_a32[es, edi - 0x1]);       /* mov cl, [es:edi-0x1] */
            ii(0x1016_c8cd, 1); cld();                                  /* cld */
            ii(0x1016_c8ce, 2); mov(al, 0x20);                          /* mov al, 0x20 */
            ii(0x1016_c8d0, 2); repe_a32(() => scasb_a32());            /* repe scasb */
            ii(0x1016_c8d2, 3); lea(esi, edi - 0x1);                    /* lea esi, [edi-0x1] */
            ii(0x1016_c8d5, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1016_c8d7, 3); mov(bx, es);                            /* mov bx, es */
            ii(0x1016_c8da, 3); mov(dx, ds);                            /* mov dx, ds */
            ii(0x1016_c8dd, 2); mov(ds, ebx);                           /* mov ds, ebx */
            ii(0x1016_c8df, 2); mov(es, edx);                           /* mov es, edx */
            ii(0x1016_c8e1, 2); if(jzd(0x1016_c8e6, 0x3)) goto l_0x1016_c8e6; /* jz 0x1016c8e6 */
            ii(0x1016_c8e3, 1); inc(ecx);                               /* inc ecx */
            ii(0x1016_c8e4, 2); rep_a32(() => movsb_a32());             /* rep movsb */
        l_0x1016_c8e6:
            ii(0x1016_c8e6, 2); sub(al, al);                            /* sub al, al */
            ii(0x1016_c8e8, 1); stosb_a32();                            /* stosb */
            ii(0x1016_c8e9, 1); stosb_a32();                            /* stosb */
            ii(0x1016_c8ea, 1); popd(esi);                              /* pop esi */
            ii(0x1016_c8eb, 1); dec(edi);                               /* dec edi */
            ii(0x1016_c8ec, 1); pushd(edi);                             /* push edi */
            ii(0x1016_c8ed, 1); pushd(edx);                             /* push edx */
            ii(0x1016_c8ee, 8); mov(ds, memw_a32[es, 0x101b_e595]);     /* mov ds, [es:0x101be595] */
            ii(0x1016_c8f6, 2); sub(ebp, ebp);                          /* sub ebp, ebp */
        l_0x1016_c8f8:
            ii(0x1016_c8f8, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1016_c8fa, 5); or(eax, 0x2020_2020);                   /* or eax, 0x20202020 */
            ii(0x1016_c8ff, 5); cmp(eax, 0x3738_6f6e);                  /* cmp eax, 0x37386f6e */
            ii(0x1016_c904, 2); if(jnzd(0x1016_c90d, 0x7)) goto l_0x1016_c90d; /* jnz 0x1016c90d */
            ii(0x1016_c906, 4); cmp(memb_a32[ds, esi + 0x4], 0x3d);     /* cmp byte [esi+0x4], 0x3d */
            ii(0x1016_c90a, 2); if(jnzd(0x1016_c90d, 0x1)) goto l_0x1016_c90d; /* jnz 0x1016c90d */
            ii(0x1016_c90c, 1); inc(ebp);                               /* inc ebp */
        l_0x1016_c90d:
            ii(0x1016_c90d, 3); cmp(memb_a32[ds, esi], 0);              /* cmp byte [esi], 0x0 */
            ii(0x1016_c910, 1); lodsb_a32();                            /* lodsb */
            ii(0x1016_c911, 2); if(jnzd(0x1016_c90d, -0x6)) goto l_0x1016_c90d; /* jnz 0x1016c90d */
            ii(0x1016_c913, 3); cmp(memb_a32[ds, esi], 0);              /* cmp byte [esi], 0x0 */
            ii(0x1016_c916, 2); if(jnzd(0x1016_c8f8, -0x20)) goto l_0x1016_c8f8; /* jnz 0x1016c8f8 */
            ii(0x1016_c918, 1); lodsb_a32();                            /* lodsb */
            ii(0x1016_c919, 1); inc(esi);                               /* inc esi */
            ii(0x1016_c91a, 1); inc(esi);                               /* inc esi */
        l_0x1016_c91b:
            ii(0x1016_c91b, 3); cmp(memb_a32[ds, esi], 0);              /* cmp byte [esi], 0x0 */
            ii(0x1016_c91e, 1); movsb_a32();                            /* movsb */
            ii(0x1016_c91f, 2); if(jnzd(0x1016_c91b, -0x6)) goto l_0x1016_c91b; /* jnz 0x1016c91b */
            ii(0x1016_c921, 1); popd(ds);                               /* pop ds */
            ii(0x1016_c922, 1); popd(esi);                              /* pop esi */
            ii(0x1016_c923, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1016_c925, 7); mov(memw_a32[ds, 0x101b_e58c], bp);     /* mov [0x101be58c], bp */
            ii(0x1016_c92c, 6); mov(memd_a32[ds, 0x101b_e570], edi);    /* mov [0x101be570], edi */
            ii(0x1016_c932, 6); mov(memd_a32[ds, 0x101b_e55c], ebx);    /* mov [0x101be55c], ebx */
            ii(0x1016_c938, 6); mov(ecx, 0x1020_c170);                  /* mov ecx, 0x1020c170 */
            ii(0x1016_c93e, 6); mov(edi, 0x101c_3180);                  /* mov edi, 0x101c3180 */
            ii(0x1016_c944, 2); sub(ecx, edi);                          /* sub ecx, edi */
            ii(0x1016_c946, 7); cmp(memb_a32[ds, 0x101b_e58e], 0x1);    /* cmp byte [0x101be58e], 0x1 */
            ii(0x1016_c94d, 2); if(jnzd(0x1016_c95c, 0xd)) goto l_0x1016_c95c; /* jnz 0x1016c95c */
            ii(0x1016_c94f, 6); cmp(ecx, 0x1000);                       /* cmp ecx, 0x1000 */
            ii(0x1016_c955, 2); if(jbed(0x1016_c95c, 0x5)) goto l_0x1016_c95c; /* jbe 0x1016c95c */
            ii(0x1016_c957, 5); mov(ecx, 0x1000);                       /* mov ecx, 0x1000 */
        l_0x1016_c95c:
            ii(0x1016_c95c, 2); mov(dl, cl);                            /* mov dl, cl */
            ii(0x1016_c95e, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1016_c961, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1016_c963, 2); rep_a32(() => stosd_a32());             /* rep stosd */
            ii(0x1016_c965, 2); mov(cl, dl);                            /* mov cl, dl */
            ii(0x1016_c967, 3); and(cl, 0x3);                           /* and cl, 0x3 */
            ii(0x1016_c96a, 2); rep_a32(() => stosb_a32());             /* rep stosb */
            ii(0x1016_c96c, 6); mov(eax, 0x1020_c170);                  /* mov eax, 0x1020c170 */
            ii(0x1016_c972, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1016_c975, 2); and(al, 0xf0);                          /* and al, 0xf0 */
            ii(0x1016_c977, 5); mov(memd_a32[ds, 0x101b_e564], eax);    /* mov [0x101be564], eax */
            ii(0x1016_c97c, 6); mov(memd_a32[ds, 0x101b_e568], esi);    /* mov [0x101be568], esi */
            ii(0x1016_c982, 5); mov(eax, 0xff);                         /* mov eax, 0xff */
            ii(0x1016_c987, 5); calld(/* sys */ 0x1018_7e72, 0x1_b4e6); /* call 0x10187e72 */
            ii(0x1016_c98c, 2); sub(ebp, ebp);                          /* sub ebp, ebp */
            ii(0x1016_c98e, 5); calld(/* sys */ 0x1018_7e22, 0x1_b48f); /* call 0x10187e22 */
        }
    }
}
