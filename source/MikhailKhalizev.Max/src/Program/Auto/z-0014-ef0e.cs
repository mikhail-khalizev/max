using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("98ad5516-2122-4637-8e72-5ce4a07b152a")]
        public void Method_0014_ef0e()
        {
            ii(0x14_ef0e, 3); test(cl, 0x20);                           /* test cl, 0x20 */
            ii(0x14_ef11, 2); if(jzw(0x14_ef15, 0x2)) goto l_0x14_ef15; /* jz 0xef15 */
            ii(0x14_ef13, 2); pushd(eax);                               /* push eax */
        l_0x14_ef15:
            ii(0x14_ef15, 2); pushad();                                 /* pushad */
            ii(0x14_ef17, 1); pushw(ds);                                /* push ds */
            ii(0x14_ef18, 2); mov(bx, ss);                              /* mov bx, ss */
            ii(0x14_ef1a, 1); pushw(es);                                /* push es */
            ii(0x14_ef1b, 4); lar(eax, bx);                             /* lar eax, bx */
            ii(0x14_ef1f, 3); mov(ebp, esp);                            /* mov ebp, esp */
            ii(0x14_ef22, 5); bt(eax, 0x16);                            /* bt eax, 0x16 */
            ii(0x14_ef27, 2); if(jbw(0x14_ef2d, 0x4)) goto l_0x14_ef2d; /* jb 0xef2d */
            ii(0x14_ef29, 4); movzx(ebp, sp);                           /* movzx ebp, sp */
        l_0x14_ef2d:
            ii(0x14_ef2d, 4); mov(dx, memw_a32[ss, ebp + 0x26]);        /* mov dx, [ebp+0x26] */
            ii(0x14_ef31, 4); and(ecx, 0x20);                           /* and ecx, 0x20 */
            ii(0x14_ef35, 2); if(jzw(0x14_ef4a, 0x13)) goto l_0x14_ef4a; /* jz 0xef4a */
            ii(0x14_ef37, 5); xchg(memd_a32[ss, ebp + 0x24], eax);      /* xchg [ebp+0x24], eax */
            ii(0x14_ef3c, 5); xchg(memd_a32[ss, ebp + 0x28], eax);      /* xchg [ebp+0x28], eax */
            ii(0x14_ef41, 5); xchg(memd_a32[ss, ebp + 0x24], eax);      /* xchg [ebp+0x24], eax */
            ii(0x14_ef46, 4); mov(dx, memw_a32[ss, ebp + 0x26]);        /* mov dx, [ebp+0x26] */
        l_0x14_ef4a:
            ii(0x14_ef4a, 4); mov(memw_a32[ss, ebp + 0x1c], dx);        /* mov [ebp+0x1c], dx */
            ii(0x14_ef4e, 1); cld();                                    /* cld */
            ii(0x14_ef4f, 5); mov(cx, memw_a16[cs, 0x4d76]);            /* mov cx, [cs:0x4d76] */
            ii(0x14_ef54, 4); mov(si, memw_a32[ss, ebp + 0x24]);        /* mov si, [ebp+0x24] */
            ii(0x14_ef58, 2); if(jcxzw(0x14_efd2, 0x78)) goto l_0x14_efd2; /* jcxz 0xefd2 */
            ii(0x14_ef5a, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x14_ef5c, 2); pushw(0x20);                              /* push 0x20 */
            ii(0x14_ef5e, 1); popw(ds);                                 /* pop ds */
            ii(0x14_ef5f, 6); add(memw_a16[ds, 0xc16], 0x400);          /* add word [0xc16], 0x400 */
            ii(0x14_ef65, 6); movzx(edi, memw_a16[ds, 0xc16]);          /* movzx edi, word [0xc16] */
            ii(0x14_ef6b, 4); cmp(di, 0x4000);                          /* cmp di, 0x4000 */
            ii(0x14_ef6f, 2); if(jaw(0x14_efcc, 0x5b)) goto l_0x14_efcc; /* ja 0xefcc */
            ii(0x14_ef71, 3); sub(di, 0x2e);                            /* sub di, 0x2e */
            ii(0x14_ef74, 3); lea(ax, si - 0xd);                        /* lea ax, [si-0xd] */
            ii(0x14_ef77, 4); mov(memw_a16[es, di + 0x2a], ax);         /* mov [es:di+0x2a], ax */
            ii(0x14_ef7b, 4); mov(memw_a16[es, di + 0x28], ax);         /* mov [es:di+0x28], ax */
            ii(0x14_ef7f, 4); movzx(eax, di);                           /* movzx eax, di */
            ii(0x14_ef83, 4); xchg(memw_a32[ss, ebp + 0x4], ax);        /* xchg [ebp+0x4], ax */
            ii(0x14_ef87, 1); stosw_a16();                              /* stosw */
            ii(0x14_ef88, 1); inc(si);                                  /* inc si */
            ii(0x14_ef89, 4); mov(memw_a32[ss, ebp + 0x24], si);        /* mov [ebp+0x24], si */
            ii(0x14_ef8d, 3); add(si, -0x14 /* 0xec */);                /* add si, 0xffec */
            ii(0x14_ef90, 3); mov(cx, 0x4);                             /* mov cx, 0x4 */
            ii(0x14_ef93, 3); rep_a16(() => movsw_a16(cs));             /* cs rep movsw */
            ii(0x14_ef96, 3); mov(ax, 0x54a3);                          /* mov ax, 0x54a3 */
            ii(0x14_ef99, 2); stosd_a16();                              /* stosd */
            ii(0x14_ef9b, 2); mov(ax, cs);                              /* mov ax, cs */
            ii(0x14_ef9d, 2); stosd_a16();                              /* stosd */
            ii(0x14_ef9f, 2); mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x14_efa1, 5); lea(esi, ebp + 0x28);                     /* lea esi, [ebp+0x28] */
            ii(0x14_efa6, 5); rep_a32(() => movsd_a32(ss));             /* a32 ss rep movsd */
            ii(0x14_efab, 3); xchg(esi, eax);                           /* a32 xchg esi, eax */
            ii(0x14_efae, 2); stosd_a16();                              /* stosd */
            ii(0x14_efb0, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x14_efb2, 1); stosw_a16();                              /* stosw */
            ii(0x14_efb3, 1); popw(es);                                 /* pop es */
            ii(0x14_efb4, 1); popw(ds);                                 /* pop ds */
            ii(0x14_efb5, 2); popad();                                  /* popad */
            ii(0x14_efb7, 5); mov(ss, memw_a16[cs, 0x4d76]);            /* mov ss, [cs:0x4d76] */
            ii(0x14_efbc, 4); movzx(esp, di);                           /* movzx esp, di */
            ii(0x14_efc0, 1); popw(di);                                 /* pop di */
            ii(0x14_efc1, 2); retfd(); return;                          /* o32 retf */
        //    ii(0x14_efc3, 3); callw(0x14_efe8, 0x22);                   /* call 0xefe8 */
        //    ii(0x14_efc6, 4); add(esp, 0x6);                            /* add esp, 0x6 */
        //    ii(0x14_efca, 2); iretd(); return;                          /* iretd */
        l_0x14_efcc:
            ii(0x14_efcc, 6); sub(memw_a16[ds, 0xc16], 0x400);          /* sub word [0xc16], 0x400 */
        l_0x14_efd2:
            ii(0x14_efd2, 5); add(memw_a32[ss, ebp + 0x24], -0xd /* 0xf3 */); /* add word [ebp+0x24], 0xfff3 */
            ii(0x14_efd7, 5); test(memb_a16[cs, si - 0x5], 0x20);       /* test byte [cs:si-0x5], 0x20 */
            ii(0x14_efdc, 1); popw(es);                                 /* pop es */
            ii(0x14_efdd, 1); popw(ds);                                 /* pop ds */
            ii(0x14_efde, 2); popad();                                  /* popad */
            ii(0x14_efe0, 2); if(jzw(0x14_efe5, 0x3)) goto l_0x14_efe5; /* jz 0xefe5 */
            ii(0x14_efe2, 3); retw(0x6); return;                        /* ret 0x6 */
        l_0x14_efe5:
            ii(0x14_efe5, 3); retw(0x2); return;                        /* ret 0x2 */
        }
    }
}
