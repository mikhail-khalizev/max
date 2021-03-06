using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_432c-f615e5f9")]
        public void Method_100a_432c()
        {
            ii(0x100a_432c, 5);  push(0x30);                           /* push 0x30 */
            ii(0x100a_4331, 5);  call(Definitions.sys_check_available_stack_size, 0xc_1a1c);/* call 0x10165d52 */
            ii(0x100a_4336, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_4337, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_4338, 1);  push(esi);                            /* push esi */
            ii(0x100a_4339, 1);  push(edi);                            /* push edi */
            ii(0x100a_433a, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_433b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_433d, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x100a_4343, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_4346, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_4349, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x100a_434d, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_4350, 5);  call(0x1007_64fc, -0x2_de59);         /* call 0x100764fc */
            ii(0x100a_4355, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_4358, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x100a_435c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_435f, 3);  mov(al, memb[ds, eax + 84]);          /* mov al, [eax+0x54] */
            ii(0x100a_4362, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_4367, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_4369, 2);  if(jnz(0x100a_437a, 0xf)) goto l_0x100a_437a;/* jnz 0x100a437a */
            ii(0x100a_436b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_436d, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_4370, 5);  call(0x1007_5f6c, -0x2_e409);         /* call 0x10075f6c */
            ii(0x100a_4375, 5);  jmp(0x100a_4548, 0x1ce); goto l_0x100a_4548;/* jmp 0x100a4548 */
        l_0x100a_437a:
            ii(0x100a_437a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_437d, 5);  call(0x1007_623c, -0x2_e146);         /* call 0x1007623c */
            ii(0x100a_4382, 4);  mov(ax, memw[ds, eax + 18]);          /* mov ax, [eax+0x12] */
            ii(0x100a_4386, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_4389, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_438c, 4);  imul(eax, memd[ss, ebp - 16]);        /* imul eax, [ebp-0x10] */
            ii(0x100a_4390, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_4393, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_4396, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100a_4399, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_439c, 5);  call(0x1007_4705, -0x2_fc9c);         /* call 0x10074705 */
            ii(0x100a_43a1, 3);  test(ah, 1);                          /* test ah, 0x1 */
            ii(0x100a_43a4, 6);  if(jz(0x100a_4469, 0xbf)) goto l_0x100a_4469;/* jz 0x100a4469 */
            ii(0x100a_43aa, 5);  mov(eax, 0x101c_8184);                /* mov eax, 0x101c8184 */
            ii(0x100a_43af, 5);  call(0x1007_6338, -0x2_e07c);         /* call 0x10076338 */
            ii(0x100a_43b4, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x100a_43b7, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_43b9, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100a_43bb, 5);  call(0x1007_643c, -0x2_df84);         /* call 0x1007643c */
            ii(0x100a_43c0, 2);  jmp(0x100a_43ca, 8); goto l_0x100a_43ca;/* jmp 0x100a43ca */
        l_0x100a_43c2:
            ii(0x100a_43c2, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_43c5, 5);  call(0x1007_6bf8, -0x2_d7d2);         /* call 0x10076bf8 */
        l_0x100a_43ca:
            ii(0x100a_43ca, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_43cc, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_43cf, 5);  call(0x1013_ad71, 0x9_699d);          /* call 0x1013ad71 */
            ii(0x100a_43d4, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_43d6, 6);  if(jz(0x100a_4469, 0x8d)) goto l_0x100a_4469;/* jz 0x100a4469 */
            ii(0x100a_43dc, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_43df, 5);  call(0x1007_63a0, -0x2_e044);         /* call 0x100763a0 */
            ii(0x100a_43e4, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100a_43e7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_43ea, 3);  cmp(dl, memb[ds, eax + 38]);          /* cmp dl, [eax+0x26] */
            ii(0x100a_43ed, 2);  if(jz(0x100a_440b, 0x1c)) goto l_0x100a_440b;/* jz 0x100a440b */
            ii(0x100a_43ef, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_43f2, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x100a_43f5, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x100a_43f7, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100a_43fa, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_43fd, 5);  call(0x1007_63a0, -0x2_e062);         /* call 0x100763a0 */
            ii(0x100a_4402, 5);  call(0x1007_6074, -0x2_e393);         /* call 0x10076074 */
            ii(0x100a_4407, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_4409, 2);  if(jnz(0x100a_440d, 2)) goto l_0x100a_440d;/* jnz 0x100a440d */
        l_0x100a_440b:
            ii(0x100a_440b, 2);  jmp(0x100a_4433, 0x26); goto l_0x100a_4433;/* jmp 0x100a4433 */
        l_0x100a_440d:
            ii(0x100a_440d, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_4410, 5);  call(0x1007_63a0, -0x2_e075);         /* call 0x100763a0 */
            ii(0x100a_4415, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x100a_4418, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_441d, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100a_4423, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_4429, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_442e, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100a_4431, 2);  if(jz(0x100a_4435, 2)) goto l_0x100a_4435;/* jz 0x100a4435 */
        l_0x100a_4433:
            ii(0x100a_4433, 2);  jmp(0x100a_444b, 0x16); goto l_0x100a_444b;/* jmp 0x100a444b */
        l_0x100a_4435:
            ii(0x100a_4435, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_4438, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_443b, 5);  call(0x1007_63d4, -0x2_e06c);         /* call 0x100763d4 */
            ii(0x100a_4440, 5);  call(0x1007_0d01, -0x3_3744);         /* call 0x10070d01 */
            ii(0x100a_4445, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x100a_4449, 2);  if(jle(0x100a_444d, 2)) goto l_0x100a_444d;/* jle 0x100a444d */
        l_0x100a_444b:
            ii(0x100a_444b, 2);  jmp(0x100a_4464, 0x17); goto l_0x100a_4464;/* jmp 0x100a4464 */
        l_0x100a_444d:
            ii(0x100a_444d, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_4450, 5);  call(0x1007_63d4, -0x2_e081);         /* call 0x100763d4 */
            ii(0x100a_4455, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x100a_4458, 3);  add(ebx, 0x28);                       /* add ebx, 0x28 */
            ii(0x100a_445b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_445d, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100a_445f, 5);  call(0x1008_ab1c, -0x1_9948);         /* call 0x1008ab1c */
        l_0x100a_4464:
            ii(0x100a_4464, 5);  jmp(0x100a_43c2, -0xa7); goto l_0x100a_43c2;/* jmp 0x100a43c2 */
        l_0x100a_4469:
            ii(0x100a_4469, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_446c, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100a_446f, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_4472, 5);  call(0x1007_4705, -0x2_fd72);         /* call 0x10074705 */
            ii(0x100a_4477, 2);  test(al, 0x40);                       /* test al, 0x40 */
            ii(0x100a_4479, 6);  if(jz(0x100a_453e, 0xbf)) goto l_0x100a_453e;/* jz 0x100a453e */
            ii(0x100a_447f, 5);  mov(eax, 0x101c_81a8);                /* mov eax, 0x101c81a8 */
            ii(0x100a_4484, 5);  call(0x1007_6338, -0x2_e151);         /* call 0x10076338 */
            ii(0x100a_4489, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x100a_448c, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_448e, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100a_4490, 5);  call(0x1007_643c, -0x2_e059);         /* call 0x1007643c */
            ii(0x100a_4495, 2);  jmp(0x100a_449f, 8); goto l_0x100a_449f;/* jmp 0x100a449f */
        l_0x100a_4497:
            ii(0x100a_4497, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_449a, 5);  call(0x1007_6bf8, -0x2_d8a7);         /* call 0x10076bf8 */
        l_0x100a_449f:
            ii(0x100a_449f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_44a1, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_44a4, 5);  call(0x1013_ad71, 0x9_68c8);          /* call 0x1013ad71 */
            ii(0x100a_44a9, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_44ab, 6);  if(jz(0x100a_453e, 0x8d)) goto l_0x100a_453e;/* jz 0x100a453e */
            ii(0x100a_44b1, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_44b4, 5);  call(0x1007_63a0, -0x2_e119);         /* call 0x100763a0 */
            ii(0x100a_44b9, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x100a_44bc, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_44bf, 3);  cmp(dl, memb[ds, eax + 38]);          /* cmp dl, [eax+0x26] */
            ii(0x100a_44c2, 2);  if(jz(0x100a_44e0, 0x1c)) goto l_0x100a_44e0;/* jz 0x100a44e0 */
            ii(0x100a_44c4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_44c7, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x100a_44ca, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x100a_44cc, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100a_44cf, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_44d2, 5);  call(0x1007_63a0, -0x2_e137);         /* call 0x100763a0 */
            ii(0x100a_44d7, 5);  call(0x1007_6074, -0x2_e468);         /* call 0x10076074 */
            ii(0x100a_44dc, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_44de, 2);  if(jnz(0x100a_44e2, 2)) goto l_0x100a_44e2;/* jnz 0x100a44e2 */
        l_0x100a_44e0:
            ii(0x100a_44e0, 2);  jmp(0x100a_4508, 0x26); goto l_0x100a_4508;/* jmp 0x100a4508 */
        l_0x100a_44e2:
            ii(0x100a_44e2, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_44e5, 5);  call(0x1007_63a0, -0x2_e14a);         /* call 0x100763a0 */
            ii(0x100a_44ea, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x100a_44ed, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_44f2, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100a_44f8, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100a_44fe, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100a_4503, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100a_4506, 2);  if(jz(0x100a_450a, 2)) goto l_0x100a_450a;/* jz 0x100a450a */
        l_0x100a_4508:
            ii(0x100a_4508, 2);  jmp(0x100a_4520, 0x16); goto l_0x100a_4520;/* jmp 0x100a4520 */
        l_0x100a_450a:
            ii(0x100a_450a, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_450d, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_4510, 5);  call(0x1007_63d4, -0x2_e141);         /* call 0x100763d4 */
            ii(0x100a_4515, 5);  call(0x1007_0d01, -0x3_3819);         /* call 0x10070d01 */
            ii(0x100a_451a, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x100a_451e, 2);  if(jle(0x100a_4522, 2)) goto l_0x100a_4522;/* jle 0x100a4522 */
        l_0x100a_4520:
            ii(0x100a_4520, 2);  jmp(0x100a_4539, 0x17); goto l_0x100a_4539;/* jmp 0x100a4539 */
        l_0x100a_4522:
            ii(0x100a_4522, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_4525, 5);  call(0x1007_63d4, -0x2_e156);         /* call 0x100763d4 */
            ii(0x100a_452a, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x100a_452d, 3);  add(ebx, 0x28);                       /* add ebx, 0x28 */
            ii(0x100a_4530, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_4532, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100a_4534, 5);  call(0x1008_ab1c, -0x1_9a1d);         /* call 0x1008ab1c */
        l_0x100a_4539:
            ii(0x100a_4539, 5);  jmp(0x100a_4497, -0xa7); goto l_0x100a_4497;/* jmp 0x100a4497 */
        l_0x100a_453e:
            ii(0x100a_453e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_4540, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_4543, 5);  call(0x1007_5f6c, -0x2_e5dc);         /* call 0x10075f6c */
        l_0x100a_4548:
            ii(0x100a_4548, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_454a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_454b, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_454c, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_454d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_454e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_454f, 1);  ret();                                /* ret */
        }
    }
}
