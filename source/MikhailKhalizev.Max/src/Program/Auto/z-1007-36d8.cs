using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_36d8-739670bf")]
        public void Method_1007_36d8()
        {
            ii(0x1007_36d8, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1007_36dd, 5);  call(Definitions.sys_check_available_stack_size, 0xf_2670);/* call 0x10165d52 */
            ii(0x1007_36e2, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_36e3, 1);  push(esi);                            /* push esi */
            ii(0x1007_36e4, 1);  push(edi);                            /* push edi */
            ii(0x1007_36e5, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_36e6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_36e8, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1007_36ee, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_36f1, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_36f4, 3);  mov(memd[ss, ebp - 12], ebx);         /* mov [ebp-0xc], ebx */
            ii(0x1007_36f7, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1007_36fb, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_36fd, 2);  if(jl(0x1007_370b, 0xc)) goto l_0x1007_370b;/* jl 0x1007370b */
            ii(0x1007_36ff, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_3702, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x1007_3709, 2);  if(jl(0x1007_370d, 2)) goto l_0x1007_370d;/* jl 0x1007370d */
        l_0x1007_370b:
            ii(0x1007_370b, 2);  jmp(0x1007_3715, 8); goto l_0x1007_3715;/* jmp 0x10073715 */
        l_0x1007_370d:
            ii(0x1007_370d, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_3711, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_3713, 2);  if(jge(0x1007_3717, 2)) goto l_0x1007_3717;/* jge 0x10073717 */
        l_0x1007_3715:
            ii(0x1007_3715, 2);  jmp(0x1007_3723, 0xc); goto l_0x1007_3723;/* jmp 0x10073723 */
        l_0x1007_3717:
            ii(0x1007_3717, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_371a, 7);  cmp(ax, memw[ds, 0x101c_8174]);       /* cmp ax, [0x101c8174] */
            ii(0x1007_3721, 2);  if(jl(0x1007_372f, 0xc)) goto l_0x1007_372f;/* jl 0x1007372f */
        l_0x1007_3723:
            ii(0x1007_3723, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_372a, 5);  jmp(0x1007_3881, 0x152); goto l_0x1007_3881;/* jmp 0x10073881 */
        l_0x1007_372f:
            ii(0x1007_372f, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1007_3733, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1007_3737, 5);  mov(eax, 0x101c_39b8);                /* mov eax, 0x101c39b8 */
            ii(0x1007_373c, 5);  call(0x1010_3541, 0x8_fe00);          /* call 0x10103541 */
            ii(0x1007_3741, 3);  lea(ebx, memd[ss, ebp - 20]);         /* lea ebx, [ebp-0x14] */
            ii(0x1007_3744, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_3746, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_3748, 5);  call(0x1007_64b8, 0x2d6b);            /* call 0x100764b8 */
            ii(0x1007_374d, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3750, 5);  call(0x1007_6408, 0x2cb3);            /* call 0x10076408 */
            ii(0x1007_3755, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
        l_0x1007_3758:
            ii(0x1007_3758, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_375a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_375d, 5);  call(0x1013_ad71, 0xc_760f);          /* call 0x1013ad71 */
            ii(0x1007_3762, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_3764, 6);  if(jz(0x1007_3864, 0xfa)) goto l_0x1007_3864;/* jz 0x10073864 */
            ii(0x1007_376a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_376d, 5);  call(0x1007_63a0, 0x2c2e);            /* call 0x100763a0 */
            ii(0x1007_3772, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1007_3775, 3);  test(memd[ss, ebp - 12], eax);        /* test [ebp-0xc], eax */
            ii(0x1007_3778, 2);  if(jz(0x1007_3788, 0xe)) goto l_0x1007_3788;/* jz 0x10073788 */
            ii(0x1007_377a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_377d, 5);  call(0x1007_63a0, 0x2c1e);            /* call 0x100763a0 */
            ii(0x1007_3782, 4);  test(memb[ds, eax + 18], 1);          /* test byte [eax+0x12], 0x1 */
            ii(0x1007_3786, 2);  if(jz(0x1007_378a, 2)) goto l_0x1007_378a;/* jz 0x1007378a */
        l_0x1007_3788:
            ii(0x1007_3788, 2);  jmp(0x1007_3798, 0xe); goto l_0x1007_3798;/* jmp 0x10073798 */
        l_0x1007_378a:
            ii(0x1007_378a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_378d, 5);  call(0x1007_63a0, 0x2c0e);            /* call 0x100763a0 */
            ii(0x1007_3792, 4);  cmp(memb[ds, eax + 61], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_3796, 2);  if(jnz(0x1007_379a, 2)) goto l_0x1007_379a;/* jnz 0x1007379a */
        l_0x1007_3798:
            ii(0x1007_3798, 2);  jmp(0x1007_37b4, 0x1a); goto l_0x1007_37b4;/* jmp 0x100737b4 */
        l_0x1007_379a:
            ii(0x1007_379a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_379d, 5);  call(0x1007_6408, 0x2c66);            /* call 0x10076408 */
            ii(0x1007_37a2, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_37a5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_37a7, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_37aa, 5);  call(0x1007_5f6c, 0x27bd);            /* call 0x10075f6c */
            ii(0x1007_37af, 5);  jmp(0x1007_3881, 0xcd); goto l_0x1007_3881;/* jmp 0x10073881 */
        l_0x1007_37b4:
            ii(0x1007_37b4, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_37b7, 5);  call(0x1007_63d4, 0x2c18);            /* call 0x100763d4 */
            ii(0x1007_37bc, 5);  mov(ebx, 0x101c_39b8);                /* mov ebx, 0x101c39b8 */
            ii(0x1007_37c1, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_37c3, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_37c5, 5);  call(0x1010_3752, 0x8_ff88);          /* call 0x10103752 */
            ii(0x1007_37ca, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1007_37cf, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_37d2, 5);  call(0x1007_63d4, 0x2bfd);            /* call 0x100763d4 */
            ii(0x1007_37d7, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_37d9, 5);  mov(eax, 0x101c_39b8);                /* mov eax, 0x101c39b8 */
            ii(0x1007_37de, 5);  call(0x1010_346f, 0x8_fc8c);          /* call 0x1010346f */
            ii(0x1007_37e3, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_37e6, 5);  call(0x1007_6bf8, 0x340d);            /* call 0x10076bf8 */
            ii(0x1007_37eb, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_37ed, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_37f0, 5);  call(0x1013_ad71, 0xc_757c);          /* call 0x1013ad71 */
            ii(0x1007_37f5, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_37f7, 2);  if(jz(0x1007_385f, 0x66)) goto l_0x1007_385f;/* jz 0x1007385f */
            ii(0x1007_37f9, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_37fc, 5);  call(0x1007_6408, 0x2c07);            /* call 0x10076408 */
            ii(0x1007_3801, 3);  cmp(eax, memd[ss, ebp - 24]);         /* cmp eax, [ebp-0x18] */
            ii(0x1007_3804, 2);  if(jnz(0x1007_3840, 0x3a)) goto l_0x1007_3840;/* jnz 0x10073840 */
            ii(0x1007_3806, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3809, 5);  call(0x1007_63a0, 0x2b92);            /* call 0x100763a0 */
            ii(0x1007_380e, 3);  mov(eax, memd[ds, eax + 18]);         /* mov eax, [eax+0x12] */
            ii(0x1007_3811, 3);  test(memd[ss, ebp - 12], eax);        /* test [ebp-0xc], eax */
            ii(0x1007_3814, 2);  if(jz(0x1007_382d, 0x17)) goto l_0x1007_382d;/* jz 0x1007382d */
            ii(0x1007_3816, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3819, 5);  call(0x1007_6408, 0x2bea);            /* call 0x10076408 */
            ii(0x1007_381e, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_3821, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_3823, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3826, 5);  call(0x1007_5f6c, 0x2741);            /* call 0x10075f6c */
            ii(0x1007_382b, 2);  jmp(0x1007_3881, 0x54); goto l_0x1007_3881;/* jmp 0x10073881 */
        l_0x1007_382d:
            ii(0x1007_382d, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_3834, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_3836, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3839, 5);  call(0x1007_5f6c, 0x272e);            /* call 0x10075f6c */
            ii(0x1007_383e, 2);  jmp(0x1007_3881, 0x41); goto l_0x1007_3881;/* jmp 0x10073881 */
        l_0x1007_3840:
            ii(0x1007_3840, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_3843, 5);  cmp(memw[ds, eax + 8], 0xf);          /* cmp word [eax+0x8], 0xf */
            ii(0x1007_3848, 2);  if(jz(0x1007_3854, 0xa)) goto l_0x1007_3854;/* jz 0x10073854 */
            ii(0x1007_384a, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_384d, 5);  cmp(memw[ds, eax + 8], 0x10);         /* cmp word [eax+0x8], 0x10 */
            ii(0x1007_3852, 2);  if(jnz(0x1007_385f, 0xb)) goto l_0x1007_385f;/* jnz 0x1007385f */
        l_0x1007_3854:
            ii(0x1007_3854, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3857, 5);  call(0x1007_6408, 0x2bac);            /* call 0x10076408 */
            ii(0x1007_385c, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
        l_0x1007_385f:
            ii(0x1007_385f, 5);  jmp(0x1007_3758, -0x10c); goto l_0x1007_3758;/* jmp 0x10073758 */
        l_0x1007_3864:
            ii(0x1007_3864, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_386b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_386d, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3870, 5);  call(0x1007_5f6c, 0x26f7);            /* call 0x10075f6c */
            ii(0x1007_3875, 2);  jmp(0x1007_3881, 0xa); goto l_0x1007_3881;/* jmp 0x10073881 */
        //  ii(0x1007_3877, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x1007_3879, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
        //  ii(0x1007_387c, 5);  call(0x1007_5f6c, 0x26eb);            /* call 0x10075f6c */
        l_0x1007_3881:
            ii(0x1007_3881, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_3884, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_3886, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_3887, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_3888, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_3889, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_388a, 1);  ret();                                /* ret */
        }
    }
}
