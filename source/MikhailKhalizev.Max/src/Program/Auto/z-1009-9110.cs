using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9110-13b758fb")]
        public void Method_1009_9110()
        {
            ii(0x1009_9110, 5); push(0x28);                             /* push 0x28 */
            ii(0x1009_9115, 5); call(Definitions.sys_check_available_stack_size, 0xc_cc38); /* call 0x10165d52 */
            ii(0x1009_911a, 1); push(ebx);                              /* push ebx */
            ii(0x1009_911b, 1); push(ecx);                              /* push ecx */
            ii(0x1009_911c, 1); push(edx);                              /* push edx */
            ii(0x1009_911d, 1); push(esi);                              /* push esi */
            ii(0x1009_911e, 1); push(edi);                              /* push edi */
            ii(0x1009_911f, 1); push(ebp);                              /* push ebp */
            ii(0x1009_9120, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9122, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_9128, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_912b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_912e, 4); cmp(memb[ds, eax + 0x1d], 0x3);         /* cmp byte [eax+0x1d], 0x3 */
            ii(0x1009_9132, 2); if(jle(0x1009_913d, 0x9)) goto l_0x1009_913d; /* jle 0x1009913d */
            ii(0x1009_9134, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_9138, 5); jmp(0x1009_92ce, 0x191); goto l_0x1009_92ce; /* jmp 0x100992ce */
        l_0x1009_913d:
            ii(0x1009_913d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_913f, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x1009_9144, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_9146, 2); if(jnz(0x1009_915d, 0x15)) goto l_0x1009_915d; /* jnz 0x1009915d */
            ii(0x1009_9148, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_914b, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_914e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_9151, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_9153, 6); mov(dl, memb[ds, 0x101c_37c8]);         /* mov dl, [0x101c37c8] */
            ii(0x1009_9159, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_915b, 2); if(jnz(0x1009_915f, 0x2)) goto l_0x1009_915f; /* jnz 0x1009915f */
        l_0x1009_915d:
            ii(0x1009_915d, 2); jmp(0x1009_9168, 0x9); goto l_0x1009_9168; /* jmp 0x10099168 */
        l_0x1009_915f:
            ii(0x1009_915f, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_9163, 5); jmp(0x1009_92ce, 0x166); goto l_0x1009_92ce; /* jmp 0x100992ce */
        l_0x1009_9168:
            ii(0x1009_9168, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_916b, 3); mov(edx, memd[ds, edx + 0x11]);         /* mov edx, [edx+0x11] */
            ii(0x1009_916e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_9171, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9174, 3); mov(eax, memd[ds, eax + 0x7]);          /* mov eax, [eax+0x7] */
            ii(0x1009_9177, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_917a, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1009_9180, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x1009_9185, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1009_9187, 5); call(0x100d_fd2c, 0x4_6ba0);            /* call 0x100dfd2c */
            ii(0x1009_918c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_918e, 5); call(0x100a_314c, 0x9fb9);              /* call 0x100a314c */
            ii(0x1009_9193, 4); cmp(ax, memw[ds, edx + 0x8]);           /* cmp ax, [edx+0x8] */
            ii(0x1009_9197, 2); if(jle(0x1009_91d3, 0x3a)) goto l_0x1009_91d3; /* jle 0x100991d3 */
            ii(0x1009_9199, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_919b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_919e, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1009_91a1, 5); call(0x1013_ad71, 0xa_1bcb);            /* call 0x1013ad71 */
            ii(0x1009_91a6, 2); test(al, al);                           /* test al, al */
            ii(0x1009_91a8, 2); if(jz(0x1009_91c8, 0x1e)) goto l_0x1009_91c8; /* jz 0x100991c8 */
            ii(0x1009_91aa, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_91ad, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1009_91b0, 5); call(0x1008_af28, -0xe28d);             /* call 0x1008af28 */
            ii(0x1009_91b5, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_91b8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_91bb, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x1009_91be, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_91c1, 3); call_abs(memd[ds, edx + 0x24]);         /* call dword [edx+0x24] */
            ii(0x1009_91c4, 2); test(al, al);                           /* test al, al */
            ii(0x1009_91c6, 2); if(jnz(0x1009_91ca, 0x2)) goto l_0x1009_91ca; /* jnz 0x100991ca */
        l_0x1009_91c8:
            ii(0x1009_91c8, 2); jmp(0x1009_91d3, 0x9); goto l_0x1009_91d3; /* jmp 0x100991d3 */
        l_0x1009_91ca:
            ii(0x1009_91ca, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_91ce, 5); jmp(0x1009_92ce, 0xfb); goto l_0x1009_92ce; /* jmp 0x100992ce */
        l_0x1009_91d3:
            ii(0x1009_91d3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_91d5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_91d8, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_91db, 5); call(0x1013_ad71, 0xa_1b91);            /* call 0x1013ad71 */
            ii(0x1009_91e0, 2); test(al, al);                           /* test al, al */
            ii(0x1009_91e2, 2); if(jz(0x1009_91ed, 0x9)) goto l_0x1009_91ed; /* jz 0x100991ed */
            ii(0x1009_91e4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_91e7, 4); cmp(memb[ds, eax + 0x1d], 0x3);         /* cmp byte [eax+0x1d], 0x3 */
            ii(0x1009_91eb, 2); if(jz(0x1009_91ef, 0x2)) goto l_0x1009_91ef; /* jz 0x100991ef */
        l_0x1009_91ed:
            ii(0x1009_91ed, 2); jmp(0x1009_9235, 0x46); goto l_0x1009_9235; /* jmp 0x10099235 */
        l_0x1009_91ef:
            ii(0x1009_91ef, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_91f2, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_91f5, 5); call(0x1007_6574, -0x2_2c86);           /* call 0x10076574 */
            ii(0x1009_91fa, 4); cmp(memb[ds, eax + 0x3e], 0x1);         /* cmp byte [eax+0x3e], 0x1 */
            ii(0x1009_91fe, 2); if(jnz(0x1009_922c, 0x2c)) goto l_0x1009_922c; /* jnz 0x1009922c */
            ii(0x1009_9200, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9203, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_9206, 5); call(0x1007_6574, -0x2_2c97);           /* call 0x10076574 */
            ii(0x1009_920b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_920d, 3); mov(bl, memb[ds, eax + 0x45]);          /* mov bl, [eax+0x45] */
            ii(0x1009_9210, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9213, 3); mov(edx, memd[ds, eax + 0x7]);          /* mov edx, [eax+0x7] */
            ii(0x1009_9216, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_9219, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_921c, 3); mov(eax, memd[ds, eax + 0x11]);         /* mov eax, [eax+0x11] */
            ii(0x1009_921f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_9222, 5); call(0x100d_4b64, 0x3_b93d);            /* call 0x100d4b64 */
            ii(0x1009_9227, 1); cwde();                                 /* cwde */
            ii(0x1009_9228, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x1009_922a, 2); if(jz(0x1009_9235, 0x9)) goto l_0x1009_9235; /* jz 0x10099235 */
        l_0x1009_922c:
            ii(0x1009_922c, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x1009_9230, 5); jmp(0x1009_92ce, 0x99); goto l_0x1009_92ce; /* jmp 0x100992ce */
        l_0x1009_9235:
            ii(0x1009_9235, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9238, 4); cmp(memb[ds, eax + 0x1d], 0x3);         /* cmp byte [eax+0x1d], 0x3 */
            ii(0x1009_923c, 2); if(jnz(0x1009_924f, 0x11)) goto l_0x1009_924f; /* jnz 0x1009924f */
            ii(0x1009_923e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_9240, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9243, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_9246, 5); call(0x1013_ad71, 0xa_1b26);            /* call 0x1013ad71 */
            ii(0x1009_924b, 2); test(al, al);                           /* test al, al */
            ii(0x1009_924d, 2); if(jnz(0x1009_9251, 0x2)) goto l_0x1009_9251; /* jnz 0x10099251 */
        l_0x1009_924f:
            ii(0x1009_924f, 2); jmp(0x1009_926b, 0x1a); goto l_0x1009_926b; /* jmp 0x1009926b */
        l_0x1009_9251:
            ii(0x1009_9251, 5); mov(ebx, 0xd);                          /* mov ebx, 0xd */
            ii(0x1009_9256, 5); mov(edx, 0x15);                         /* mov edx, 0x15 */
            ii(0x1009_925b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_925e, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_9261, 5); call(0x1007_65d0, -0x2_2c96);           /* call 0x100765d0 */
            ii(0x1009_9266, 5); call(0x1016_3053, 0xc_9de8);            /* call 0x10163053 */
        l_0x1009_926b:
            ii(0x1009_926b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_926e, 4); mov(memb[ds, eax + 0x1d], 0x5);         /* mov byte [eax+0x1d], 0x5 */
            ii(0x1009_9272, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_9274, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9277, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_927a, 5); call(0x1013_ad71, 0xa_1af2);            /* call 0x1013ad71 */
            ii(0x1009_927f, 2); test(al, al);                           /* test al, al */
            ii(0x1009_9281, 2); if(jz(0x1009_92a3, 0x20)) goto l_0x1009_92a3; /* jz 0x100992a3 */
            ii(0x1009_9283, 5); call(0x1008_a79c, -0xeaec);             /* call 0x1008a79c */
            ii(0x1009_9288, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_928a, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1009_928c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_928f, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_9292, 5); call(0x1007_65d0, -0x2_2cc7);           /* call 0x100765d0 */
            ii(0x1009_9297, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_9299, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_929e, 5); call(0x100a_53ac, 0xc109);              /* call 0x100a53ac */
        l_0x1009_92a3:
            ii(0x1009_92a3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_92a5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_92a8, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1009_92ab, 5); call(0x1007_6630, -0x2_2c80);           /* call 0x10076630 */
            ii(0x1009_92b0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_92b2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_92b5, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1009_92b8, 5); call(0x1008_afe4, -0xe2d9);             /* call 0x1008afe4 */
            ii(0x1009_92bd, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_92c0, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_92c5, 5); call(0x100a_5e27, 0xcb5d);              /* call 0x100a5e27 */
            ii(0x1009_92ca, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x1009_92ce:
            ii(0x1009_92ce, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1009_92d1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_92d3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_92d4, 1); pop(edi);                               /* pop edi */
            ii(0x1009_92d5, 1); pop(esi);                               /* pop esi */
            ii(0x1009_92d6, 1); pop(edx);                               /* pop edx */
            ii(0x1009_92d7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_92d8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_92d9, 1); ret();                                  /* ret */
        }
    }
}
