using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_3800-76b31880")]
        public void Method_100f_3800()
        {
            ii(0x100f_3800, 5); push(0x24);                             /* push 0x24 */
            ii(0x100f_3805, 5); call(Definitions.sys_check_available_stack_size, 0x7_2548); /* call 0x10165d52 */
            ii(0x100f_380a, 1); push(ebx);                              /* push ebx */
            ii(0x100f_380b, 1); push(ecx);                              /* push ecx */
            ii(0x100f_380c, 1); push(edx);                              /* push edx */
            ii(0x100f_380d, 1); push(esi);                              /* push esi */
            ii(0x100f_380e, 1); push(edi);                              /* push edi */
            ii(0x100f_380f, 1); push(ebp);                              /* push ebp */
            ii(0x100f_3810, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_3812, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100f_3818, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100f_381b, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_381f, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_3825, 5); mov(edx, 0x101c_a468);                  /* mov edx, 0x101ca468 */
            ii(0x100f_382a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_382c, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100f_382f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_3832, 6); mov(eax, memd[ds, eax + 256]);          /* mov eax, [eax+0x100] */
            ii(0x100f_3838, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_383b, 5); mov(memd[ds, 0x101c_38c0], eax);        /* mov [0x101c38c0], eax */
            ii(0x100f_3840, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x100f_3845, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_3847, 6); mov(edx, memd[ds, 0x101c_38be]);        /* mov edx, [0x101c38be] */
            ii(0x100f_384d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_3850, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_3852, 5); call(0x1010_1620, 0xddc9);              /* call 0x10101620 */
            ii(0x100f_3857, 5); call(0x1010_2acc, 0xf270);              /* call 0x10102acc */
            ii(0x100f_385c, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_385e, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x100f_3860, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_3863, 6); mov(ebx, memd[ds, eax + 260]);          /* mov ebx, [eax+0x104] */
            ii(0x100f_3869, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_386c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_386f, 6); mov(edx, memd[ds, eax + 258]);          /* mov edx, [eax+0x102] */
            ii(0x100f_3875, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_3878, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100f_387d, 5); call(0x1010_1620, 0xdd9e);              /* call 0x10101620 */
            ii(0x100f_3882, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_3884, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_3887, 5); add(eax, 0xfe);                         /* add eax, 0xfe */
            ii(0x100f_388c, 5); call(0x1013_ad71, 0x4_74e0);            /* call 0x1013ad71 */
            ii(0x100f_3891, 2); test(al, al);                           /* test al, al */
            ii(0x100f_3893, 2); if(jz(0x100f_38ae, 0x19)) goto l_0x100f_38ae; /* jz 0x100f38ae */
            ii(0x100f_3895, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_3898, 5); add(eax, 0xfe);                         /* add eax, 0xfe */
            ii(0x100f_389d, 5); call(0x1007_6574, -0x7_d32e);           /* call 0x10076574 */
            ii(0x100f_38a2, 3); mov(al, memb[ds, eax + 77]);            /* mov al, [eax+0x4d] */
            ii(0x100f_38a5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_38aa, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_38ac, 2); if(jnz(0x100f_38b0, 2)) goto l_0x100f_38b0; /* jnz 0x100f38b0 */
        l_0x100f_38ae:
            ii(0x100f_38ae, 2); jmp(0x100f_38c4, 0x14); goto l_0x100f_38c4; /* jmp 0x100f38c4 */
        l_0x100f_38b0:
            ii(0x100f_38b0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_38b3, 5); add(eax, 0xfe);                         /* add eax, 0xfe */
            ii(0x100f_38b8, 5); call(0x1007_6600, -0x7_d2bd);           /* call 0x10076600 */
            ii(0x100f_38bd, 5); call(0x100f_f637, 0xbd75);              /* call 0x100ff637 */
            ii(0x100f_38c2, 2); jmp(0x100f_38ce, 0xa); goto l_0x100f_38ce; /* jmp 0x100f38ce */
        l_0x100f_38c4:
            ii(0x100f_38c4, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x100f_38c9, 5); call(0x1010_1374, 0xdaa6);              /* call 0x10101374 */
        l_0x100f_38ce:
            ii(0x100f_38ce, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_38d1, 6); mov(al, memb[ds, eax + 273]);           /* mov al, [eax+0x111] */
            ii(0x100f_38d7, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_38dc, 5); call(0x100f_a7e8, 0x6f07);              /* call 0x100fa7e8 */
            ii(0x100f_38e1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_38e4, 6); mov(al, memb[ds, eax + 266]);           /* mov al, [eax+0x10a] */
            ii(0x100f_38ea, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_38ef, 5); call(0x100f_47e4, 0xef0);               /* call 0x100f47e4 */
            ii(0x100f_38f4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_38f7, 6); mov(al, memb[ds, eax + 267]);           /* mov al, [eax+0x10b] */
            ii(0x100f_38fd, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_3902, 5); call(0x100f_487e, 0xf77);               /* call 0x100f487e */
            ii(0x100f_3907, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_390a, 6); mov(al, memb[ds, eax + 268]);           /* mov al, [eax+0x10c] */
            ii(0x100f_3910, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_3915, 5); call(0x100f_48cb, 0xfb1);               /* call 0x100f48cb */
            ii(0x100f_391a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_391d, 6); mov(al, memb[ds, eax + 269]);           /* mov al, [eax+0x10d] */
            ii(0x100f_3923, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_3928, 5); call(0x100f_4965, 0x1038);              /* call 0x100f4965 */
            ii(0x100f_392d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_3930, 6); mov(al, memb[ds, eax + 274]);           /* mov al, [eax+0x112] */
            ii(0x100f_3936, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_393b, 5); call(0x100f_4918, 0xfd8);               /* call 0x100f4918 */
            ii(0x100f_3940, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_3943, 6); mov(al, memb[ds, eax + 264]);           /* mov al, [eax+0x108] */
            ii(0x100f_3949, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_394e, 5); call(0x100f_4831, 0xede);               /* call 0x100f4831 */
            ii(0x100f_3953, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_3956, 6); mov(al, memb[ds, eax + 265]);           /* mov al, [eax+0x109] */
            ii(0x100f_395c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_3961, 5); call(0x100f_4ba0, 0x123a);              /* call 0x100f4ba0 */
            ii(0x100f_3966, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_3969, 6); mov(al, memb[ds, eax + 272]);           /* mov al, [eax+0x110] */
            ii(0x100f_396f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_3974, 5); call(0x100f_4f55, 0x15dc);              /* call 0x100f4f55 */
            ii(0x100f_3979, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_397c, 6); mov(al, memb[ds, eax + 270]);           /* mov al, [eax+0x10e] */
            ii(0x100f_3982, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_3987, 5); call(0x100f_49b2, 0x1026);              /* call 0x100f49b2 */
            ii(0x100f_398c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_398f, 6); mov(al, memb[ds, eax + 271]);           /* mov al, [eax+0x10f] */
            ii(0x100f_3995, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_399a, 5); call(0x100f_49ff, 0x1060);              /* call 0x100f49ff */
            ii(0x100f_399f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_39a1, 5); mov(al, memb[ds, 0x101c_388c]);         /* mov al, [0x101c388c] */
            ii(0x100f_39a6, 5); call(0x100f_3711, -0x29a);              /* call 0x100f3711 */
            ii(0x100f_39ab, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_39ad, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_39ae, 1); pop(edi);                               /* pop edi */
            ii(0x100f_39af, 1); pop(esi);                               /* pop esi */
            ii(0x100f_39b0, 1); pop(edx);                               /* pop edx */
            ii(0x100f_39b1, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_39b2, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_39b3, 1); ret();                                  /* ret */
        }
    }
}
