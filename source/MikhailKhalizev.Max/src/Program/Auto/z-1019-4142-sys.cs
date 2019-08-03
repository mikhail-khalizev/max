using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5d945cdd-bd57-414c-8f0d-322f02bb20b7")]
        public void /* sys */ Method_1019_4142()
        {
            ii(0x1019_4142, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_4143, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4145, 1); pushd(esi);                             /* push esi */
            ii(0x1019_4146, 1); pushd(edi);                             /* push edi */
            ii(0x1019_4147, 3); mov(ax, ds);                            /* mov ax, ds */
            ii(0x1019_414a, 3); mov(es, ax);                            /* mov es, ax */
            ii(0x1019_414d, 4); mov(cx, 0x20);                          /* mov cx, 0x20 */
            ii(0x1019_4151, 3); mov(esi, memd_a32[ss, ebp + 0x8]);      /* mov esi, [ebp+0x8] */
            ii(0x1019_4154, 5); mov(edi, 0x1020_9750);                  /* mov edi, 0x10209750 */
        l_0x1019_4159:
            ii(0x1019_4159, 1); lodsb_a32();                            /* lodsb */
            ii(0x1019_415a, 2); or(al, al);                             /* or al, al */
            ii(0x1019_415c, 2); if(jnzd(0x1019_4165, 0x7)) goto l_0x1019_4165; /* jnz 0x10194165 */
            ii(0x1019_415e, 3); add(edi, 0x18);                         /* add edi, 0x18 */
            ii(0x1019_4161, 2); if(loopd_a32(0x1019_4159, -0xa)) goto l_0x1019_4159; /* loop 0x10194159 */
            ii(0x1019_4163, 2); jmpd(0x1019_41d7, 0x72); goto l_0x1019_41d7; /* jmp 0x101941d7 */
        l_0x1019_4165:
            ii(0x1019_4165, 2); test(al, 0x1);                          /* test al, 0x1 */
            ii(0x1019_4167, 2); if(jzd(0x1019_41a1, 0x38)) goto l_0x1019_41a1; /* jz 0x101941a1 */
            ii(0x1019_4169, 2); movsw_a32();                            /* movsw */
            ii(0x1019_416b, 1); movsb_a32();                            /* movsb */
            ii(0x1019_416c, 2); test(al, 0x2);                          /* test al, 0x2 */
            ii(0x1019_416e, 2); if(jzd(0x1019_41a8, 0x38)) goto l_0x1019_41a8; /* jz 0x101941a8 */
        l_0x1019_4170:
            ii(0x1019_4170, 2); movsw_a32();                            /* movsw */
            ii(0x1019_4172, 1); movsb_a32();                            /* movsb */
            ii(0x1019_4173, 2); test(al, 0x4);                          /* test al, 0x4 */
            ii(0x1019_4175, 2); if(jzd(0x1019_41af, 0x38)) goto l_0x1019_41af; /* jz 0x101941af */
        l_0x1019_4177:
            ii(0x1019_4177, 2); movsw_a32();                            /* movsw */
            ii(0x1019_4179, 1); movsb_a32();                            /* movsb */
            ii(0x1019_417a, 2); test(al, 0x8);                          /* test al, 0x8 */
            ii(0x1019_417c, 2); if(jzd(0x1019_41b6, 0x38)) goto l_0x1019_41b6; /* jz 0x101941b6 */
        l_0x1019_417e:
            ii(0x1019_417e, 2); movsw_a32();                            /* movsw */
            ii(0x1019_4180, 1); movsb_a32();                            /* movsb */
            ii(0x1019_4181, 2); test(al, 0x10);                         /* test al, 0x10 */
            ii(0x1019_4183, 2); if(jzd(0x1019_41bd, 0x38)) goto l_0x1019_41bd; /* jz 0x101941bd */
        l_0x1019_4185:
            ii(0x1019_4185, 2); movsw_a32();                            /* movsw */
            ii(0x1019_4187, 1); movsb_a32();                            /* movsb */
            ii(0x1019_4188, 2); test(al, 0x20);                         /* test al, 0x20 */
            ii(0x1019_418a, 2); if(jzd(0x1019_41c4, 0x38)) goto l_0x1019_41c4; /* jz 0x101941c4 */
        l_0x1019_418c:
            ii(0x1019_418c, 2); movsw_a32();                            /* movsw */
            ii(0x1019_418e, 1); movsb_a32();                            /* movsb */
            ii(0x1019_418f, 2); test(al, 0x40);                         /* test al, 0x40 */
            ii(0x1019_4191, 2); if(jzd(0x1019_41cb, 0x38)) goto l_0x1019_41cb; /* jz 0x101941cb */
        l_0x1019_4193:
            ii(0x1019_4193, 2); movsw_a32();                            /* movsw */
            ii(0x1019_4195, 1); movsb_a32();                            /* movsb */
            ii(0x1019_4196, 2); or(al, al);                             /* or al, al */
            ii(0x1019_4198, 2); if(jnsd(0x1019_41d2, 0x38)) goto l_0x1019_41d2; /* jns 0x101941d2 */
        l_0x1019_419a:
            ii(0x1019_419a, 2); movsw_a32();                            /* movsw */
            ii(0x1019_419c, 1); movsb_a32();                            /* movsb */
            ii(0x1019_419d, 2); if(loopd_a32(0x1019_4159, -0x46)) goto l_0x1019_4159; /* loop 0x10194159 */
            ii(0x1019_419f, 2); jmpd(0x1019_41d7, 0x36); goto l_0x1019_41d7; /* jmp 0x101941d7 */
        l_0x1019_41a1:
            ii(0x1019_41a1, 3); add(edi, 0x3);                          /* add edi, 0x3 */
            ii(0x1019_41a4, 2); test(al, 0x2);                          /* test al, 0x2 */
            ii(0x1019_41a6, 2); if(jnzd(0x1019_4170, -0x38)) goto l_0x1019_4170; /* jnz 0x10194170 */
        l_0x1019_41a8:
            ii(0x1019_41a8, 3); add(edi, 0x3);                          /* add edi, 0x3 */
            ii(0x1019_41ab, 2); test(al, 0x4);                          /* test al, 0x4 */
            ii(0x1019_41ad, 2); if(jnzd(0x1019_4177, -0x38)) goto l_0x1019_4177; /* jnz 0x10194177 */
        l_0x1019_41af:
            ii(0x1019_41af, 3); add(edi, 0x3);                          /* add edi, 0x3 */
            ii(0x1019_41b2, 2); test(al, 0x8);                          /* test al, 0x8 */
            ii(0x1019_41b4, 2); if(jnzd(0x1019_417e, -0x38)) goto l_0x1019_417e; /* jnz 0x1019417e */
        l_0x1019_41b6:
            ii(0x1019_41b6, 3); add(edi, 0x3);                          /* add edi, 0x3 */
            ii(0x1019_41b9, 2); test(al, 0x10);                         /* test al, 0x10 */
            ii(0x1019_41bb, 2); if(jnzd(0x1019_4185, -0x38)) goto l_0x1019_4185; /* jnz 0x10194185 */
        l_0x1019_41bd:
            ii(0x1019_41bd, 3); add(edi, 0x3);                          /* add edi, 0x3 */
            ii(0x1019_41c0, 2); test(al, 0x20);                         /* test al, 0x20 */
            ii(0x1019_41c2, 2); if(jnzd(0x1019_418c, -0x38)) goto l_0x1019_418c; /* jnz 0x1019418c */
        l_0x1019_41c4:
            ii(0x1019_41c4, 3); add(edi, 0x3);                          /* add edi, 0x3 */
            ii(0x1019_41c7, 2); test(al, 0x40);                         /* test al, 0x40 */
            ii(0x1019_41c9, 2); if(jnzd(0x1019_4193, -0x38)) goto l_0x1019_4193; /* jnz 0x10194193 */
        l_0x1019_41cb:
            ii(0x1019_41cb, 3); add(edi, 0x3);                          /* add edi, 0x3 */
            ii(0x1019_41ce, 2); or(al, al);                             /* or al, al */
            ii(0x1019_41d0, 2); if(jsd(0x1019_419a, -0x38)) goto l_0x1019_419a; /* js 0x1019419a */
        l_0x1019_41d2:
            ii(0x1019_41d2, 3); add(edi, 0x3);                          /* add edi, 0x3 */
            ii(0x1019_41d5, 2); if(loopd_a32(0x1019_4159, -0x7e)) goto l_0x1019_4159; /* loop 0x10194159 */
        l_0x1019_41d7:
            ii(0x1019_41d7, 1); popd(edi);                              /* pop edi */
            ii(0x1019_41d8, 1); popd(esi);                              /* pop esi */
            ii(0x1019_41d9, 1); leaved();                               /* leave */
            ii(0x1019_41da, 1); retd(); return;                         /* ret */
        }
    }
}
