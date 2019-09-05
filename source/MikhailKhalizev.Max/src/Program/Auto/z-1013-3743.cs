using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_3743-dc0c4525")]
        public void Method_1013_3743()
        {
            ii(0x1013_3743, 5);  push(0x38);                           /* push 0x38 */
            ii(0x1013_3748, 5);  call(Definitions.sys_check_available_stack_size, 0x3_2605);/* call 0x10165d52 */
            ii(0x1013_374d, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_374e, 1);  push(esi);                            /* push esi */
            ii(0x1013_374f, 1);  push(edi);                            /* push edi */
            ii(0x1013_3750, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_3751, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_3753, 6);  sub(esp, 0x24);                       /* sub esp, 0x24 */
            ii(0x1013_3759, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_375c, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1013_375f, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1013_3762, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1013_3766, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1013_376c, 5);  mov(edx, 0x101c_a468);                /* mov edx, 0x101ca468 */
            ii(0x1013_3771, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1013_3773, 4);  movsx(eax, memb[ss, ebp - 4]);        /* movsx eax, byte [ebp-0x4] */
            ii(0x1013_3777, 3);  imul(eax, eax, 0xc);                  /* imul eax, eax, 0xc */
            ii(0x1013_377a, 6);  add(edx, 0x88);                       /* add edx, 0x88 */
            ii(0x1013_3780, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1013_3782, 3);  mov(memd[ss, ebp - 16], edx);         /* mov [ebp-0x10], edx */
            ii(0x1013_3785, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_3788, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x1013_378b, 2);  if(jnz(0x1013_3799, 0xc)) goto l_0x1013_3799;/* jnz 0x10133799 */
            ii(0x1013_378d, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1013_3794, 5);  jmp(0x1013_38b1, 0x118); goto l_0x1013_38b1;/* jmp 0x101338b1 */
        l_0x1013_3799:
            ii(0x1013_3799, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1013_379d, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1013_37a1, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x1013_37a7, 6);  mov(eax, memd[ds, eax + 0x101c_a562]);/* mov eax, [eax+0x101ca562] */
            ii(0x1013_37ad, 5);  call(0x100c_b6b0, -0x6_8102);         /* call 0x100cb6b0 */
            ii(0x1013_37b2, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1013_37b4, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1013_37b7, 5);  call(0x1007_6800, -0xb_cfbc);         /* call 0x10076800 */
            ii(0x1013_37bc, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1013_37bf, 3);  mov(memb[ss, ebp - 24], al);          /* mov [ebp-0x18], al */
            ii(0x1013_37c2, 5);  jmp(0x1013_3868, 0xa1); goto l_0x1013_3868;/* jmp 0x10133868 */
        l_0x1013_37c7:
            ii(0x1013_37c7, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1013_37ca, 5);  call(0x1007_6730, -0xb_d09f);         /* call 0x10076730 */
            ii(0x1013_37cf, 4);  mov(ax, memw[ds, eax + 14]);          /* mov ax, [eax+0xe] */
            ii(0x1013_37d3, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_37d6, 5);  jmp(0x1013_3883, 0xa8); goto l_0x1013_3883;/* jmp 0x10133883 */
        l_0x1013_37db:
            ii(0x1013_37db, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1013_37de, 5);  call(0x1007_6730, -0xb_d0b3);         /* call 0x10076730 */
            ii(0x1013_37e3, 4);  mov(ax, memw[ds, eax + 20]);          /* mov ax, [eax+0x14] */
            ii(0x1013_37e7, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_37ea, 5);  jmp(0x1013_3883, 0x94); goto l_0x1013_3883;/* jmp 0x10133883 */
        l_0x1013_37ef:
            ii(0x1013_37ef, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1013_37f2, 5);  call(0x1007_6730, -0xb_d0c7);         /* call 0x10076730 */
            ii(0x1013_37f7, 4);  mov(ax, memw[ds, eax + 18]);          /* mov ax, [eax+0x12] */
            ii(0x1013_37fb, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_37fe, 5);  jmp(0x1013_3883, 0x80); goto l_0x1013_3883;/* jmp 0x10133883 */
        l_0x1013_3803:
            ii(0x1013_3803, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1013_3806, 5);  call(0x1007_6730, -0xb_d0db);         /* call 0x10076730 */
            ii(0x1013_380b, 4);  mov(ax, memw[ds, eax + 12]);          /* mov ax, [eax+0xc] */
            ii(0x1013_380f, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_3812, 5);  jmp(0x1013_3883, 0x6c); goto l_0x1013_3883;/* jmp 0x10133883 */
        l_0x1013_3817:
            ii(0x1013_3817, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1013_381a, 5);  call(0x1007_6730, -0xb_d0ef);         /* call 0x10076730 */
            ii(0x1013_381f, 4);  mov(ax, memw[ds, eax + 10]);          /* mov ax, [eax+0xa] */
            ii(0x1013_3823, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_3826, 2);  jmp(0x1013_3883, 0x5b); goto l_0x1013_3883;/* jmp 0x10133883 */
        l_0x1013_3828:
            ii(0x1013_3828, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1013_382b, 5);  call(0x1007_6730, -0xb_d100);         /* call 0x10076730 */
            ii(0x1013_3830, 4);  mov(ax, memw[ds, eax + 16]);          /* mov ax, [eax+0x10] */
            ii(0x1013_3834, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_3837, 2);  jmp(0x1013_3883, 0x4a); goto l_0x1013_3883;/* jmp 0x10133883 */
        l_0x1013_3839:
            ii(0x1013_3839, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1013_383c, 5);  call(0x1007_6730, -0xb_d111);         /* call 0x10076730 */
            ii(0x1013_3841, 4);  mov(ax, memw[ds, eax + 23]);          /* mov ax, [eax+0x17] */
            ii(0x1013_3845, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_3848, 2);  jmp(0x1013_3883, 0x39); goto l_0x1013_3883;/* jmp 0x10133883 */
        l_0x1013_384a:
            ii(0x1013_384a, 2);  jmp(0x1013_3883, 0x37); goto l_0x1013_3883;/* jmp 0x10133883 */
        //  ii(0x1013_384c, 28);  /* Служебная область с абсолютными адресами переходов. (0x1013_37c7, 0x1013_37db, 0x1013_37ef, 0x1013_3803, 0x1013_3817, 0x1013_3828, 0x1013_3839). */
        l_0x1013_3868:
            ii(0x1013_3868, 3);  mov(al, memb[ss, ebp - 24]);          /* mov al, [ebp-0x18] */
            ii(0x1013_386b, 3);  mov(memb[ss, ebp - 36], al);          /* mov [ebp-0x24], al */
            ii(0x1013_386e, 4);  cmp(memb[ss, ebp - 36], 6);           /* cmp byte [ebp-0x24], 0x6 */
            ii(0x1013_3872, 2);  if(ja(0x1013_384a, -0x2a)) goto l_0x1013_384a;/* ja 0x1013384a */
            ii(0x1013_3874, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1013_3876, 3);  mov(al, memb[ss, ebp - 36]);          /* mov al, [ebp-0x24] */
            ii(0x1013_3879, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1013_387c, 7);  /* jmp dword [cs:eax+0x1013384c] */
            switch (jmp_abs_switch(memd[cs, eax + 0x1013_384c]))
            {
                case 0x1013_37c7:
                    goto l_0x1013_37c7;
                case 0x1013_37db:
                    goto l_0x1013_37db;
                case 0x1013_37ef:
                    goto l_0x1013_37ef;
                case 0x1013_3803:
                    goto l_0x1013_3803;
                case 0x1013_3817:
                    goto l_0x1013_3817;
                case 0x1013_3828:
                    goto l_0x1013_3828;
                case 0x1013_3839:
                    goto l_0x1013_3839;
                default:
                    throw new NotImplementedException();
            }
        l_0x1013_3883:
            ii(0x1013_3883, 4);  movsx(edx, memw[ss, ebp - 32]);       /* movsx edx, word [ebp-0x20] */
            ii(0x1013_3887, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_388a, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1013_388c, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x1013_388f, 5);  mov(ebx, 0xa);                        /* mov ebx, 0xa */
            ii(0x1013_3894, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_3896, 2);  div(ebx);                             /* div ebx */
            ii(0x1013_3898, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_389b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_389d, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1013_38a0, 5);  call(0x1007_5eec, -0xb_d9b9);         /* call 0x10075eec */
            ii(0x1013_38a5, 2);  jmp(0x1013_38b1, 0xa); goto l_0x1013_38b1;/* jmp 0x101338b1 */
        //  ii(0x1013_38a7, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x1013_38a9, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
        //  ii(0x1013_38ac, 5);  call(0x1007_5eec, -0xb_d9c5);         /* call 0x10075eec */
        l_0x1013_38b1:
            ii(0x1013_38b1, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_38b4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_38b6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_38b7, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_38b8, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_38b9, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_38ba, 1);  ret();                                /* ret */
        }
    }
}
