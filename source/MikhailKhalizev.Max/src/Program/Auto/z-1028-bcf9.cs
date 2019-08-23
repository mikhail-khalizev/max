using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1028_bcf9-a2d54571")]
        public void Method_1028_bcf9()
        {
            ii(0x1028_bcf9, 2); pusha();                                /* pusha */
            ii(0x1028_bcfb, 1); push(ds);                               /* push ds */
            ii(0x1028_bcfc, 1); pop(es);                                /* pop es */
            ii(0x1028_bcfd, 5); mov(edi, 0x1af9);                       /* mov edi, 0x1af9 */
            ii(0x1028_bd02, 2); mov(al, 0);                             /* mov al, 0x0 */
            ii(0x1028_bd04, 1); stosb();                                /* stosb */
            ii(0x1028_bd05, 6); test(memw[ds, esi + 0x30], 0x200);      /* test word [esi+0x30], 0x200 */
            ii(0x1028_bd0b, 2); if(jz(0x1028_bd10, 0x3)) goto l_0x1028_bd10; /* jz 0x1028bd10 */
            ii(0x1028_bd0d, 2); mov(al, 0x17);                          /* mov al, 0x17 */
            ii(0x1028_bd0f, 1); stosb();                                /* stosb */
        l_0x1028_bd10:
            ii(0x1028_bd10, 6); test(memw[ds, esi + 0x30], 0x400);      /* test word [esi+0x30], 0x400 */
            ii(0x1028_bd16, 2); if(jz(0x1028_bd1b, 0x3)) goto l_0x1028_bd1b; /* jz 0x1028bd1b */
            ii(0x1028_bd18, 2); mov(al, 0x11);                          /* mov al, 0x11 */
            ii(0x1028_bd1a, 1); stosb();                                /* stosb */
        l_0x1028_bd1b:
            ii(0x1028_bd1b, 2); mov(al, 0xa);                           /* mov al, 0xa */
            ii(0x1028_bd1d, 6); test(memw[ds, esi + 0x30], 0x400);      /* test word [esi+0x30], 0x400 */
            ii(0x1028_bd23, 2); if(jz(0x1028_bd27, 0x2)) goto l_0x1028_bd27; /* jz 0x1028bd27 */
            ii(0x1028_bd25, 2); mov(al, 0xa);                           /* mov al, 0xa */
        l_0x1028_bd27:
            ii(0x1028_bd27, 1); stosb();                                /* stosb */
            ii(0x1028_bd28, 2); mov(al, 0x4);                           /* mov al, 0x4 */
            ii(0x1028_bd2a, 1); stosb();                                /* stosb */
            ii(0x1028_bd2b, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1028_bd30, 5); cmp(memw[ds, esi + 0x36], 0x3);         /* cmp word [esi+0x36], 0x3 */
            ii(0x1028_bd35, 2); if(jnz(0x1028_bd3c, 0x5)) goto l_0x1028_bd3c; /* jnz 0x1028bd3c */
            ii(0x1028_bd37, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
        l_0x1028_bd3c:
            ii(0x1028_bd3c, 5); cmp(memw[ds, esi + 0x36], 0x2);         /* cmp word [esi+0x36], 0x2 */
            ii(0x1028_bd41, 6); if(jnz(0x1028_be1d, 0xd6)) goto l_0x1028_be1d; /* jnz 0x1028be1d */
            ii(0x1028_bd47, 6); test(memw[ds, esi + 0x30], 0x20);       /* test word [esi+0x30], 0x20 */
            ii(0x1028_bd4d, 2); if(jz(0x1028_bd61, 0x12)) goto l_0x1028_bd61; /* jz 0x1028bd61 */
            ii(0x1028_bd4f, 2); mov(al, 0x21);                          /* mov al, 0x21 */
            ii(0x1028_bd51, 6); test(memw[ds, esi + 0x30], 0x400);      /* test word [esi+0x30], 0x400 */
            ii(0x1028_bd57, 2); if(jz(0x1028_bd5b, 0x2)) goto l_0x1028_bd5b; /* jz 0x1028bd5b */
            ii(0x1028_bd59, 2); mov(al, 0x21);                          /* mov al, 0x21 */
        l_0x1028_bd5b:
            ii(0x1028_bd5b, 1); stosb();                                /* stosb */
            ii(0x1028_bd5c, 2); jmp(0x1028_bd6e, 0x10); goto l_0x1028_bd6e; /* jmp 0x1028bd6e */
        //  ii(0x1028_bd5e, 1); nop();                                  /* nop */
        //  ii(0x1028_bd5f, 1); nop();                                  /* nop */
        //  ii(0x1028_bd60, 1); nop();                                  /* nop */
        l_0x1028_bd61:
            ii(0x1028_bd61, 2); mov(al, 0xf);                           /* mov al, 0xf */
            ii(0x1028_bd63, 6); test(memw[ds, esi + 0x30], 0x400);      /* test word [esi+0x30], 0x400 */
            ii(0x1028_bd69, 2); if(jz(0x1028_bd6d, 0x2)) goto l_0x1028_bd6d; /* jz 0x1028bd6d */
            ii(0x1028_bd6b, 2); mov(al, 0x13);                          /* mov al, 0x13 */
        l_0x1028_bd6d:
            ii(0x1028_bd6d, 1); stosb();                                /* stosb */
        l_0x1028_bd6e:
            ii(0x1028_bd6e, 6); test(memw[ds, esi + 0x30], 0x20);       /* test word [esi+0x30], 0x20 */
            ii(0x1028_bd74, 2); if(jz(0x1028_bd79, 0x3)) goto l_0x1028_bd79; /* jz 0x1028bd79 */
            ii(0x1028_bd76, 2); mov(al, 0x14);                          /* mov al, 0x14 */
            ii(0x1028_bd78, 1); stosb();                                /* stosb */
        l_0x1028_bd79:
            ii(0x1028_bd79, 6); test(memw[ds, esi + 0x30], 0x200);      /* test word [esi+0x30], 0x200 */
            ii(0x1028_bd7f, 2); if(jz(0x1028_bd84, 0x3)) goto l_0x1028_bd84; /* jz 0x1028bd84 */
            ii(0x1028_bd81, 2); mov(al, 0x18);                          /* mov al, 0x18 */
            ii(0x1028_bd83, 1); stosb();                                /* stosb */
        l_0x1028_bd84:
            ii(0x1028_bd84, 6); test(memw[ds, esi + 0x30], 0x100);      /* test word [esi+0x30], 0x100 */
            ii(0x1028_bd8a, 2); if(jz(0x1028_bd97, 0xb)) goto l_0x1028_bd97; /* jz 0x1028bd97 */
            ii(0x1028_bd8c, 6); test(memw[ds, esi + 0x30], 0x200);      /* test word [esi+0x30], 0x200 */
            ii(0x1028_bd92, 2); if(jnz(0x1028_bd97, 0x3)) goto l_0x1028_bd97; /* jnz 0x1028bd97 */
            ii(0x1028_bd94, 2); mov(al, 0x15);                          /* mov al, 0x15 */
            ii(0x1028_bd96, 1); stosb();                                /* stosb */
        l_0x1028_bd97:
            ii(0x1028_bd97, 4); movzx(ebx, memw[ds, esi + 0x36]);       /* movzx ebx, word [esi+0x36] */
            ii(0x1028_bd9b, 6); add(ebx, 0xd);                          /* add ebx, 0xd */
            ii(0x1028_bda1, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1028_bda3, 1); stosb();                                /* stosb */
            ii(0x1028_bda4, 4); movzx(ebx, memw[ds, esi + 0x36]);       /* movzx ebx, word [esi+0x36] */
            ii(0x1028_bda8, 6); add(ebx, 0x11);                         /* add ebx, 0x11 */
            ii(0x1028_bdae, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1028_bdb0, 1); stosb();                                /* stosb */
            ii(0x1028_bdb1, 6); test(memw[ds, esi + 0x30], 0x20);       /* test word [esi+0x30], 0x20 */
            ii(0x1028_bdb7, 2); if(jz(0x1028_bdcb, 0x12)) goto l_0x1028_bdcb; /* jz 0x1028bdcb */
            ii(0x1028_bdb9, 2); mov(al, 0x22);                          /* mov al, 0x22 */
            ii(0x1028_bdbb, 6); test(memw[ds, esi + 0x30], 0x400);      /* test word [esi+0x30], 0x400 */
            ii(0x1028_bdc1, 2); if(jz(0x1028_bdc5, 0x2)) goto l_0x1028_bdc5; /* jz 0x1028bdc5 */
            ii(0x1028_bdc3, 2); mov(al, 0x23);                          /* mov al, 0x23 */
        l_0x1028_bdc5:
            ii(0x1028_bdc5, 1); stosb();                                /* stosb */
            ii(0x1028_bdc6, 2); jmp(0x1028_bdd8, 0x10); goto l_0x1028_bdd8; /* jmp 0x1028bdd8 */
        //  ii(0x1028_bdc8, 1); nop();                                  /* nop */
        //  ii(0x1028_bdc9, 1); nop();                                  /* nop */
        //  ii(0x1028_bdca, 1); nop();                                  /* nop */
        l_0x1028_bdcb:
            ii(0x1028_bdcb, 2); mov(al, 0x10);                          /* mov al, 0x10 */
            ii(0x1028_bdcd, 6); test(memw[ds, esi + 0x30], 0x400);      /* test word [esi+0x30], 0x400 */
            ii(0x1028_bdd3, 2); if(jz(0x1028_bdd7, 0x2)) goto l_0x1028_bdd7; /* jz 0x1028bdd7 */
            ii(0x1028_bdd5, 2); mov(al, 0x20);                          /* mov al, 0x20 */
        l_0x1028_bdd7:
            ii(0x1028_bdd7, 1); stosb();                                /* stosb */
        l_0x1028_bdd8:
            ii(0x1028_bdd8, 6); test(memw[ds, esi + 0x30], 0x20);       /* test word [esi+0x30], 0x20 */
            ii(0x1028_bdde, 2); if(jz(0x1028_bde3, 0x3)) goto l_0x1028_bde3; /* jz 0x1028bde3 */
            ii(0x1028_bde0, 2); mov(al, 0x14);                          /* mov al, 0x14 */
            ii(0x1028_bde2, 1); stosb();                                /* stosb */
        l_0x1028_bde3:
            ii(0x1028_bde3, 6); test(memw[ds, esi + 0x30], 0x200);      /* test word [esi+0x30], 0x200 */
            ii(0x1028_bde9, 2); if(jz(0x1028_bdee, 0x3)) goto l_0x1028_bdee; /* jz 0x1028bdee */
            ii(0x1028_bdeb, 2); mov(al, 0x19);                          /* mov al, 0x19 */
            ii(0x1028_bded, 1); stosb();                                /* stosb */
        l_0x1028_bdee:
            ii(0x1028_bdee, 6); test(memw[ds, esi + 0x30], 0x100);      /* test word [esi+0x30], 0x100 */
            ii(0x1028_bdf4, 2); if(jz(0x1028_be01, 0xb)) goto l_0x1028_be01; /* jz 0x1028be01 */
            ii(0x1028_bdf6, 6); test(memw[ds, esi + 0x30], 0x200);      /* test word [esi+0x30], 0x200 */
            ii(0x1028_bdfc, 2); if(jnz(0x1028_be01, 0x3)) goto l_0x1028_be01; /* jnz 0x1028be01 */
            ii(0x1028_bdfe, 2); mov(al, 0x15);                          /* mov al, 0x15 */
            ii(0x1028_be00, 1); stosb();                                /* stosb */
        l_0x1028_be01:
            ii(0x1028_be01, 4); movzx(ebx, memw[ds, esi + 0x36]);       /* movzx ebx, word [esi+0x36] */
            ii(0x1028_be05, 6); add(ebx, 0xd);                          /* add ebx, 0xd */
            ii(0x1028_be0b, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1028_be0d, 1); stosb();                                /* stosb */
            ii(0x1028_be0e, 4); movzx(ebx, memw[ds, esi + 0x36]);       /* movzx ebx, word [esi+0x36] */
            ii(0x1028_be12, 6); add(ebx, 0x11);                         /* add ebx, 0x11 */
            ii(0x1028_be18, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1028_be1a, 1); stosb();                                /* stosb */
            ii(0x1028_be1b, 2); jmp(0x1028_be7c, 0x5f); goto l_0x1028_be7c; /* jmp 0x1028be7c */
        l_0x1028_be1d:
            ii(0x1028_be1d, 6); test(memw[ds, esi + 0x30], 0x20);       /* test word [esi+0x30], 0x20 */
            ii(0x1028_be23, 2); if(jz(0x1028_be37, 0x12)) goto l_0x1028_be37; /* jz 0x1028be37 */
            ii(0x1028_be25, 2); mov(al, 0x1c);                          /* mov al, 0x1c */
            ii(0x1028_be27, 6); test(memw[ds, esi + 0x30], 0x400);      /* test word [esi+0x30], 0x400 */
            ii(0x1028_be2d, 2); if(jz(0x1028_be31, 0x2)) goto l_0x1028_be31; /* jz 0x1028be31 */
            ii(0x1028_be2f, 2); mov(al, 0x1b);                          /* mov al, 0x1b */
        l_0x1028_be31:
            ii(0x1028_be31, 1); stosb();                                /* stosb */
            ii(0x1028_be32, 2); jmp(0x1028_be44, 0x10); goto l_0x1028_be44; /* jmp 0x1028be44 */
        //  ii(0x1028_be34, 1); nop();                                  /* nop */
        //  ii(0x1028_be35, 1); nop();                                  /* nop */
        //  ii(0x1028_be36, 1); nop();                                  /* nop */
        l_0x1028_be37:
            ii(0x1028_be37, 2); mov(al, 0x6);                           /* mov al, 0x6 */
            ii(0x1028_be39, 6); test(memw[ds, esi + 0x30], 0x400);      /* test word [esi+0x30], 0x400 */
            ii(0x1028_be3f, 2); if(jz(0x1028_be43, 0x2)) goto l_0x1028_be43; /* jz 0x1028be43 */
            ii(0x1028_be41, 2); mov(al, 0x13);                          /* mov al, 0x13 */
        l_0x1028_be43:
            ii(0x1028_be43, 1); stosb();                                /* stosb */
        l_0x1028_be44:
            ii(0x1028_be44, 6); test(memw[ds, esi + 0x30], 0x20);       /* test word [esi+0x30], 0x20 */
            ii(0x1028_be4a, 2); if(jz(0x1028_be4f, 0x3)) goto l_0x1028_be4f; /* jz 0x1028be4f */
            ii(0x1028_be4c, 2); mov(al, 0x14);                          /* mov al, 0x14 */
            ii(0x1028_be4e, 1); stosb();                                /* stosb */
        l_0x1028_be4f:
            ii(0x1028_be4f, 6); test(memw[ds, esi + 0x30], 0x100);      /* test word [esi+0x30], 0x100 */
            ii(0x1028_be55, 2); if(jz(0x1028_be62, 0xb)) goto l_0x1028_be62; /* jz 0x1028be62 */
            ii(0x1028_be57, 6); test(memw[ds, esi + 0x30], 0x200);      /* test word [esi+0x30], 0x200 */
            ii(0x1028_be5d, 2); if(jnz(0x1028_be62, 0x3)) goto l_0x1028_be62; /* jnz 0x1028be62 */
            ii(0x1028_be5f, 2); mov(al, 0x15);                          /* mov al, 0x15 */
            ii(0x1028_be61, 1); stosb();                                /* stosb */
        l_0x1028_be62:
            ii(0x1028_be62, 4); movzx(ebx, memw[ds, esi + 0x36]);       /* movzx ebx, word [esi+0x36] */
            ii(0x1028_be66, 6); add(ebx, 0xd);                          /* add ebx, 0xd */
            ii(0x1028_be6c, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1028_be6e, 1); stosb();                                /* stosb */
            ii(0x1028_be6f, 4); movzx(ebx, memw[ds, esi + 0x36]);       /* movzx ebx, word [esi+0x36] */
            ii(0x1028_be73, 6); add(ebx, 0x11);                         /* add ebx, 0x11 */
            ii(0x1028_be79, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1028_be7b, 1); stosb();                                /* stosb */
        l_0x1028_be7c:
            ii(0x1028_be7c, 3); sub(ecx, 0x1);                          /* sub ecx, 0x1 */
            ii(0x1028_be7f, 2); if(jz(0x1028_be86, 0x5)) goto l_0x1028_be86; /* jz 0x1028be86 */
            ii(0x1028_be81, 5); jmp(0x1028_bd3c, -0x14a); goto l_0x1028_bd3c; /* jmp 0x1028bd3c */
        l_0x1028_be86:
            ii(0x1028_be86, 2); mov(al, 0x1d);                          /* mov al, 0x1d */
            ii(0x1028_be88, 1); stosb();                                /* stosb */
            ii(0x1028_be89, 2); mov(al, 0x5);                           /* mov al, 0x5 */
            ii(0x1028_be8b, 1); stosb();                                /* stosb */
            ii(0x1028_be8c, 2); mov(al, 0xb);                           /* mov al, 0xb */
            ii(0x1028_be8e, 1); stosb();                                /* stosb */
            ii(0x1028_be8f, 2); mov(al, 0x4);                           /* mov al, 0x4 */
            ii(0x1028_be91, 1); stosb();                                /* stosb */
            ii(0x1028_be92, 2); mov(al, 0x9);                           /* mov al, 0x9 */
            ii(0x1028_be94, 1); stosb();                                /* stosb */
            ii(0x1028_be95, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1028_be9a, 5); cmp(memw[ds, esi + 0x36], 0x3);         /* cmp word [esi+0x36], 0x3 */
            ii(0x1028_be9f, 2); if(jnz(0x1028_bea6, 0x5)) goto l_0x1028_bea6; /* jnz 0x1028bea6 */
            ii(0x1028_bea1, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
        l_0x1028_bea6:
            ii(0x1028_bea6, 5); cmp(memw[ds, esi + 0x36], 0x2);         /* cmp word [esi+0x36], 0x2 */
            ii(0x1028_beab, 6); if(jnz(0x1028_bf87, 0xd6)) goto l_0x1028_bf87; /* jnz 0x1028bf87 */
            ii(0x1028_beb1, 6); test(memw[ds, esi + 0x30], 0x20);       /* test word [esi+0x30], 0x20 */
            ii(0x1028_beb7, 2); if(jz(0x1028_becb, 0x12)) goto l_0x1028_becb; /* jz 0x1028becb */
            ii(0x1028_beb9, 2); mov(al, 0x21);                          /* mov al, 0x21 */
            ii(0x1028_bebb, 6); test(memw[ds, esi + 0x30], 0x400);      /* test word [esi+0x30], 0x400 */
            ii(0x1028_bec1, 2); if(jz(0x1028_bec5, 0x2)) goto l_0x1028_bec5; /* jz 0x1028bec5 */
            ii(0x1028_bec3, 2); mov(al, 0x21);                          /* mov al, 0x21 */
        l_0x1028_bec5:
            ii(0x1028_bec5, 1); stosb();                                /* stosb */
            ii(0x1028_bec6, 2); jmp(0x1028_bed8, 0x10); goto l_0x1028_bed8; /* jmp 0x1028bed8 */
        //  ii(0x1028_bec8, 1); nop();                                  /* nop */
        //  ii(0x1028_bec9, 1); nop();                                  /* nop */
        //  ii(0x1028_beca, 1); nop();                                  /* nop */
        l_0x1028_becb:
            ii(0x1028_becb, 2); mov(al, 0xf);                           /* mov al, 0xf */
            ii(0x1028_becd, 6); test(memw[ds, esi + 0x30], 0x400);      /* test word [esi+0x30], 0x400 */
            ii(0x1028_bed3, 2); if(jz(0x1028_bed7, 0x2)) goto l_0x1028_bed7; /* jz 0x1028bed7 */
            ii(0x1028_bed5, 2); mov(al, 0x13);                          /* mov al, 0x13 */
        l_0x1028_bed7:
            ii(0x1028_bed7, 1); stosb();                                /* stosb */
        l_0x1028_bed8:
            ii(0x1028_bed8, 6); test(memw[ds, esi + 0x30], 0x20);       /* test word [esi+0x30], 0x20 */
            ii(0x1028_bede, 2); if(jz(0x1028_bee3, 0x3)) goto l_0x1028_bee3; /* jz 0x1028bee3 */
            ii(0x1028_bee0, 2); mov(al, 0x14);                          /* mov al, 0x14 */
            ii(0x1028_bee2, 1); stosb();                                /* stosb */
        l_0x1028_bee3:
            ii(0x1028_bee3, 6); test(memw[ds, esi + 0x30], 0x200);      /* test word [esi+0x30], 0x200 */
            ii(0x1028_bee9, 2); if(jz(0x1028_beee, 0x3)) goto l_0x1028_beee; /* jz 0x1028beee */
            ii(0x1028_beeb, 2); mov(al, 0x18);                          /* mov al, 0x18 */
            ii(0x1028_beed, 1); stosb();                                /* stosb */
        l_0x1028_beee:
            ii(0x1028_beee, 6); test(memw[ds, esi + 0x30], 0x100);      /* test word [esi+0x30], 0x100 */
            ii(0x1028_bef4, 2); if(jz(0x1028_bf01, 0xb)) goto l_0x1028_bf01; /* jz 0x1028bf01 */
            ii(0x1028_bef6, 6); test(memw[ds, esi + 0x30], 0x200);      /* test word [esi+0x30], 0x200 */
            ii(0x1028_befc, 2); if(jnz(0x1028_bf01, 0x3)) goto l_0x1028_bf01; /* jnz 0x1028bf01 */
            ii(0x1028_befe, 2); mov(al, 0x15);                          /* mov al, 0x15 */
            ii(0x1028_bf00, 1); stosb();                                /* stosb */
        l_0x1028_bf01:
            ii(0x1028_bf01, 4); movzx(ebx, memw[ds, esi + 0x36]);       /* movzx ebx, word [esi+0x36] */
            ii(0x1028_bf05, 6); add(ebx, 0xd);                          /* add ebx, 0xd */
            ii(0x1028_bf0b, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1028_bf0d, 1); stosb();                                /* stosb */
            ii(0x1028_bf0e, 4); movzx(ebx, memw[ds, esi + 0x36]);       /* movzx ebx, word [esi+0x36] */
            ii(0x1028_bf12, 6); add(ebx, 0x11);                         /* add ebx, 0x11 */
            ii(0x1028_bf18, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1028_bf1a, 1); stosb();                                /* stosb */
            ii(0x1028_bf1b, 6); test(memw[ds, esi + 0x30], 0x20);       /* test word [esi+0x30], 0x20 */
            ii(0x1028_bf21, 2); if(jz(0x1028_bf35, 0x12)) goto l_0x1028_bf35; /* jz 0x1028bf35 */
            ii(0x1028_bf23, 2); mov(al, 0x22);                          /* mov al, 0x22 */
            ii(0x1028_bf25, 6); test(memw[ds, esi + 0x30], 0x400);      /* test word [esi+0x30], 0x400 */
            ii(0x1028_bf2b, 2); if(jz(0x1028_bf2f, 0x2)) goto l_0x1028_bf2f; /* jz 0x1028bf2f */
            ii(0x1028_bf2d, 2); mov(al, 0x23);                          /* mov al, 0x23 */
        l_0x1028_bf2f:
            ii(0x1028_bf2f, 1); stosb();                                /* stosb */
            ii(0x1028_bf30, 2); jmp(0x1028_bf42, 0x10); goto l_0x1028_bf42; /* jmp 0x1028bf42 */
        //  ii(0x1028_bf32, 1); nop();                                  /* nop */
        //  ii(0x1028_bf33, 1); nop();                                  /* nop */
        //  ii(0x1028_bf34, 1); nop();                                  /* nop */
        l_0x1028_bf35:
            ii(0x1028_bf35, 2); mov(al, 0x10);                          /* mov al, 0x10 */
            ii(0x1028_bf37, 6); test(memw[ds, esi + 0x30], 0x400);      /* test word [esi+0x30], 0x400 */
            ii(0x1028_bf3d, 2); if(jz(0x1028_bf41, 0x2)) goto l_0x1028_bf41; /* jz 0x1028bf41 */
            ii(0x1028_bf3f, 2); mov(al, 0x20);                          /* mov al, 0x20 */
        l_0x1028_bf41:
            ii(0x1028_bf41, 1); stosb();                                /* stosb */
        l_0x1028_bf42:
            ii(0x1028_bf42, 6); test(memw[ds, esi + 0x30], 0x20);       /* test word [esi+0x30], 0x20 */
            ii(0x1028_bf48, 2); if(jz(0x1028_bf4d, 0x3)) goto l_0x1028_bf4d; /* jz 0x1028bf4d */
            ii(0x1028_bf4a, 2); mov(al, 0x14);                          /* mov al, 0x14 */
            ii(0x1028_bf4c, 1); stosb();                                /* stosb */
        l_0x1028_bf4d:
            ii(0x1028_bf4d, 6); test(memw[ds, esi + 0x30], 0x200);      /* test word [esi+0x30], 0x200 */
            ii(0x1028_bf53, 2); if(jz(0x1028_bf58, 0x3)) goto l_0x1028_bf58; /* jz 0x1028bf58 */
            ii(0x1028_bf55, 2); mov(al, 0x19);                          /* mov al, 0x19 */
            ii(0x1028_bf57, 1); stosb();                                /* stosb */
        l_0x1028_bf58:
            ii(0x1028_bf58, 6); test(memw[ds, esi + 0x30], 0x100);      /* test word [esi+0x30], 0x100 */
            ii(0x1028_bf5e, 2); if(jz(0x1028_bf6b, 0xb)) goto l_0x1028_bf6b; /* jz 0x1028bf6b */
            ii(0x1028_bf60, 6); test(memw[ds, esi + 0x30], 0x200);      /* test word [esi+0x30], 0x200 */
            ii(0x1028_bf66, 2); if(jnz(0x1028_bf6b, 0x3)) goto l_0x1028_bf6b; /* jnz 0x1028bf6b */
            ii(0x1028_bf68, 2); mov(al, 0x15);                          /* mov al, 0x15 */
            ii(0x1028_bf6a, 1); stosb();                                /* stosb */
        l_0x1028_bf6b:
            ii(0x1028_bf6b, 4); movzx(ebx, memw[ds, esi + 0x36]);       /* movzx ebx, word [esi+0x36] */
            ii(0x1028_bf6f, 6); add(ebx, 0xd);                          /* add ebx, 0xd */
            ii(0x1028_bf75, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1028_bf77, 1); stosb();                                /* stosb */
            ii(0x1028_bf78, 4); movzx(ebx, memw[ds, esi + 0x36]);       /* movzx ebx, word [esi+0x36] */
            ii(0x1028_bf7c, 6); add(ebx, 0x11);                         /* add ebx, 0x11 */
            ii(0x1028_bf82, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1028_bf84, 1); stosb();                                /* stosb */
            ii(0x1028_bf85, 2); jmp(0x1028_bfe6, 0x5f); goto l_0x1028_bfe6; /* jmp 0x1028bfe6 */
        l_0x1028_bf87:
            ii(0x1028_bf87, 6); test(memw[ds, esi + 0x30], 0x20);       /* test word [esi+0x30], 0x20 */
            ii(0x1028_bf8d, 2); if(jz(0x1028_bfa1, 0x12)) goto l_0x1028_bfa1; /* jz 0x1028bfa1 */
            ii(0x1028_bf8f, 2); mov(al, 0x1c);                          /* mov al, 0x1c */
            ii(0x1028_bf91, 6); test(memw[ds, esi + 0x30], 0x400);      /* test word [esi+0x30], 0x400 */
            ii(0x1028_bf97, 2); if(jz(0x1028_bf9b, 0x2)) goto l_0x1028_bf9b; /* jz 0x1028bf9b */
            ii(0x1028_bf99, 2); mov(al, 0x1b);                          /* mov al, 0x1b */
        l_0x1028_bf9b:
            ii(0x1028_bf9b, 1); stosb();                                /* stosb */
            ii(0x1028_bf9c, 2); jmp(0x1028_bfae, 0x10); goto l_0x1028_bfae; /* jmp 0x1028bfae */
        //  ii(0x1028_bf9e, 1); nop();                                  /* nop */
        //  ii(0x1028_bf9f, 1); nop();                                  /* nop */
        //  ii(0x1028_bfa0, 1); nop();                                  /* nop */
        l_0x1028_bfa1:
            ii(0x1028_bfa1, 2); mov(al, 0x6);                           /* mov al, 0x6 */
            ii(0x1028_bfa3, 6); test(memw[ds, esi + 0x30], 0x400);      /* test word [esi+0x30], 0x400 */
            ii(0x1028_bfa9, 2); if(jz(0x1028_bfad, 0x2)) goto l_0x1028_bfad; /* jz 0x1028bfad */
            ii(0x1028_bfab, 2); mov(al, 0x13);                          /* mov al, 0x13 */
        l_0x1028_bfad:
            ii(0x1028_bfad, 1); stosb();                                /* stosb */
        l_0x1028_bfae:
            ii(0x1028_bfae, 6); test(memw[ds, esi + 0x30], 0x20);       /* test word [esi+0x30], 0x20 */
            ii(0x1028_bfb4, 2); if(jz(0x1028_bfb9, 0x3)) goto l_0x1028_bfb9; /* jz 0x1028bfb9 */
            ii(0x1028_bfb6, 2); mov(al, 0x14);                          /* mov al, 0x14 */
            ii(0x1028_bfb8, 1); stosb();                                /* stosb */
        l_0x1028_bfb9:
            ii(0x1028_bfb9, 6); test(memw[ds, esi + 0x30], 0x100);      /* test word [esi+0x30], 0x100 */
            ii(0x1028_bfbf, 2); if(jz(0x1028_bfcc, 0xb)) goto l_0x1028_bfcc; /* jz 0x1028bfcc */
            ii(0x1028_bfc1, 6); test(memw[ds, esi + 0x30], 0x200);      /* test word [esi+0x30], 0x200 */
            ii(0x1028_bfc7, 2); if(jnz(0x1028_bfcc, 0x3)) goto l_0x1028_bfcc; /* jnz 0x1028bfcc */
            ii(0x1028_bfc9, 2); mov(al, 0x15);                          /* mov al, 0x15 */
            ii(0x1028_bfcb, 1); stosb();                                /* stosb */
        l_0x1028_bfcc:
            ii(0x1028_bfcc, 4); movzx(ebx, memw[ds, esi + 0x36]);       /* movzx ebx, word [esi+0x36] */
            ii(0x1028_bfd0, 6); add(ebx, 0xd);                          /* add ebx, 0xd */
            ii(0x1028_bfd6, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1028_bfd8, 1); stosb();                                /* stosb */
            ii(0x1028_bfd9, 4); movzx(ebx, memw[ds, esi + 0x36]);       /* movzx ebx, word [esi+0x36] */
            ii(0x1028_bfdd, 6); add(ebx, 0x11);                         /* add ebx, 0x11 */
            ii(0x1028_bfe3, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1028_bfe5, 1); stosb();                                /* stosb */
        l_0x1028_bfe6:
            ii(0x1028_bfe6, 3); sub(ecx, 0x1);                          /* sub ecx, 0x1 */
            ii(0x1028_bfe9, 2); if(jz(0x1028_bff0, 0x5)) goto l_0x1028_bff0; /* jz 0x1028bff0 */
            ii(0x1028_bfeb, 5); jmp(0x1028_bea6, -0x14a); goto l_0x1028_bea6; /* jmp 0x1028bea6 */
        l_0x1028_bff0:
            ii(0x1028_bff0, 2); mov(al, 0x1e);                          /* mov al, 0x1e */
            ii(0x1028_bff2, 1); stosb();                                /* stosb */
            ii(0x1028_bff3, 2); mov(al, 0x5);                           /* mov al, 0x5 */
            ii(0x1028_bff5, 1); stosb();                                /* stosb */
            ii(0x1028_bff6, 6); test(memw[ds, esi + 0x30], 0x20);       /* test word [esi+0x30], 0x20 */
            ii(0x1028_bffc, 2); if(jz(0x1028_c00d, 0xf)) goto l_0x1028_c00d; /* jz 0x1028c00d */
            ii(0x1028_bffe, 2); mov(al, 0x1);                           /* mov al, 0x1 */
            ii(0x1028_c000, 6); test(memw[ds, esi + 0x30], 0x400);      /* test word [esi+0x30], 0x400 */
            ii(0x1028_c006, 2); if(jz(0x1028_c00a, 0x2)) goto l_0x1028_c00a; /* jz 0x1028c00a */
            ii(0x1028_c008, 2); mov(al, 0x1f);                          /* mov al, 0x1f */
        l_0x1028_c00a:
            ii(0x1028_c00a, 1); stosb();                                /* stosb */
            ii(0x1028_c00b, 2); jmp(0x1028_c01a, 0xd); goto l_0x1028_c01a; /* jmp 0x1028c01a */
        l_0x1028_c00d:
            ii(0x1028_c00d, 2); mov(al, 0x1);                           /* mov al, 0x1 */
            ii(0x1028_c00f, 6); test(memw[ds, esi + 0x30], 0x400);      /* test word [esi+0x30], 0x400 */
            ii(0x1028_c015, 2); if(jz(0x1028_c019, 0x2)) goto l_0x1028_c019; /* jz 0x1028c019 */
            ii(0x1028_c017, 2); mov(al, 0x12);                          /* mov al, 0x12 */
        l_0x1028_c019:
            ii(0x1028_c019, 1); stosb();                                /* stosb */
        l_0x1028_c01a:
            ii(0x1028_c01a, 2); mov(al, 0xff);                          /* mov al, 0xff */
            ii(0x1028_c01c, 1); stosb();                                /* stosb */
            ii(0x1028_c01d, 2); popa();                                 /* popa */
            ii(0x1028_c01f, 1); ret();                                  /* ret */
        }
    }
}
