using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_fa00-bc95f066")]
        public void Method_0018_fa00()
        {
            ii(0x18_fa00, 2); pushd(ebp);                               /* push ebp */
            ii(0x18_fa02, 2); pushd(ebp);                               /* push ebp */
            ii(0x18_fa04, 3); mov(ebp, esp);                            /* mov ebp, esp */
            ii(0x18_fa07, 2); pushd(ebx);                               /* push ebx */
            ii(0x18_fa09, 1); pushw(ds);                                /* push ds */
            ii(0x18_fa0a, 3); mov(bx, 0xa8);                            /* mov bx, 0xa8 */
            ii(0x18_fa0d, 2); mov(ds, bx);                              /* mov ds, bx */
            ii(0x18_fa0f, 2); mov(bx, ss);                              /* mov bx, ss */
            ii(0x18_fa11, 4); lar(ebx, bx);                             /* lar ebx, bx */
            ii(0x18_fa15, 5); bt(ebx, 0x16);                            /* bt ebx, 0x16 */
            ii(0x18_fa1a, 2); if(jbw(0x18_fa20, 0x4)) goto l_0x18_fa20; /* jb 0xfa20 */
            ii(0x18_fa1c, 4); movzx(ebp, bp);                           /* movzx ebp, bp */
        l_0x18_fa20:
            ii(0x18_fa20, 4); mov(bx, memw_a32[ss, ebp + 0x8]);         /* mov bx, [ebp+0x8] */
            ii(0x18_fa24, 4); mov(memw_a32[ss, ebp + 0x4], bx);         /* mov [ebp+0x4], bx */
            ii(0x18_fa28, 3); mov(bl, memb_a16[cs, bx]);                /* mov bl, [cs:bx] */
            ii(0x18_fa2b, 2); sub(bh, bh);                              /* sub bh, bh */
            ii(0x18_fa2d, 5); cmp(memb_a16[ds, bx + 0x2], 0x1);         /* cmp byte [bx+0x2], 0x1 */
            ii(0x18_fa32, 2); if(jzw_func(0x18_f9dc, -0x58)) return;    /* jz 0xf9dc */
            ii(0x18_fa34, 9); mov(memd_a32[ss, ebp + 0x6], 0);          /* mov dword [ebp+0x6], 0x0 */
            ii(0x18_fa3d, 1); popw(ds);                                 /* pop ds */
            ii(0x18_fa3e, 2); popd(ebx);                                /* pop ebx */
            ii(0x18_fa40, 2); popd(ebp);                                /* pop ebp */
            ii(0x18_fa42, 2); xchg(bx, bx);                             /* xchg bx, bx */
            ii(0x18_fa44, 1); cld();                                    /* cld */
            ii(0x18_fa45, 1); pushw(ds);                                /* push ds */
            ii(0x18_fa46, 2); pushd(esi);                               /* push esi */
            ii(0x18_fa48, 3); mov(si, 0xa8);                            /* mov si, 0xa8 */
            ii(0x18_fa4b, 2); mov(ds, si);                              /* mov ds, si */
            ii(0x18_fa4d, 1); pushw(ax);                                /* push ax */
            ii(0x18_fa4e, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x18_fa50, 2); cmp(ax, si);                              /* cmp ax, si */
            ii(0x18_fa52, 5); mov(esi, memd_a16[ds, 0xa42]);            /* mov esi, [0xa42] */
            ii(0x18_fa57, 2); if(jzw(0x18_fa5f, 0x6)) goto l_0x18_fa5f; /* jz 0xfa5f */
            ii(0x18_fa59, 4); cmp(ax, memw_a16[ds, 0]);                 /* cmp ax, [0x0] */
            ii(0x18_fa5d, 2); if(jnzw(0x18_fa6c, 0xd)) goto l_0x18_fa6c; /* jnz 0xfa6c */
        l_0x18_fa5f:
            ii(0x18_fa5f, 2); cmp(si, sp);                              /* cmp si, sp */
            ii(0x18_fa61, 2); if(jbw(0x18_fa6c, 0x9)) goto l_0x18_fa6c; /* jb 0xfa6c */
            ii(0x18_fa63, 4); movzx(esi, sp);                           /* movzx esi, sp */
            ii(0x18_fa67, 4); add(si, 0x24c);                           /* add si, 0x24c */
            ii(0x18_fa6b, 1); nop();                                    /* nop */
        l_0x18_fa6c:
            ii(0x18_fa6c, 4); sub(si, 0x2c8);                           /* sub si, 0x2c8 */
            ii(0x18_fa70, 1); popw(ax);                                 /* pop ax */
            ii(0x18_fa71, 4); cmp(si, 0x4b50);                          /* cmp si, 0x4b50 */
            ii(0x18_fa75, 2); if(jbew_func(0x18_f9fc, -0x7b)) return;   /* jbe 0xf9fc */
            ii(0x18_fa77, 4); pushw(memw_a16[ds, 0xa42]);               /* push word [0xa42] */
            ii(0x18_fa7b, 3); and(si, -0x4 /* 0xfc */);                 /* and si, 0xfffc */
            ii(0x18_fa7e, 5); mov(memd_a16[ds, 0xa42], esi);            /* mov [0xa42], esi */
            ii(0x18_fa83, 2); popw(memw_a16[ds, si]);                   /* pop word [si] */
            ii(0x18_fa85, 4); popd(memd_a16[ds, si + 0x10]);            /* pop dword [si+0x10] */
            ii(0x18_fa89, 3); popw(memw_a16[ds, si + 0x4]);             /* pop word [si+0x4] */
            ii(0x18_fa8c, 4); mov(memd_a16[ds, si + 0x28], eax);        /* mov [si+0x28], eax */
            ii(0x18_fa90, 4); mov(memd_a16[ds, si + 0x1c], ebx);        /* mov [si+0x1c], ebx */
            ii(0x18_fa94, 4); mov(memd_a16[ds, si + 0x24], ecx);        /* mov [si+0x24], ecx */
            ii(0x18_fa98, 4); mov(memd_a16[ds, si + 0x20], edx);        /* mov [si+0x20], edx */
            ii(0x18_fa9c, 4); mov(memd_a16[ds, si + 0xc], edi);         /* mov [si+0xc], edi */
            ii(0x18_faa0, 4); mov(memd_a16[ds, si + 0x14], ebp);        /* mov [si+0x14], ebp */
            ii(0x18_faa4, 3); mov(memw_a16[ds, si + 0x6], es);          /* mov [si+0x6], es */
            ii(0x18_faa7, 3); mov(memw_a16[ds, si + 0x8], fs);          /* mov [si+0x8], fs */
            ii(0x18_faaa, 3); mov(memw_a16[ds, si + 0xa], gs);          /* mov [si+0xa], gs */
            ii(0x18_faad, 3); mov(memw_a16[ds, si + 0x2], ss);          /* mov [si+0x2], ss */
            ii(0x18_fab0, 1); popw(bx);                                 /* pop bx */
            ii(0x18_fab1, 4); popd(memd_a16[ds, si + 0x2e]);            /* pop dword [si+0x2e] */
            ii(0x18_fab5, 4); popd(memd_a16[ds, si + 0x32]);            /* pop dword [si+0x32] */
            ii(0x18_fab9, 4); popd(memd_a16[ds, si + 0x36]);            /* pop dword [si+0x36] */
            ii(0x18_fabd, 4); popd(memd_a16[ds, si + 0x3a]);            /* pop dword [si+0x3a] */
            ii(0x18_fac1, 3); mov(eax, esp);                            /* mov eax, esp */
            ii(0x18_fac4, 2); mov(cx, ss);                              /* mov cx, ss */
            ii(0x18_fac6, 4); lar(ecx, cx);                             /* lar ecx, cx */
            ii(0x18_faca, 5); bt(ecx, 0x16);                            /* bt ecx, 0x16 */
            ii(0x18_facf, 2); if(jbw(0x18_fad8, 0x7)) goto l_0x18_fad8; /* jb 0xfad8 */
            ii(0x18_fad1, 4); movzx(eax, ax);                           /* movzx eax, ax */
            ii(0x18_fad5, 2); xchg(bx, bx);                             /* xchg bx, bx */
            ii(0x18_fad7, 1); nop();                                    /* nop */
        l_0x18_fad8:
            ii(0x18_fad8, 4); mov(memd_a16[ds, si + 0x18], eax);        /* mov [si+0x18], eax */
            ii(0x18_fadc, 3); mov(al, memb_a16[cs, bx]);                /* mov al, [cs:bx] */
            ii(0x18_fadf, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x18_fae1, 3); mov(memw_a16[ds, si + 0x2c], ax);         /* mov [si+0x2c], ax */
            ii(0x18_fae4, 4); cmp(bx, 0x400);                           /* cmp bx, 0x400 */
            ii(0x18_fae8, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x18_faea, 4); if(jbw(0x18_fb08, 0x1a)) goto l_0x18_fb08; /* jb 0xfb08 */
            ii(0x18_faee, 2); inc(bh);                                  /* inc bh */
            ii(0x18_faf0, 3); cmp(bl, 0xc);                             /* cmp bl, 0xc */
            ii(0x18_faf3, 4); if(jnzw(0x18_fb08, 0x11)) goto l_0x18_fb08; /* jnz 0xfb08 */
            ii(0x18_faf7, 4); mov(eax, memd_a16[ds, 0xa4a]);            /* mov eax, [0xa4a] */
            ii(0x18_fafb, 4); mov(memd_a16[ds, si + 0x18], eax);        /* mov [si+0x18], eax */
            ii(0x18_faff, 3); mov(ax, memw_a16[ds, 0xa4e]);             /* mov ax, [0xa4e] */
            ii(0x18_fb02, 3); mov(memw_a16[ds, si + 0x2], ax);          /* mov [si+0x2], ax */
            ii(0x18_fb05, 2); xchg(bx, bx);                             /* xchg bx, bx */
            ii(0x18_fb07, 1); nop();                                    /* nop */
        l_0x18_fb08:
            ii(0x18_fb08, 2); mov(ax, ds);                              /* mov ax, ds */
            ii(0x18_fb0a, 2); mov(ss, ax);                              /* mov ss, ax */
            ii(0x18_fb0c, 3); mov(esp, esi);                            /* mov esp, esi */
            ii(0x18_fb0f, 4); mov(di, memw_a16[ds, 0xa70]);             /* mov di, [0xa70] */
            ii(0x18_fb13, 3); cmp(di, 0x3);                             /* cmp di, 0x3 */
            ii(0x18_fb16, 4); if(jaw(0x18_fb3c, 0x22)) goto l_0x18_fb3c; /* ja 0xfb3c */
            ii(0x18_fb1a, 4); inc(memb_a16[ds, 0xa70]);                 /* inc byte [0xa70] */
            ii(0x18_fb1e, 5); and(memb_a16[ds, 0xa70], 0x3);            /* and byte [0xa70], 0x3 */
            ii(0x18_fb23, 3); shl(di, 0x3);                             /* shl di, 0x3 */
            ii(0x18_fb26, 4); mov(memb_a16[ds, di + 0xa50], bl);        /* mov [di+0xa50], bl */
            ii(0x18_fb2a, 3); mov(ax, memw_a16[ds, si + 0x36]);         /* mov ax, [si+0x36] */
            ii(0x18_fb2d, 4); mov(memw_a16[ds, di + 0xa52], ax);        /* mov [di+0xa52], ax */
            ii(0x18_fb31, 4); mov(eax, memd_a16[ds, si + 0x32]);        /* mov eax, [si+0x32] */
            ii(0x18_fb35, 5); mov(memd_a16[ds, di + 0xa54], eax);       /* mov [di+0xa54], eax */
            ii(0x18_fb3a, 2); xchg(bx, bx);                             /* xchg bx, bx */
        l_0x18_fb3c:
            ii(0x18_fb3c, 3); mov(ebp, esi);                            /* mov ebp, esi */
            ii(0x18_fb3f, 1); pushw(si);                                /* push si */
            ii(0x18_fb40, 5); movzx(ax, memb_a16[ds, bx + 0x2]);        /* movzx ax, byte [bx+0x2] */
            ii(0x18_fb45, 3); shl(ax, 0x3);                             /* shl ax, 0x3 */
            ii(0x18_fb48, 1); pushw(ax);                                /* push ax */
            ii(0x18_fb49, 1); nop();                                    /* nop */
            ii(0x18_fb4a, 1); pushw(cs);                                /* push cs */
            ii(0x18_fb4b, 3); callw(0x19_0074, 0x526);                  /* call 0x74 */
            ii(0x18_fb4e, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x18_fb51, 4); movzx(esi, bp);                           /* movzx esi, bp */
            ii(0x18_fb55, 3); mov(es, memw_a16[ds, si + 0x2]);          /* mov es, [si+0x2] */
            ii(0x18_fb58, 4); mov(edi, memd_a16[ds, si + 0x18]);        /* mov edi, [si+0x18] */
            ii(0x18_fb5c, 4); sub(edi, 0x3a);                           /* sub edi, 0x3a */
            ii(0x18_fb60, 4); movzx(eax, memw_a16[ds, si]);             /* movzx eax, word [si] */
            ii(0x18_fb64, 2); mov(bx, es);                              /* mov bx, es */
            ii(0x18_fb66, 3); mov(ebp, edi);                            /* mov ebp, edi */
            ii(0x18_fb69, 4); add(si, 0x4);                             /* add si, 0x4 */
            ii(0x18_fb6d, 1); cld();                                    /* cld */
            ii(0x18_fb6e, 6); mov(ecx, 0xe);                            /* mov ecx, 0xe */
            ii(0x18_fb74, 4); rep_a32(() => movsd_a32());               /* a32 rep movsd */
            ii(0x18_fb78, 2); nop();                                    /* a32 nop */
            ii(0x18_fb7a, 2); movsw_a32();                              /* a32 movsw */
            ii(0x18_fb7c, 2); mov(ss, bx);                              /* mov ss, bx */
            ii(0x18_fb7e, 3); mov(esp, ebp);                            /* mov esp, ebp */
            ii(0x18_fb81, 4); mov(memd_a16[ds, 0xa42], eax);            /* mov [0xa42], eax */
            ii(0x18_fb85, 5); test(memb_a32[ss, ebp + 0x37], 0x2);      /* test byte [ebp+0x37], 0x2 */
            ii(0x18_fb8a, 2); if(jzw(0x18_fb8d, 0x1)) goto l_0x18_fb8d; /* jz 0xfb8d */
            ii(0x18_fb8c, 1); sti();                                    /* sti */
        l_0x18_fb8d:
            ii(0x18_fb8d, 1); popw(ds);                                 /* pop ds */
            ii(0x18_fb8e, 1); popw(es);                                 /* pop es */
            ii(0x18_fb8f, 2); popw(fs);                                 /* pop fs */
            ii(0x18_fb91, 2); popw(gs);                                 /* pop gs */
            ii(0x18_fb93, 2); popad();                                  /* popad */
            ii(0x18_fb95, 4); add(esp, 0x6);                            /* add esp, 0x6 */
            ii(0x18_fb99, 2); iretd(); return;                          /* iretd */
        }
    }
}
