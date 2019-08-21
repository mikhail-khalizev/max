using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_fb9c-4a4f4edf")]
        public void Method_0018_fb9c()
        {
            ii(0x18_fb9c, 2); pushad();                                 /* pushad */
            ii(0x18_fb9e, 1); pushw(ds);                                /* push ds */
            ii(0x18_fb9f, 1); pushw(es);                                /* push es */
            ii(0x18_fba0, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x18_fba2, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x18_fba4, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x18_fba6, 3); mov(esi, esp);                            /* mov esi, esp */
            ii(0x18_fba9, 4); lar(eax, ax);                             /* lar eax, ax */
            ii(0x18_fbad, 5); bt(eax, 0x16);                            /* bt eax, 0x16 */
            ii(0x18_fbb2, 2); if(jbw(0x18_fbb8, 0x4)) goto l_0x18_fbb8; /* jb 0xfbb8 */
            ii(0x18_fbb4, 4); movzx(esi, si);                           /* movzx esi, si */
        l_0x18_fbb8:
            ii(0x18_fbb8, 5); lea(esp, esi - 0x10);                     /* lea esp, [esi-0x10] */
            ii(0x18_fbbd, 3); mov(edi, esp);                            /* mov edi, esp */
            ii(0x18_fbc0, 6); mov(ecx, 0x11);                           /* mov ecx, 0x11 */
            ii(0x18_fbc6, 1); cld();                                    /* cld */
            ii(0x18_fbc7, 3); rep_a16(() => movsd_a16());               /* rep movsd */
            ii(0x18_fbca, 1); movsw_a16();                              /* movsw */
            ii(0x18_fbcb, 3); mov(ebp, esp);                            /* mov ebp, esp */
            ii(0x18_fbce, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x18_fbd1, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x18_fbd3, 5); mov(edi, memd_a32[ss, ebp + 0x3e]);       /* mov edi, [ebp+0x3e] */
            ii(0x18_fbd8, 4); mov(ax, memw_a32[ss, ebp + 0x42]);        /* mov ax, [ebp+0x42] */
            ii(0x18_fbdc, 4); mov(bx, memw_a32[ss, ebp + 0x24]);        /* mov bx, [ebp+0x24] */
            ii(0x18_fbe0, 3); mov(bl, memb_a16[cs, bx]);                /* mov bl, [cs:bx] */
            ii(0x18_fbe3, 3); cmp(bl, 0xc);                             /* cmp bl, 0xc */
            ii(0x18_fbe6, 4); if(jnzw(0x18_fbf4, 0xa)) goto l_0x18_fbf4; /* jnz 0xfbf4 */
            ii(0x18_fbea, 4); mov(memw_a16[es, 0xa4e], ax);             /* mov [es:0xa4e], ax */
            ii(0x18_fbee, 6); mov(memd_a16[es, 0xa4a], edi);            /* mov [es:0xa4a], edi */
        l_0x18_fbf4:
            ii(0x18_fbf4, 2); mov(bh, 0x1);                             /* mov bh, 0x1 */
            ii(0x18_fbf6, 5); cmp(memb_a16[es, bx + 0x2], bh);          /* cmp [es:bx+0x2], bh */
            ii(0x18_fbfb, 4); if(jzw(0x18_fca1, 0xa2)) goto l_0x18_fca1; /* jz 0xfca1 */
            ii(0x18_fbff, 4); lar(ebx, ax);                             /* lar ebx, ax */
            ii(0x18_fc03, 4); if(jnzw(0x18_fc2b, 0x24)) goto l_0x18_fc2b; /* jnz 0xfc2b */
            ii(0x18_fc07, 5); bt(ebx, 0x16);                            /* bt ebx, 0x16 */
            ii(0x18_fc0c, 2); if(jbw(0x18_fc14, 0x6)) goto l_0x18_fc14; /* jb 0xfc14 */
            ii(0x18_fc0e, 4); movzx(edi, di);                           /* movzx edi, di */
            ii(0x18_fc12, 2); xchg(bx, bx);                             /* xchg bx, bx */
        l_0x18_fc14:
            ii(0x18_fc14, 3); and(bh, 0xa);                             /* and bh, 0xa */
            ii(0x18_fc17, 3); cmp(bh, 0x2);                             /* cmp bh, 0x2 */
            ii(0x18_fc1a, 4); if(jnzw(0x18_fc2b, 0xd)) goto l_0x18_fc2b; /* jnz 0xfc2b */
            ii(0x18_fc1e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x18_fc20, 4); lsl(ebx, ax);                             /* lsl ebx, ax */
            ii(0x18_fc24, 3); cmp(edi, ebx);                            /* cmp edi, ebx */
            ii(0x18_fc27, 4); if(jbew(0x18_fc48, 0x1d)) goto l_0x18_fc48; /* jbe 0xfc48 */
        l_0x18_fc2b:
            ii(0x18_fc2b, 3); mov(bx, 0xa8);                            /* mov bx, 0xa8 */
            ii(0x18_fc2e, 4); mov(memw_a32[ss, ebp + 0x42], bx);        /* mov [ebp+0x42], bx */
            ii(0x18_fc32, 2); mov(ds, bx);                              /* mov ds, bx */
            ii(0x18_fc34, 3); mov(memw_a16[ds, 0xa4e], ax);             /* mov [0xa4e], ax */
            ii(0x18_fc37, 5); mov(memd_a16[ds, 0xa4a], edi);            /* mov [0xa4a], edi */
            ii(0x18_fc3c, 5); mov(edi, memd_a16[ds, 0xa46]);            /* mov edi, [0xa46] */
            ii(0x18_fc41, 5); mov(memd_a16[ds, 0xa42], edi);            /* mov [0xa42], edi */
            ii(0x18_fc46, 2); xchg(bx, bx);                             /* xchg bx, bx */
        l_0x18_fc48:
            ii(0x18_fc48, 4); sub(edi, 0x10);                           /* sub edi, 0x10 */
            ii(0x18_fc4c, 5); mov(eax, memd_a32[ss, ebp + 0x2e]);       /* mov eax, [ebp+0x2e] */
            ii(0x18_fc51, 4); mov(memd_a32[ds, edi], eax);              /* mov [edi], eax */
            ii(0x18_fc55, 5); mov(eax, memd_a32[ss, ebp + 0x32]);       /* mov eax, [ebp+0x32] */
            ii(0x18_fc5a, 5); mov(memd_a32[ds, edi + 0x4], eax);        /* mov [edi+0x4], eax */
            ii(0x18_fc5f, 4); mov(ax, memw_a32[ss, ebp + 0x36]);        /* mov ax, [ebp+0x36] */
            ii(0x18_fc63, 4); mov(memw_a32[ds, edi + 0x8], ax);         /* mov [edi+0x8], ax */
            ii(0x18_fc67, 5); mov(eax, memd_a32[ss, ebp + 0x3a]);       /* mov eax, [ebp+0x3a] */
            ii(0x18_fc6c, 3); and(ah, 0xfe);                            /* and ah, 0xfe */
            ii(0x18_fc6f, 5); mov(memd_a32[ds, edi + 0xc], eax);        /* mov [edi+0xc], eax */
            ii(0x18_fc74, 4); sub(edi, 0x2);                            /* sub edi, 0x2 */
            ii(0x18_fc78, 4); mov(bx, memw_a32[ss, ebp + 0x24]);        /* mov bx, [ebp+0x24] */
            ii(0x18_fc7c, 3); mov(memw_a32[ds, edi], bx);               /* mov [edi], bx */
            ii(0x18_fc7f, 4); mov(memw_a32[ss, ebp + 0x36], cs);        /* mov [ebp+0x36], cs */
            ii(0x18_fc83, 3); sub(eax, eax);                            /* sub eax, eax */
            ii(0x18_fc86, 3); mov(ax, 0x5b4);                           /* mov ax, 0x5b4 */
            ii(0x18_fc89, 5); mov(memd_a32[ss, ebp + 0x32], eax);       /* mov [ebp+0x32], eax */
            ii(0x18_fc8e, 5); and(memb_a32[ss, ebp + 0x3b], -0x4 /* 0xfc */); /* and byte [ebp+0x3b], 0xfc */
            ii(0x18_fc93, 5); mov(memd_a32[ss, ebp + 0x3e], edi);       /* mov [ebp+0x3e], edi */
            ii(0x18_fc98, 1); popw(es);                                 /* pop es */
            ii(0x18_fc99, 1); popw(ds);                                 /* pop ds */
            ii(0x18_fc9a, 2); popad();                                  /* popad */
            ii(0x18_fc9c, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x18_fc9f, 2); retfd(); return;                          /* o32 retf */
        l_0x18_fca1:
            ii(0x18_fca1, 2); sub(bh, bh);                              /* sub bh, bh */
            ii(0x18_fca3, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x18_fca6, 4); add(bx, 0x942);                           /* add bx, 0x942 */
            ii(0x18_fcaa, 6); movzx(eax, memw_a16[es, bx + 0x4]);       /* movzx eax, word [es:bx+0x4] */
            ii(0x18_fcb0, 5); xchg(memd_a32[ss, ebp + 0x20], eax);      /* xchg [ebp+0x20], eax */
            ii(0x18_fcb5, 4); mov(ecx, memd_a16[es, bx]);               /* mov ecx, [es:bx] */
            ii(0x18_fcb9, 5); xchg(memd_a32[ss, ebp + 0x1c], ecx);      /* xchg [ebp+0x1c], ecx */
            ii(0x18_fcbe, 1); popw(es);                                 /* pop es */
            ii(0x18_fcbf, 1); popw(ds);                                 /* pop ds */
            ii(0x18_fcc0, 2); popd(edi);                                /* pop edi */
            ii(0x18_fcc2, 2); popd(esi);                                /* pop esi */
            ii(0x18_fcc4, 2); popd(ebp);                                /* pop ebp */
            ii(0x18_fcc6, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x18_fcc9, 2); popd(edx);                                /* pop edx */
            ii(0x18_fccb, 2); popd(ebx);                                /* pop ebx */
            ii(0x18_fccd, 4); retfd(0x2); return;                       /* o32 retf 0x2 */
        }
    }
}
