using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_51b4-237b6ed1")]
        public void Method_1012_51b4()
        {
            ii(0x1012_51b4, 5); push(0x60);                             /* push 0x60 */
            ii(0x1012_51b9, 5); call(Definitions.sys_check_available_stack_size, 0x4_0b94); /* call 0x10165d52 */
            ii(0x1012_51be, 1); push(ebx);                              /* push ebx */
            ii(0x1012_51bf, 1); push(ecx);                              /* push ecx */
            ii(0x1012_51c0, 1); push(esi);                              /* push esi */
            ii(0x1012_51c1, 1); push(edi);                              /* push edi */
            ii(0x1012_51c2, 1); push(ebp);                              /* push ebp */
            ii(0x1012_51c3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_51c5, 6); sub(esp, 0x44);                         /* sub esp, 0x44 */
            ii(0x1012_51cb, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1012_51ce, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1012_51d1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_51d3, 4); mov(ax, memw[ss, ebp - 4]);             /* mov ax, [ebp-0x4] */
            ii(0x1012_51d7, 5); call(0x1012_4fa5, -0x237);              /* call 0x10124fa5 */
            ii(0x1012_51dc, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1012_51df, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1012_51e3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_51e5, 2); if(jnz(0x1012_51f3, 0xc)) goto l_0x1012_51f3; /* jnz 0x101251f3 */
            ii(0x1012_51e7, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
            ii(0x1012_51ee, 5); jmp(0x1012_57fc, 0x609); goto l_0x1012_57fc; /* jmp 0x101257fc */
        l_0x1012_51f3:
            ii(0x1012_51f3, 5); mov(eax, 0x1_c200);                     /* mov eax, 0x1c200 */
            ii(0x1012_51f8, 5); mov(edx, 0x1_c200);                     /* mov edx, 0x1c200 */
            ii(0x1012_51fd, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_5200, 3); idiv(memd[ss, ebp - 8]);                /* idiv dword [ebp-0x8] */
            ii(0x1012_5203, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_5206, 5); mov(eax, 0x5c);                         /* mov eax, 0x5c */
            ii(0x1012_520b, 5); call(0x1007_5fdc, -0xa_f234);           /* call 0x10075fdc */
            ii(0x1012_5210, 2); add(al, 8);                             /* add al, 0x8 */
            ii(0x1012_5212, 5); mov(memb[ds, 0x101b_b45a], al);         /* mov [0x101bb45a], al */
            ii(0x1012_5217, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1012_521a, 6); mov(memw[ds, 0x101b_b45c], ax);         /* mov [0x101bb45c], ax */
            ii(0x1012_5220, 7); mov(memd[ss, ebp - 44], 0x204);         /* mov dword [ebp-0x2c], 0x204 */
            ii(0x1012_5227, 5); mov(al, memb[ds, 0x101b_b45a]);         /* mov al, [0x101bb45a] */
            ii(0x1012_522c, 3); mov(memb[ss, ebp - 40], al);            /* mov [ebp-0x28], al */
            ii(0x1012_522f, 3); lea(ebx, memd[ss, ebp - 44]);           /* lea ebx, [ebp-0x2c] */
            ii(0x1012_5232, 3); lea(edx, memd[ss, ebp - 44]);           /* lea edx, [ebp-0x2c] */
            ii(0x1012_5235, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1012_523a, 5); call(/* sys */ 0x1016_c606, 0x4_73c7);  /* call 0x1016c606 */
            ii(0x1012_523f, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x1012_5242, 6); mov(memw[ds, 0x101c_59ac], ax);         /* mov [0x101c59ac], ax */
            ii(0x1012_5248, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1012_524b, 5); mov(memd[ds, 0x101c_59a8], eax);        /* mov [0x101c59a8], eax */
            ii(0x1012_5250, 7); mov(memd[ss, ebp - 44], 0x200);         /* mov dword [ebp-0x2c], 0x200 */
            ii(0x1012_5257, 5); mov(al, memb[ds, 0x101b_b45a]);         /* mov al, [0x101bb45a] */
            ii(0x1012_525c, 3); mov(memb[ss, ebp - 40], al);            /* mov [ebp-0x28], al */
            ii(0x1012_525f, 3); lea(ebx, memd[ss, ebp - 44]);           /* lea ebx, [ebp-0x2c] */
            ii(0x1012_5262, 3); lea(edx, memd[ss, ebp - 44]);           /* lea edx, [ebp-0x2c] */
            ii(0x1012_5265, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1012_526a, 5); call(/* sys */ 0x1016_c606, 0x4_7397);  /* call 0x1016c606 */
            ii(0x1012_526f, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x1012_5272, 6); mov(memw[ds, 0x101c_59a4], ax);         /* mov [0x101c59a4], ax */
            ii(0x1012_5278, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1012_527b, 6); mov(memw[ds, 0x101c_59a6], ax);         /* mov [0x101c59a6], ax */
            ii(0x1012_5281, 3); mov(memw[ss, ebp - 48], ds);            /* mov [ebp-0x30], ds */
            ii(0x1012_5284, 7); mov(memd[ss, ebp - 52], 0x1019_f135);   /* mov dword [ebp-0x34], 0x1019f135 */
            ii(0x1012_528b, 3); mov(memw[ss, ebp - 56], ds);            /* mov [ebp-0x38], ds */
            ii(0x1012_528e, 7); mov(memd[ss, ebp - 60], 0x101b_b45c);   /* mov dword [ebp-0x3c], 0x101bb45c */
            ii(0x1012_5295, 3); mov(ecx, memd[ss, ebp - 52]);           /* mov ecx, [ebp-0x34] */
            ii(0x1012_5298, 3); mov(eax, memd[ss, ebp - 56]);           /* mov eax, [ebp-0x38] */
            ii(0x1012_529b, 3); mov(ebx, memd[ss, ebp - 60]);           /* mov ebx, [ebp-0x3c] */
            ii(0x1012_529e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_52a0, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1012_52a2, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_52a4, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1012_52a6, 4); mov(memw[ss, ebp - 48], ax);            /* mov [ebp-0x30], ax */
            ii(0x1012_52aa, 3); mov(memd[ss, ebp - 52], ebx);           /* mov [ebp-0x34], ebx */
            ii(0x1012_52ad, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_52b4, 4); lgs(eax, memd[ss, ebp - 52]);           /* lgs eax, [ebp-0x34] */
            ii(0x1012_52b8, 4); mov(memw[gs, eax], dx);                 /* mov [gs:eax], dx */
            ii(0x1012_52bc, 3); mov(memw[ss, ebp - 48], ds);            /* mov [ebp-0x30], ds */
            ii(0x1012_52bf, 7); mov(memd[ss, ebp - 52], 0x1019_f14d);   /* mov dword [ebp-0x34], 0x1019f14d */
            ii(0x1012_52c6, 3); mov(ecx, memd[ss, ebp - 52]);           /* mov ecx, [ebp-0x34] */
            ii(0x1012_52c9, 3); mov(eax, memd[ss, ebp - 56]);           /* mov eax, [ebp-0x38] */
            ii(0x1012_52cc, 3); mov(ebx, memd[ss, ebp - 60]);           /* mov ebx, [ebp-0x3c] */
            ii(0x1012_52cf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_52d1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1012_52d3, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_52d5, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1012_52d7, 4); mov(memw[ss, ebp - 48], ax);            /* mov [ebp-0x30], ax */
            ii(0x1012_52db, 3); mov(memd[ss, ebp - 52], ebx);           /* mov [ebp-0x34], ebx */
            ii(0x1012_52de, 4); lgs(eax, memd[ss, ebp - 52]);           /* lgs eax, [ebp-0x34] */
            ii(0x1012_52e2, 6); mov(memw[gs, eax], 0x2cc);              /* mov word [gs:eax], 0x2cc */
            ii(0x1012_52e8, 3); mov(memw[ss, ebp - 48], ds);            /* mov [ebp-0x30], ds */
            ii(0x1012_52eb, 7); mov(memd[ss, ebp - 52], 0x1019_f151);   /* mov dword [ebp-0x34], 0x1019f151 */
            ii(0x1012_52f2, 3); mov(ecx, memd[ss, ebp - 52]);           /* mov ecx, [ebp-0x34] */
            ii(0x1012_52f5, 3); mov(eax, memd[ss, ebp - 56]);           /* mov eax, [ebp-0x38] */
            ii(0x1012_52f8, 3); mov(ebx, memd[ss, ebp - 60]);           /* mov ebx, [ebp-0x3c] */
            ii(0x1012_52fb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_52fd, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1012_52ff, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_5301, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1012_5303, 4); mov(memw[ss, ebp - 48], ax);            /* mov [ebp-0x30], ax */
            ii(0x1012_5307, 3); mov(memd[ss, ebp - 52], ebx);           /* mov [ebp-0x34], ebx */
            ii(0x1012_530a, 4); lgs(eax, memd[ss, ebp - 52]);           /* lgs eax, [ebp-0x34] */
            ii(0x1012_530e, 6); mov(memw[gs, eax], 0x133);              /* mov word [gs:eax], 0x133 */
            ii(0x1012_5314, 3); mov(memw[ss, ebp - 48], ds);            /* mov [ebp-0x30], ds */
            ii(0x1012_5317, 7); mov(memd[ss, ebp - 52], 0x1019_f156);   /* mov dword [ebp-0x34], 0x1019f156 */
            ii(0x1012_531e, 3); mov(ecx, memd[ss, ebp - 52]);           /* mov ecx, [ebp-0x34] */
            ii(0x1012_5321, 3); mov(eax, memd[ss, ebp - 56]);           /* mov eax, [ebp-0x38] */
            ii(0x1012_5324, 3); mov(ebx, memd[ss, ebp - 60]);           /* mov ebx, [ebp-0x3c] */
            ii(0x1012_5327, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_5329, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1012_532b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_532d, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1012_532f, 4); mov(memw[ss, ebp - 48], ax);            /* mov [ebp-0x30], ax */
            ii(0x1012_5333, 3); mov(memd[ss, ebp - 52], ebx);           /* mov [ebp-0x34], ebx */
            ii(0x1012_5336, 4); lgs(eax, memd[ss, ebp - 52]);           /* lgs eax, [ebp-0x34] */
            ii(0x1012_533a, 6); mov(memw[gs, eax], 0x400);              /* mov word [gs:eax], 0x400 */
            ii(0x1012_5340, 3); mov(memw[ss, ebp - 48], ds);            /* mov [ebp-0x30], ds */
            ii(0x1012_5343, 7); mov(memd[ss, ebp - 52], 0x1019_f15a);   /* mov dword [ebp-0x34], 0x1019f15a */
            ii(0x1012_534a, 3); mov(ecx, memd[ss, ebp - 52]);           /* mov ecx, [ebp-0x34] */
            ii(0x1012_534d, 3); mov(eax, memd[ss, ebp - 56]);           /* mov eax, [ebp-0x38] */
            ii(0x1012_5350, 3); mov(ebx, memd[ss, ebp - 60]);           /* mov ebx, [ebp-0x3c] */
            ii(0x1012_5353, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_5355, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1012_5357, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_5359, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1012_535b, 4); mov(memw[ss, ebp - 48], ax);            /* mov [ebp-0x30], ax */
            ii(0x1012_535f, 3); mov(memd[ss, ebp - 52], ebx);           /* mov [ebp-0x34], ebx */
            ii(0x1012_5362, 4); lgs(eax, memd[ss, ebp - 52]);           /* lgs eax, [ebp-0x34] */
            ii(0x1012_5366, 6); mov(memw[gs, eax], 0x400);              /* mov word [gs:eax], 0x400 */
            ii(0x1012_536c, 2); mov(eax, cs);                           /* mov eax, cs */
            ii(0x1012_536e, 5); mov(ebx, 0x1019_f000);                  /* mov ebx, 0x1019f000 */
            ii(0x1012_5373, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1012_5375, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1012_5377, 5); mov(ebx, 0x1019_f16a);                  /* mov ebx, 0x1019f16a */
            ii(0x1012_537c, 2); sub(ebx, edx);                          /* sub ebx, edx */
            ii(0x1012_537e, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1012_5380, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_5382, 5); add(eax, 0x800);                        /* add eax, 0x800 */
            ii(0x1012_5387, 5); mov(memd[ds, 0x101c_59b0], eax);        /* mov [0x101c59b0], eax */
            ii(0x1012_538c, 5); mov(edx, 0x101c_5988);                  /* mov edx, 0x101c5988 */
            ii(0x1012_5391, 5); mov(eax, memd[ds, 0x101c_59b0]);        /* mov eax, [0x101c59b0] */
            ii(0x1012_5396, 5); call(0x1012_4f2e, -0x46d);              /* call 0x10124f2e */
            ii(0x1012_539b, 3); mov(memd[ss, ebp - 64], eax);           /* mov [ebp-0x40], eax */
            ii(0x1012_539e, 4); cmp(memd[ss, ebp - 64], 0);             /* cmp dword [ebp-0x40], 0x0 */
            ii(0x1012_53a2, 2); if(jnz(0x1012_53b0, 0xc)) goto l_0x1012_53b0; /* jnz 0x101253b0 */
            ii(0x1012_53a4, 7); mov(memd[ss, ebp - 16], 0);             /* mov dword [ebp-0x10], 0x0 */
            ii(0x1012_53ab, 5); jmp(0x1012_57fc, 0x44c); goto l_0x1012_57fc; /* jmp 0x101257fc */
        l_0x1012_53b0:
            ii(0x1012_53b0, 6); push(memd[ds, 0x101c_59b0]);            /* push dword [0x101c59b0] */
            ii(0x1012_53b6, 2); mov(edx, cs);                           /* mov edx, cs */
            ii(0x1012_53b8, 5); mov(eax, 0x1019_f000);                  /* mov eax, 0x1019f000 */
            ii(0x1012_53bd, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1012_53bf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_53c1, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1012_53c3, 3); mov(esi, memd[ss, ebp - 64]);           /* mov esi, [ebp-0x40] */
            ii(0x1012_53c6, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1012_53c8, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1012_53ca, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_53cc, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1012_53ce, 5); call(/* sys */ 0x1017_d4ca, 0x5_80f7);  /* call 0x1017d4ca */
            ii(0x1012_53d3, 5); mov(ecx, 0x800);                        /* mov ecx, 0x800 */
            ii(0x1012_53d8, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1012_53da, 2); mov(eax, cs);                           /* mov eax, cs */
            ii(0x1012_53dc, 5); mov(edx, 0x1019_f000);                  /* mov edx, 0x1019f000 */
            ii(0x1012_53e1, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1012_53e3, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1012_53e5, 5); mov(edx, 0x1019_f16a);                  /* mov edx, 0x1019f16a */
            ii(0x1012_53ea, 2); sub(edx, ebx);                          /* sub edx, ebx */
            ii(0x1012_53ec, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1012_53ee, 2); mov(esi, ebx);                          /* mov esi, ebx */
            ii(0x1012_53f0, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1012_53f2, 3); mov(ebx, memd[ss, ebp - 64]);           /* mov ebx, [ebp-0x40] */
            ii(0x1012_53f5, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_53f7, 2); add(esi, ebx);                          /* add esi, ebx */
            ii(0x1012_53f9, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1012_53fb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_53fd, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1012_53ff, 5); call(/* sys */ 0x1017_d589, 0x5_8185);  /* call 0x1017d589 */
            ii(0x1012_5404, 3); mov(memw[ss, ebp - 56], cs);            /* mov [ebp-0x38], cs */
            ii(0x1012_5407, 7); mov(memd[ss, ebp - 60], 0x100c_dc26);   /* mov dword [ebp-0x3c], 0x100cdc26 */
            ii(0x1012_540e, 5); mov(eax, 0x1019_f15e);                  /* mov eax, 0x1019f15e */
            ii(0x1012_5413, 3); mov(ebx, memd[ss, ebp - 64]);           /* mov ebx, [ebp-0x40] */
            ii(0x1012_5416, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1012_5418, 2); mov(eax, cs);                           /* mov eax, cs */
            ii(0x1012_541a, 5); mov(edx, 0x1019_f000);                  /* mov edx, 0x1019f000 */
            ii(0x1012_541f, 2); sub(ebx, edx);                          /* sub ebx, edx */
            ii(0x1012_5421, 6); mov(memd[ds, 0x101c_5868], ebx);        /* mov [0x101c5868], ebx */
            ii(0x1012_5427, 5); mov(eax, 0x1019_f145);                  /* mov eax, 0x1019f145 */
            ii(0x1012_542c, 3); mov(ebx, memd[ss, ebp - 64]);           /* mov ebx, [ebp-0x40] */
            ii(0x1012_542f, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x1012_5431, 2); mov(eax, cs);                           /* mov eax, cs */
            ii(0x1012_5433, 5); mov(edx, 0x1019_f000);                  /* mov edx, 0x1019f000 */
            ii(0x1012_5438, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_543a, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1012_543c, 6); mov(memd[ds, 0x101c_586c], ebx);        /* mov [0x101c586c], ebx */
            ii(0x1012_5442, 5); mov(eax, 0x1019_f149);                  /* mov eax, 0x1019f149 */
            ii(0x1012_5447, 3); add(eax, memd[ss, ebp - 64]);           /* add eax, [ebp-0x40] */
            ii(0x1012_544a, 2); mov(edx, cs);                           /* mov edx, cs */
            ii(0x1012_544c, 5); mov(ebx, 0x1019_f000);                  /* mov ebx, 0x1019f000 */
            ii(0x1012_5451, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1012_5453, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1012_5455, 5); mov(memd[ds, 0x101c_5870], eax);        /* mov [0x101c5870], eax */
            ii(0x1012_545a, 5); mov(edx, 0x1019_f141);                  /* mov edx, 0x1019f141 */
            ii(0x1012_545f, 3); add(edx, memd[ss, ebp - 64]);           /* add edx, [ebp-0x40] */
            ii(0x1012_5462, 2); mov(eax, cs);                           /* mov eax, cs */
            ii(0x1012_5464, 5); mov(ebx, 0x1019_f000);                  /* mov ebx, 0x1019f000 */
            ii(0x1012_5469, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1012_546b, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1012_546d, 6); mov(memd[ds, 0x101c_5874], edx);        /* mov [0x101c5874], edx */
            ii(0x1012_5473, 5); mov(eax, 0x1019_f139);                  /* mov eax, 0x1019f139 */
            ii(0x1012_5478, 3); mov(edx, memd[ss, ebp - 64]);           /* mov edx, [ebp-0x40] */
            ii(0x1012_547b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_547d, 2); mov(eax, cs);                           /* mov eax, cs */
            ii(0x1012_547f, 5); mov(ebx, 0x1019_f000);                  /* mov ebx, 0x1019f000 */
            ii(0x1012_5484, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1012_5486, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1012_5488, 6); mov(memd[ds, 0x101c_5878], edx);        /* mov [0x101c5878], edx */
            ii(0x1012_548e, 5); mov(eax, 0x1019_f13d);                  /* mov eax, 0x1019f13d */
            ii(0x1012_5493, 3); mov(edx, memd[ss, ebp - 64]);           /* mov edx, [ebp-0x40] */
            ii(0x1012_5496, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_5498, 2); mov(eax, cs);                           /* mov eax, cs */
            ii(0x1012_549a, 5); mov(ebx, 0x1019_f000);                  /* mov ebx, 0x1019f000 */
            ii(0x1012_549f, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1012_54a1, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1012_54a3, 6); mov(memd[ds, 0x101c_587c], edx);        /* mov [0x101c587c], edx */
            ii(0x1012_54a9, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1012_54ab, 5); mov(ebx, 0x1019_f16a);                  /* mov ebx, 0x1019f16a */
            ii(0x1012_54b0, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1012_54b2, 3); add(edx, memd[ss, ebp - 64]);           /* add edx, [ebp-0x40] */
            ii(0x1012_54b5, 2); mov(eax, cs);                           /* mov eax, cs */
            ii(0x1012_54b7, 5); mov(ebx, 0x1019_f000);                  /* mov ebx, 0x1019f000 */
            ii(0x1012_54bc, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1012_54be, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1012_54c0, 6); mov(memd[ds, 0x101c_5980], edx);        /* mov [0x101c5980], edx */
            ii(0x1012_54c6, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1012_54c8, 5); mov(ebx, 0x1019_f16a);                  /* mov ebx, 0x1019f16a */
            ii(0x1012_54cd, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1012_54cf, 3); mov(edx, memd[ss, ebp - 64]);           /* mov edx, [ebp-0x40] */
            ii(0x1012_54d2, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_54d4, 2); mov(eax, cs);                           /* mov eax, cs */
            ii(0x1012_54d6, 5); mov(ebx, 0x1019_f000);                  /* mov ebx, 0x1019f000 */
            ii(0x1012_54db, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1012_54dd, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1012_54df, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_54e1, 5); add(eax, 0x400);                        /* add eax, 0x400 */
            ii(0x1012_54e6, 5); mov(memd[ds, 0x101c_5984], eax);        /* mov [0x101c5984], eax */
            ii(0x1012_54eb, 7); mov(memd[ss, ebp - 44], 0x205);         /* mov dword [ebp-0x2c], 0x205 */
            ii(0x1012_54f2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_54f4, 5); mov(al, memb[ds, 0x101b_b45a]);         /* mov al, [0x101bb45a] */
            ii(0x1012_54f9, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x1012_54fc, 3); mov(eax, memd[ss, ebp - 56]);           /* mov eax, [ebp-0x38] */
            ii(0x1012_54ff, 3); mov(ebx, memd[ss, ebp - 60]);           /* mov ebx, [ebp-0x3c] */
            ii(0x1012_5502, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_5504, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1012_5506, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_5508, 3); mov(ax, dx);                            /* mov ax, dx */
            ii(0x1012_550b, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1012_550e, 3); mov(eax, memd[ss, ebp - 60]);           /* mov eax, [ebp-0x3c] */
            ii(0x1012_5511, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1012_5514, 3); lea(ebx, memd[ss, ebp - 44]);           /* lea ebx, [ebp-0x2c] */
            ii(0x1012_5517, 3); lea(edx, memd[ss, ebp - 44]);           /* lea edx, [ebp-0x2c] */
            ii(0x1012_551a, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1012_551f, 5); call(/* sys */ 0x1016_c606, 0x4_70e2);  /* call 0x1016c606 */
            ii(0x1012_5524, 7); mov(memd[ss, ebp - 44], 0x600);         /* mov dword [ebp-0x2c], 0x600 */
            ii(0x1012_552b, 2); mov(eax, cs);                           /* mov eax, cs */
            ii(0x1012_552d, 5); mov(edx, 0x100c_dc26);                  /* mov edx, 0x100cdc26 */
            ii(0x1012_5532, 3); shr(edx, 0x10);                         /* shr edx, 0x10 */
            ii(0x1012_5535, 3); mov(memd[ss, ebp - 40], edx);           /* mov [ebp-0x28], edx */
            ii(0x1012_5538, 2); mov(eax, cs);                           /* mov eax, cs */
            ii(0x1012_553a, 5); mov(edx, 0x100c_dc26);                  /* mov edx, 0x100cdc26 */
            ii(0x1012_553f, 6); and(edx, 0xffff);                       /* and edx, 0xffff */
            ii(0x1012_5545, 3); mov(memd[ss, ebp - 36], edx);           /* mov [ebp-0x24], edx */
            ii(0x1012_5548, 7); mov(memd[ss, ebp - 28], 0);             /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1012_554f, 5); mov(eax, memd[ds, 0x100c_ddd5]);        /* mov eax, [0x100cddd5] */
            ii(0x1012_5554, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1012_5557, 3); lea(ebx, memd[ss, ebp - 44]);           /* lea ebx, [ebp-0x2c] */
            ii(0x1012_555a, 3); lea(edx, memd[ss, ebp - 44]);           /* lea edx, [ebp-0x2c] */
            ii(0x1012_555d, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1012_5562, 5); call(/* sys */ 0x1016_c606, 0x4_709f);  /* call 0x1016c606 */
            ii(0x1012_5567, 7); mov(memd[ss, ebp - 44], 0x600);         /* mov dword [ebp-0x2c], 0x600 */
            ii(0x1012_556e, 5); mov(eax, 0x101b_b45c);                  /* mov eax, 0x101bb45c */
            ii(0x1012_5573, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x1012_5576, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x1012_5579, 5); mov(eax, 0x101b_b45c);                  /* mov eax, 0x101bb45c */
            ii(0x1012_557e, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1012_5583, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1012_5586, 7); mov(memd[ss, ebp - 28], 0);             /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1012_558d, 7); mov(memd[ss, ebp - 24], 2);             /* mov dword [ebp-0x18], 0x2 */
            ii(0x1012_5594, 3); lea(ebx, memd[ss, ebp - 44]);           /* lea ebx, [ebp-0x2c] */
            ii(0x1012_5597, 3); lea(edx, memd[ss, ebp - 44]);           /* lea edx, [ebp-0x2c] */
            ii(0x1012_559a, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1012_559f, 5); call(/* sys */ 0x1016_c606, 0x4_7062);  /* call 0x1016c606 */
            ii(0x1012_55a4, 7); mov(memd[ss, ebp - 44], 0x201);         /* mov dword [ebp-0x2c], 0x201 */
            ii(0x1012_55ab, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_55ad, 5); mov(al, memb[ds, 0x101b_b45a]);         /* mov al, [0x101bb45a] */
            ii(0x1012_55b2, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x1012_55b5, 3); mov(eax, memd[ss, ebp - 64]);           /* mov eax, [ebp-0x40] */
            ii(0x1012_55b8, 3); shr(eax, 4);                            /* shr eax, 0x4 */
            ii(0x1012_55bb, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1012_55c0, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1012_55c3, 3); mov(eax, memd[ss, ebp - 64]);           /* mov eax, [ebp-0x40] */
            ii(0x1012_55c6, 3); and(eax, 0xf);                          /* and eax, 0xf */
            ii(0x1012_55c9, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1012_55cc, 3); lea(ebx, memd[ss, ebp - 44]);           /* lea ebx, [ebp-0x2c] */
            ii(0x1012_55cf, 3); lea(edx, memd[ss, ebp - 44]);           /* lea edx, [ebp-0x2c] */
            ii(0x1012_55d2, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1012_55d7, 5); call(/* sys */ 0x1016_c606, 0x4_702a);  /* call 0x1016c606 */
            ii(0x1012_55dc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_55de, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_55e5, 1); inc(edx);                               /* inc edx */
            ii(0x1012_55e6, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_55e8, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_55e9, 5); mov(memb[ds, 0x101c_599c], al);         /* mov [0x101c599c], al */
            ii(0x1012_55ee, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_55f0, 6); mov(ax, memw[ds, 0x101b_b45c]);         /* mov ax, [0x101bb45c] */
            ii(0x1012_55f6, 3); lea(edx, memd[ds, eax + 2]);            /* lea edx, [eax+0x2] */
            ii(0x1012_55f9, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_55fb, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_55fc, 5); mov(memb[ds, 0x101c_599d], al);         /* mov [0x101c599d], al */
            ii(0x1012_5601, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_5603, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_560a, 3); add(edx, 3);                            /* add edx, 0x3 */
            ii(0x1012_560d, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_560f, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_5610, 5); mov(memb[ds, 0x101c_599e], al);         /* mov [0x101c599e], al */
            ii(0x1012_5615, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_5617, 6); mov(ax, memw[ds, 0x101b_b45c]);         /* mov ax, [0x101bb45c] */
            ii(0x1012_561d, 3); lea(edx, memd[ds, eax + 4]);            /* lea edx, [eax+0x4] */
            ii(0x1012_5620, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_5622, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_5623, 5); mov(memb[ds, 0x101c_599f], al);         /* mov [0x101c599f], al */
            ii(0x1012_5628, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_562a, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_5631, 3); add(edx, 5);                            /* add edx, 0x5 */
            ii(0x1012_5634, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_5636, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_5637, 5); mov(memb[ds, 0x101c_59a0], al);         /* mov [0x101c59a0], al */
            ii(0x1012_563c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_563e, 6); mov(ax, memw[ds, 0x101b_b45c]);         /* mov ax, [0x101bb45c] */
            ii(0x1012_5644, 3); lea(edx, memd[ds, eax + 6]);            /* lea edx, [eax+0x6] */
            ii(0x1012_5647, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_5649, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_564a, 5); mov(memb[ds, 0x101c_59a1], al);         /* mov [0x101c59a1], al */
            ii(0x1012_564f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_5651, 6); mov(ax, memw[ds, 0x101b_b45c]);         /* mov ax, [0x101bb45c] */
            ii(0x1012_5657, 3); lea(edx, memd[ds, eax + 7]);            /* lea edx, [eax+0x7] */
            ii(0x1012_565a, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_565c, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_565d, 5); mov(memb[ds, 0x101c_59a2], al);         /* mov [0x101c59a2], al */
            ii(0x1012_5662, 5); mov(eax, 0x83);                         /* mov eax, 0x83 */
            ii(0x1012_5667, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_5669, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_5670, 3); add(edx, 3);                            /* add edx, 0x3 */
            ii(0x1012_5673, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_5674, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_5676, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_567d, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_567f, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_5680, 5); mov(memb[ds, 0x101c_599a], al);         /* mov [0x101c599a], al */
            ii(0x1012_5685, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_5687, 6); mov(ax, memw[ds, 0x101b_b45c]);         /* mov ax, [0x101bb45c] */
            ii(0x1012_568d, 3); lea(edx, memd[ds, eax + 1]);            /* lea edx, [eax+0x1] */
            ii(0x1012_5690, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_5692, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_5693, 5); mov(memb[ds, 0x101c_599b], al);         /* mov [0x101c599b], al */
            ii(0x1012_5698, 5); mov(eax, 3);                            /* mov eax, 0x3 */
            ii(0x1012_569d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_569f, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_56a6, 3); add(edx, 3);                            /* add edx, 0x3 */
            ii(0x1012_56a9, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_56aa, 5); mov(eax, 0xb);                          /* mov eax, 0xb */
            ii(0x1012_56af, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_56b1, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_56b8, 3); add(edx, 4);                            /* add edx, 0x4 */
            ii(0x1012_56bb, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_56bc, 5); mov(eax, 0x83);                         /* mov eax, 0x83 */
            ii(0x1012_56c1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_56c3, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_56ca, 3); add(edx, 3);                            /* add edx, 0x3 */
            ii(0x1012_56cd, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_56ce, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_56d1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_56d6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_56d8, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_56df, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_56e0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_56e3, 3); sar(eax, 8);                            /* sar eax, 0x8 */
            ii(0x1012_56e6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_56eb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_56ed, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_56f4, 1); inc(edx);                               /* inc edx */
            ii(0x1012_56f5, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_56f6, 5); mov(eax, 3);                            /* mov eax, 0x3 */
            ii(0x1012_56fb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_56fd, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_5704, 3); add(edx, 3);                            /* add edx, 0x3 */
            ii(0x1012_5707, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_5708, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_570a, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_5711, 3); add(edx, 5);                            /* add edx, 0x5 */
            ii(0x1012_5714, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_5716, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_5717, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_5719, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_5720, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_5722, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_5723, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_5725, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_572c, 3); add(edx, 2);                            /* add edx, 0x2 */
            ii(0x1012_572f, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_5731, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_5732, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x1012_5736, 3); cmp(edx, 4);                            /* cmp edx, 0x4 */
            ii(0x1012_5739, 2); if(jnz(0x1012_5787, 0x4c)) goto l_0x1012_5787; /* jnz 0x10125787 */
            ii(0x1012_573b, 5); mov(eax, 6);                            /* mov eax, 0x6 */
            ii(0x1012_5740, 5); mov(edx, 2);                            /* mov edx, 0x2 */
            ii(0x1012_5745, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_5746, 7); mov(memd[ss, ebp - 68], 0);             /* mov dword [ebp-0x44], 0x0 */
            ii(0x1012_574d, 2); jmp(0x1012_5755, 6); goto l_0x1012_5755; /* jmp 0x10125755 */
        l_0x1012_574f:
            ii(0x1012_574f, 3); mov(eax, memd[ss, ebp - 68]);           /* mov eax, [ebp-0x44] */
            ii(0x1012_5752, 3); inc(memd[ss, ebp - 68]);                /* inc dword [ebp-0x44] */
        l_0x1012_5755:
            ii(0x1012_5755, 4); movsx(eax, memw[ss, ebp - 68]);         /* movsx eax, word [ebp-0x44] */
            ii(0x1012_5759, 3); cmp(eax, 0x20);                         /* cmp eax, 0x20 */
            ii(0x1012_575c, 2); if(jge(0x1012_577c, 0x1e)) goto l_0x1012_577c; /* jge 0x1012577c */
            ii(0x1012_575e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_5760, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_5767, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_5769, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_576a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_576c, 6); mov(ax, memw[ds, 0x101b_b45c]);         /* mov ax, [0x101bb45c] */
            ii(0x1012_5772, 3); lea(edx, memd[ds, eax + 5]);            /* lea edx, [eax+0x5] */
            ii(0x1012_5775, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_5777, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_5778, 2); test(al, 1);                            /* test al, 0x1 */
            ii(0x1012_577a, 2); if(jz(0x1012_574f, -0x2d)) goto l_0x1012_574f; /* jz 0x1012574f */
        l_0x1012_577c:
            ii(0x1012_577c, 5); mov(eax, 0x87);                         /* mov eax, 0x87 */
            ii(0x1012_5781, 5); mov(edx, 2);                            /* mov edx, 0x2 */
            ii(0x1012_5786, 1); outb(dx, al);                           /* out dx, al */
        l_0x1012_5787:
            ii(0x1012_5787, 1); cli();                                  /* cli */
            ii(0x1012_5788, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x1012_578d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_578f, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_5796, 1); inc(edx);                               /* inc edx */
            ii(0x1012_5797, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_5798, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_579a, 7); mov(dx, memw[ds, 0x101b_b45c]);         /* mov dx, [0x101bb45c] */
            ii(0x1012_57a1, 3); add(edx, 6);                            /* add edx, 0x6 */
            ii(0x1012_57a4, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_57a6, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_57a7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_57a9, 6); mov(ax, memw[ds, 0x101b_b45c]);         /* mov ax, [0x101bb45c] */
            ii(0x1012_57af, 3); lea(edx, memd[ds, eax + 5]);            /* lea edx, [eax+0x5] */
            ii(0x1012_57b2, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_57b4, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_57b5, 5); mov(edx, 0x21);                         /* mov edx, 0x21 */
            ii(0x1012_57ba, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1012_57bc, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1012_57bd, 5); mov(memb[ds, 0x101c_5990], al);         /* mov [0x101c5990], al */
            ii(0x1012_57c2, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1012_57c4, 6); mov(cl, memb[ds, 0x101b_b45a]);         /* mov cl, [0x101bb45a] */
            ii(0x1012_57ca, 3); sub(ecx, 8);                            /* sub ecx, 0x8 */
            ii(0x1012_57cd, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1012_57d2, 2); shl(eax, cl);                           /* shl eax, cl */
            ii(0x1012_57d4, 2); not(eax);                               /* not eax */
            ii(0x1012_57d6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_57d8, 6); mov(dl, memb[ds, 0x101c_5990]);         /* mov dl, [0x101c5990] */
            ii(0x1012_57de, 2); and(eax, edx);                          /* and eax, edx */
            ii(0x1012_57e0, 5); mov(edx, 0x21);                         /* mov edx, 0x21 */
            ii(0x1012_57e5, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_57e6, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x1012_57eb, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1012_57f0, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_57f1, 1); sti();                                  /* sti */
            ii(0x1012_57f2, 1); cld();                                  /* cld */
            ii(0x1012_57f3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_57f5, 4); mov(ax, memw[ss, ebp - 4]);             /* mov ax, [ebp-0x4] */
            ii(0x1012_57f9, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
        l_0x1012_57fc:
            ii(0x1012_57fc, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_57ff, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_5801, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_5802, 1); pop(edi);                               /* pop edi */
            ii(0x1012_5803, 1); pop(esi);                               /* pop esi */
            ii(0x1012_5804, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_5805, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_5806, 1); ret();                                  /* ret */
        }
    }
}
