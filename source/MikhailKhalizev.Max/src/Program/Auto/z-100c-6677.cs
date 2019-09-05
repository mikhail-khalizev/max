using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_6677-a9a3a597")]
        public void Method_100c_6677()
        {
            ii(0x100c_6677, 5);  push(0x4c);                           /* push 0x4c */
            ii(0x100c_667c, 5);  call(Definitions.sys_check_available_stack_size, 0x9_f6d1);/* call 0x10165d52 */
            ii(0x100c_6681, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_6682, 1);  push(esi);                            /* push esi */
            ii(0x100c_6683, 1);  push(edi);                            /* push edi */
            ii(0x100c_6684, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_6685, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_6687, 6);  sub(esp, 0x34);                       /* sub esp, 0x34 */
            ii(0x100c_668d, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_6690, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100c_6693, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100c_6696, 4);  or(memb[ss, ebp - 16], 1);            /* or byte [ebp-0x10], 0x1 */
            ii(0x100c_669a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_669d, 5);  call(0x100c_9fb4, 0x3912);            /* call 0x100c9fb4 */
            ii(0x100c_66a2, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_66a5, 4);  and(memb[ss, ebp - 16], -2 /* 0xfe */);/* and byte [ebp-0x10], 0xfe */
            ii(0x100c_66a9, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_66ac, 3);  mov(eax, memd[ds, eax + 121]);        /* mov eax, [eax+0x79] */
            ii(0x100c_66af, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_66b2, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_66b4, 2);  if(jge(0x100c_6701, 0x4b)) goto l_0x100c_6701;/* jge 0x100c6701 */
            ii(0x100c_66b6, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100c_66bd, 2);  jmp(0x100c_66c5, 6); goto l_0x100c_66c5;/* jmp 0x100c66c5 */
        l_0x100c_66bf:
            ii(0x100c_66bf, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_66c2, 3);  inc(memd[ss, ebp - 28]);              /* inc dword [ebp-0x1c] */
        l_0x100c_66c5:
            ii(0x100c_66c5, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_66c9, 3);  cmp(eax, 4);                          /* cmp eax, 0x4 */
            ii(0x100c_66cc, 2);  if(jge(0x100c_6701, 0x33)) goto l_0x100c_6701;/* jge 0x100c6701 */
            ii(0x100c_66ce, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_66d1, 3);  mov(eax, memd[ds, eax + 121]);        /* mov eax, [eax+0x79] */
            ii(0x100c_66d4, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_66d7, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_66d9, 2);  if(jl(0x100c_66f5, 0x1a)) goto l_0x100c_66f5;/* jl 0x100c66f5 */
            ii(0x100c_66db, 4);  movsx(eax, memw[ss, ebp - 28]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_66df, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100c_66e5, 6);  mov(al, memb[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100c_66eb, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100c_66f0, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100c_66f3, 2);  if(jz(0x100c_66ff, 0xa)) goto l_0x100c_66ff;/* jz 0x100c66ff */
        l_0x100c_66f5:
            ii(0x100c_66f5, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_66f8, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x100c_66fb, 4);  mov(memw[ds, edx + 123], ax);         /* mov [edx+0x7b], ax */
        l_0x100c_66ff:
            ii(0x100c_66ff, 2);  jmp(0x100c_66bf, -0x42); goto l_0x100c_66bf;/* jmp 0x100c66bf */
        l_0x100c_6701:
            ii(0x100c_6701, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_6704, 3);  mov(eax, memd[ds, eax + 121]);        /* mov eax, [eax+0x79] */
            ii(0x100c_6707, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_670a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_670c, 6);  if(jl(0x100c_693c, 0x22a)) goto l_0x100c_693c;/* jl 0x100c693c */
            ii(0x100c_6712, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_6716, 6);  if(jz(0x100c_67d6, 0xba)) goto l_0x100c_67d6;/* jz 0x100c67d6 */
            ii(0x100c_671c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_671f, 3);  mov(al, memb[ds, eax + 2]);           /* mov al, [eax+0x2] */
            ii(0x100c_6722, 3);  mov(memb[ss, ebp - 32], al);          /* mov [ebp-0x20], al */
            ii(0x100c_6725, 5);  jmp(0x100c_67b4, 0x8a); goto l_0x100c_67b4;/* jmp 0x100c67b4 */
        l_0x100c_672a:
            ii(0x100c_672a, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100c_672c, 1);  push(eax);                            /* push eax */
            ii(0x100c_672d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_6730, 3);  mov(ecx, memd[ds, eax + 121]);        /* mov ecx, [eax+0x79] */
            ii(0x100c_6733, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100c_6736, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_6739, 3);  movsx(ebx, memw[ds, eax]);            /* movsx ebx, word [eax] */
            ii(0x100c_673c, 5);  mov(edx, 0x3a);                       /* mov edx, 0x3a */
            ii(0x100c_6741, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6744, 5);  call(0x100c_6542, -0x207);            /* call 0x100c6542 */
            ii(0x100c_6749, 5);  jmp(0x100c_67d1, 0x83); goto l_0x100c_67d1;/* jmp 0x100c67d1 */
        l_0x100c_674e:
            ii(0x100c_674e, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100c_6753, 1);  push(eax);                            /* push eax */
            ii(0x100c_6754, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_6757, 3);  mov(ecx, memd[ds, eax + 121]);        /* mov ecx, [eax+0x79] */
            ii(0x100c_675a, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100c_675d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_6760, 3);  movsx(ebx, memw[ds, eax]);            /* movsx ebx, word [eax] */
            ii(0x100c_6763, 5);  mov(edx, 0x4f);                       /* mov edx, 0x4f */
            ii(0x100c_6768, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_676b, 5);  call(0x100c_6542, -0x22e);            /* call 0x100c6542 */
            ii(0x100c_6770, 2);  jmp(0x100c_67d1, 0x5f); goto l_0x100c_67d1;/* jmp 0x100c67d1 */
        l_0x100c_6772:
            ii(0x100c_6772, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100c_6777, 1);  push(eax);                            /* push eax */
            ii(0x100c_6778, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_677b, 3);  mov(ecx, memd[ds, eax + 121]);        /* mov ecx, [eax+0x79] */
            ii(0x100c_677e, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100c_6781, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_6784, 3);  movsx(ebx, memw[ds, eax]);            /* movsx ebx, word [eax] */
            ii(0x100c_6787, 5);  mov(edx, 0x44);                       /* mov edx, 0x44 */
            ii(0x100c_678c, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_678f, 5);  call(0x100c_6542, -0x252);            /* call 0x100c6542 */
            ii(0x100c_6794, 2);  jmp(0x100c_67d1, 0x3b); goto l_0x100c_67d1;/* jmp 0x100c67d1 */
        l_0x100c_6796:
            ii(0x100c_6796, 2);  jmp(0x100c_67d1, 0x39); goto l_0x100c_67d1;/* jmp 0x100c67d1 */
        //  ii(0x100c_6798, 28);  /* Служебная область с абсолютными адресами переходов. (0x100c_672a, 0x100c_674e, 0x100c_6772, 0x100c_6796, 0x100c_6796, 0x100c_6796, 0x100c_672a). */
        l_0x100c_67b4:
            ii(0x100c_67b4, 3);  mov(al, memb[ss, ebp - 32]);          /* mov al, [ebp-0x20] */
            ii(0x100c_67b7, 2);  sub(al, 2);                           /* sub al, 0x2 */
            ii(0x100c_67b9, 3);  mov(memb[ss, ebp - 36], al);          /* mov [ebp-0x24], al */
            ii(0x100c_67bc, 4);  cmp(memb[ss, ebp - 36], 6);           /* cmp byte [ebp-0x24], 0x6 */
            ii(0x100c_67c0, 2);  if(ja(0x100c_6796, -0x2c)) goto l_0x100c_6796;/* ja 0x100c6796 */
            ii(0x100c_67c2, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100c_67c4, 3);  mov(al, memb[ss, ebp - 36]);          /* mov al, [ebp-0x24] */
            ii(0x100c_67c7, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100c_67ca, 7);  /* jmp dword [cs:eax+0x100c6798] */
            switch (jmp_abs_switch(memd[cs, eax + 0x100c_6798]))
            {
                case 0x100c_672a:
                    goto l_0x100c_672a;
                case 0x100c_674e:
                    goto l_0x100c_674e;
                case 0x100c_6772:
                    goto l_0x100c_6772;
                case 0x100c_6796:
                    goto l_0x100c_6796;
                default:
                    throw new NotImplementedException();
            }
        l_0x100c_67d1:
            ii(0x100c_67d1, 5);  jmp(0x100c_693c, 0x166); goto l_0x100c_693c;/* jmp 0x100c693c */
        l_0x100c_67d6:
            ii(0x100c_67d6, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100c_67db, 1);  push(eax);                            /* push eax */
            ii(0x100c_67dc, 3);  mov(ecx, memd[ss, ebp - 12]);         /* mov ecx, [ebp-0xc] */
            ii(0x100c_67df, 3);  mov(ecx, memd[ds, ecx + 121]);        /* mov ecx, [ecx+0x79] */
            ii(0x100c_67e2, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100c_67e5, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x100c_67e8, 3);  movsx(ebx, memw[ds, ebx]);            /* movsx ebx, word [ebx] */
            ii(0x100c_67eb, 5);  mov(edx, 0x3a);                       /* mov edx, 0x3a */
            ii(0x100c_67f0, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_67f3, 5);  call(0x100c_6542, -0x2b6);            /* call 0x100c6542 */
            ii(0x100c_67f8, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100c_67fd, 1);  push(eax);                            /* push eax */
            ii(0x100c_67fe, 3);  mov(ecx, memd[ss, ebp - 12]);         /* mov ecx, [ebp-0xc] */
            ii(0x100c_6801, 3);  mov(ecx, memd[ds, ecx + 121]);        /* mov ecx, [ecx+0x79] */
            ii(0x100c_6804, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100c_6807, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x100c_680a, 3);  movsx(ebx, memw[ds, ebx]);            /* movsx ebx, word [ebx] */
            ii(0x100c_680d, 5);  mov(edx, 0x4f);                       /* mov edx, 0x4f */
            ii(0x100c_6812, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6815, 5);  call(0x100c_6542, -0x2d8);            /* call 0x100c6542 */
            ii(0x100c_681a, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100c_681f, 1);  push(eax);                            /* push eax */
            ii(0x100c_6820, 3);  mov(ecx, memd[ss, ebp - 12]);         /* mov ecx, [ebp-0xc] */
            ii(0x100c_6823, 3);  mov(ecx, memd[ds, ecx + 121]);        /* mov ecx, [ecx+0x79] */
            ii(0x100c_6826, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100c_6829, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x100c_682c, 3);  movsx(ebx, memw[ds, ebx]);            /* movsx ebx, word [ebx] */
            ii(0x100c_682f, 5);  mov(edx, 0x44);                       /* mov edx, 0x44 */
            ii(0x100c_6834, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6837, 5);  call(0x100c_6542, -0x2fa);            /* call 0x100c6542 */
            ii(0x100c_683c, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100c_6841, 1);  push(eax);                            /* push eax */
            ii(0x100c_6842, 3);  mov(ecx, memd[ss, ebp - 12]);         /* mov ecx, [ebp-0xc] */
            ii(0x100c_6845, 3);  mov(ecx, memd[ds, ecx + 121]);        /* mov ecx, [ecx+0x79] */
            ii(0x100c_6848, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100c_684b, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x100c_684e, 3);  movsx(ebx, memw[ds, ebx]);            /* movsx ebx, word [ebx] */
            ii(0x100c_6851, 5);  mov(edx, 0x32);                       /* mov edx, 0x32 */
            ii(0x100c_6856, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6859, 5);  call(0x100c_6542, -0x31c);            /* call 0x100c6542 */
            ii(0x100c_685e, 5);  mov(edx, 0x43);                       /* mov edx, 0x43 */
            ii(0x100c_6863, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_6866, 3);  mov(eax, memd[ds, eax + 121]);        /* mov eax, [eax+0x79] */
            ii(0x100c_6869, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_686c, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100c_6872, 5);  mov(ebx, 0x101c_a468);                /* mov ebx, 0x101ca468 */
            ii(0x100c_6877, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x100c_6879, 5);  call(0x100d_fd2c, 0x1_94ae);          /* call 0x100dfd2c */
            ii(0x100c_687e, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100c_6880, 5);  mov(edx, 0x42);                       /* mov edx, 0x42 */
            ii(0x100c_6885, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_6888, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100c_688b, 6);  imul(ecx, eax, 0x247);                /* imul ecx, eax, 0x247 */
            ii(0x100c_6891, 5);  mov(eax, 0x101c_a468);                /* mov eax, 0x101ca468 */
            ii(0x100c_6896, 2);  add(eax, ecx);                        /* add eax, ecx */
            ii(0x100c_6898, 5);  call(0x100d_fd2c, 0x1_948f);          /* call 0x100dfd2c */
            ii(0x100c_689d, 4);  mov(dx, memw[ds, ebx + 23]);          /* mov dx, [ebx+0x17] */
            ii(0x100c_68a1, 4);  cmp(dx, memw[ds, eax + 23]);          /* cmp dx, [eax+0x17] */
            ii(0x100c_68a5, 2);  if(jl(0x100c_68b9, 0x12)) goto l_0x100c_68b9;/* jl 0x100c68b9 */
            ii(0x100c_68a7, 5);  mov(ebx, 7);                          /* mov ebx, 0x7 */
            ii(0x100c_68ac, 5);  mov(edx, 0x42);                       /* mov edx, 0x42 */
            ii(0x100c_68b1, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_68b4, 5);  call(0x100c_64f5, -0x3c4);            /* call 0x100c64f5 */
        l_0x100c_68b9:
            ii(0x100c_68b9, 5);  mov(edx, 0x45);                       /* mov edx, 0x45 */
            ii(0x100c_68be, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_68c1, 3);  mov(eax, memd[ds, eax + 121]);        /* mov eax, [eax+0x79] */
            ii(0x100c_68c4, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_68c7, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100c_68cd, 5);  mov(ebx, 0x101c_a468);                /* mov ebx, 0x101ca468 */
            ii(0x100c_68d2, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x100c_68d4, 5);  call(0x100d_fd2c, 0x1_9453);          /* call 0x100dfd2c */
            ii(0x100c_68d9, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100c_68db, 5);  mov(edx, 0x47);                       /* mov edx, 0x47 */
            ii(0x100c_68e0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_68e3, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100c_68e6, 6);  imul(eax, eax, 0x247);                /* imul eax, eax, 0x247 */
            ii(0x100c_68ec, 5);  mov(ecx, 0x101c_a468);                /* mov ecx, 0x101ca468 */
            ii(0x100c_68f1, 2);  add(eax, ecx);                        /* add eax, ecx */
            ii(0x100c_68f3, 5);  call(0x100d_fd2c, 0x1_9434);          /* call 0x100dfd2c */
            ii(0x100c_68f8, 4);  mov(dx, memw[ds, ebx + 23]);          /* mov dx, [ebx+0x17] */
            ii(0x100c_68fc, 4);  cmp(dx, memw[ds, eax + 23]);          /* cmp dx, [eax+0x17] */
            ii(0x100c_6900, 2);  if(jl(0x100c_6914, 0x12)) goto l_0x100c_6914;/* jl 0x100c6914 */
            ii(0x100c_6902, 5);  mov(ebx, 7);                          /* mov ebx, 0x7 */
            ii(0x100c_6907, 5);  mov(edx, 0x47);                       /* mov edx, 0x47 */
            ii(0x100c_690c, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_690f, 5);  call(0x100c_64f5, -0x41f);            /* call 0x100c64f5 */
        l_0x100c_6914:
            ii(0x100c_6914, 5);  call(0x100c_aef4, 0x45db);            /* call 0x100caef4 */
            ii(0x100c_6919, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100c_691b, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100c_691d, 3);  lea(edx, memd[ss, ebp - 20]);         /* lea edx, [ebp-0x14] */
            ii(0x100c_6920, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x100c_6923, 5);  call(0x100c_ae64, 0x453c);            /* call 0x100cae64 */
            ii(0x100c_6928, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_692a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_692d, 5);  call(0x100c_7177, 0x845);             /* call 0x100c7177 */
            ii(0x100c_6932, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_6934, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x100c_6937, 5);  call(0x100c_a6a0, 0x3d64);            /* call 0x100ca6a0 */
        l_0x100c_693c:
            ii(0x100c_693c, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_693f, 5);  call(0x100c_ae28, 0x44e4);            /* call 0x100cae28 */
            ii(0x100c_6944, 1);  cwde();                               /* cwde */
            ii(0x100c_6945, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_6947, 6);  if(jnz(0x100c_7115, 0x7c8)) goto l_0x100c_7115;/* jnz 0x100c7115 */
            ii(0x100c_694d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_6950, 3);  mov(al, memb[ds, eax + 2]);           /* mov al, [eax+0x2] */
            ii(0x100c_6953, 3);  mov(memb[ss, ebp - 44], al);          /* mov [ebp-0x2c], al */
            ii(0x100c_6956, 5);  jmp(0x100c_70f8, 0x79d); goto l_0x100c_70f8;/* jmp 0x100c70f8 */
        l_0x100c_695b:
            ii(0x100c_695b, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100c_6960, 5);  mov(edx, 0x25);                       /* mov edx, 0x25 */
            ii(0x100c_6965, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6968, 5);  call(0x100c_64f5, -0x478);            /* call 0x100c64f5 */
            ii(0x100c_696d, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6972, 5);  mov(edx, 0x25);                       /* mov edx, 0x25 */
            ii(0x100c_6977, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_697a, 5);  call(0x100c_64f5, -0x48a);            /* call 0x100c64f5 */
            ii(0x100c_697f, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_6983, 6);  if(jnz(0x100c_6a2b, 0xa2)) goto l_0x100c_6a2b;/* jnz 0x100c6a2b */
            ii(0x100c_6989, 5);  mov(ebx, 7);                          /* mov ebx, 0x7 */
            ii(0x100c_698e, 5);  mov(edx, 5);                          /* mov edx, 0x5 */
            ii(0x100c_6993, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6996, 5);  call(0x100c_64f5, -0x4a6);            /* call 0x100c64f5 */
            ii(0x100c_699b, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_69a0, 5);  mov(edx, 0x22);                       /* mov edx, 0x22 */
            ii(0x100c_69a5, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_69a8, 5);  call(0x100c_64f5, -0x4b8);            /* call 0x100c64f5 */
            ii(0x100c_69ad, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x100c_69b2, 5);  mov(edx, 0x22);                       /* mov edx, 0x22 */
            ii(0x100c_69b7, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_69ba, 5);  call(0x100c_64f5, -0x4ca);            /* call 0x100c64f5 */
            ii(0x100c_69bf, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x100c_69c4, 5);  mov(edx, 0x22);                       /* mov edx, 0x22 */
            ii(0x100c_69c9, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_69cc, 5);  call(0x100c_64f5, -0x4dc);            /* call 0x100c64f5 */
            ii(0x100c_69d1, 5);  mov(ebx, 6);                          /* mov ebx, 0x6 */
            ii(0x100c_69d6, 5);  mov(edx, 0x22);                       /* mov edx, 0x22 */
            ii(0x100c_69db, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_69de, 5);  call(0x100c_64f5, -0x4ee);            /* call 0x100c64f5 */
            ii(0x100c_69e3, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100c_69e8, 5);  mov(edx, 0x22);                       /* mov edx, 0x22 */
            ii(0x100c_69ed, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_69f0, 5);  call(0x100c_64f5, -0x500);            /* call 0x100c64f5 */
            ii(0x100c_69f5, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x100c_69fa, 5);  mov(edx, 0x23);                       /* mov edx, 0x23 */
            ii(0x100c_69ff, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6a02, 5);  call(0x100c_64f5, -0x512);            /* call 0x100c64f5 */
            ii(0x100c_6a07, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100c_6a0c, 5);  mov(edx, 0x23);                       /* mov edx, 0x23 */
            ii(0x100c_6a11, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6a14, 5);  call(0x100c_64f5, -0x524);            /* call 0x100c64f5 */
            ii(0x100c_6a19, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6a1e, 5);  mov(edx, 0x23);                       /* mov edx, 0x23 */
            ii(0x100c_6a23, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6a26, 5);  call(0x100c_64f5, -0x536);            /* call 0x100c64f5 */
        l_0x100c_6a2b:
            ii(0x100c_6a2b, 5);  jmp(0x100c_7115, 0x6e5); goto l_0x100c_7115;/* jmp 0x100c7115 */
        l_0x100c_6a30:
            ii(0x100c_6a30, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100c_6a35, 5);  mov(edx, 0x36);                       /* mov edx, 0x36 */
            ii(0x100c_6a3a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6a3d, 5);  call(0x100c_64f5, -0x54d);            /* call 0x100c64f5 */
            ii(0x100c_6a42, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_6a46, 6);  if(jnz(0x100c_6aee, 0xa2)) goto l_0x100c_6aee;/* jnz 0x100c6aee */
            ii(0x100c_6a4c, 5);  mov(ebx, 7);                          /* mov ebx, 0x7 */
            ii(0x100c_6a51, 5);  mov(edx, 0x3a);                       /* mov edx, 0x3a */
            ii(0x100c_6a56, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6a59, 5);  call(0x100c_64f5, -0x569);            /* call 0x100c64f5 */
            ii(0x100c_6a5e, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6a63, 5);  mov(edx, 0x36);                       /* mov edx, 0x36 */
            ii(0x100c_6a68, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6a6b, 5);  call(0x100c_64f5, -0x57b);            /* call 0x100c64f5 */
            ii(0x100c_6a70, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x100c_6a75, 5);  mov(edx, 0x3a);                       /* mov edx, 0x3a */
            ii(0x100c_6a7a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6a7d, 5);  call(0x100c_64f5, -0x58d);            /* call 0x100c64f5 */
            ii(0x100c_6a82, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x100c_6a87, 5);  mov(edx, 0x36);                       /* mov edx, 0x36 */
            ii(0x100c_6a8c, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6a8f, 5);  call(0x100c_64f5, -0x59f);            /* call 0x100c64f5 */
            ii(0x100c_6a94, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100c_6a99, 5);  mov(edx, 0x49);                       /* mov edx, 0x49 */
            ii(0x100c_6a9e, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6aa1, 5);  call(0x100c_64f5, -0x5b1);            /* call 0x100c64f5 */
            ii(0x100c_6aa6, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6aab, 5);  mov(edx, 0x49);                       /* mov edx, 0x49 */
            ii(0x100c_6ab0, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6ab3, 5);  call(0x100c_64f5, -0x5c3);            /* call 0x100c64f5 */
            ii(0x100c_6ab8, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x100c_6abd, 5);  mov(edx, 0x49);                       /* mov edx, 0x49 */
            ii(0x100c_6ac2, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6ac5, 5);  call(0x100c_64f5, -0x5d5);            /* call 0x100c64f5 */
            ii(0x100c_6aca, 5);  mov(ebx, 7);                          /* mov ebx, 0x7 */
            ii(0x100c_6acf, 5);  mov(edx, 0x44);                       /* mov edx, 0x44 */
            ii(0x100c_6ad4, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6ad7, 5);  call(0x100c_64f5, -0x5e7);            /* call 0x100c64f5 */
            ii(0x100c_6adc, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x100c_6ae1, 5);  mov(edx, 0x44);                       /* mov edx, 0x44 */
            ii(0x100c_6ae6, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6ae9, 5);  call(0x100c_64f5, -0x5f9);            /* call 0x100c64f5 */
        l_0x100c_6aee:
            ii(0x100c_6aee, 5);  jmp(0x100c_7115, 0x622); goto l_0x100c_7115;/* jmp 0x100c7115 */
        l_0x100c_6af3:
            ii(0x100c_6af3, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6af8, 5);  mov(edx, 0x4c);                       /* mov edx, 0x4c */
            ii(0x100c_6afd, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6b00, 5);  call(0x100c_64f5, -0x610);            /* call 0x100c64f5 */
            ii(0x100c_6b05, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100c_6b0a, 5);  mov(edx, 0x4c);                       /* mov edx, 0x4c */
            ii(0x100c_6b0f, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6b12, 5);  call(0x100c_64f5, -0x622);            /* call 0x100c64f5 */
            ii(0x100c_6b17, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6b1c, 5);  mov(edx, 0x4d);                       /* mov edx, 0x4d */
            ii(0x100c_6b21, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6b24, 5);  call(0x100c_64f5, -0x634);            /* call 0x100c64f5 */
            ii(0x100c_6b29, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_6b2d, 6);  if(jnz(0x100c_6bb1, 0x7e)) goto l_0x100c_6bb1;/* jnz 0x100c6bb1 */
            ii(0x100c_6b33, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x100c_6b38, 5);  mov(edx, 0x4c);                       /* mov edx, 0x4c */
            ii(0x100c_6b3d, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6b40, 5);  call(0x100c_64f5, -0x650);            /* call 0x100c64f5 */
            ii(0x100c_6b45, 5);  mov(ebx, 6);                          /* mov ebx, 0x6 */
            ii(0x100c_6b4a, 5);  mov(edx, 0x4c);                       /* mov edx, 0x4c */
            ii(0x100c_6b4f, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6b52, 5);  call(0x100c_64f5, -0x662);            /* call 0x100c64f5 */
            ii(0x100c_6b57, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x100c_6b5c, 5);  mov(edx, 0x4c);                       /* mov edx, 0x4c */
            ii(0x100c_6b61, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6b64, 5);  call(0x100c_64f5, -0x674);            /* call 0x100c64f5 */
            ii(0x100c_6b69, 5);  mov(ebx, 7);                          /* mov ebx, 0x7 */
            ii(0x100c_6b6e, 5);  mov(edx, 0x4f);                       /* mov edx, 0x4f */
            ii(0x100c_6b73, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6b76, 5);  call(0x100c_64f5, -0x686);            /* call 0x100c64f5 */
            ii(0x100c_6b7b, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x100c_6b80, 5);  mov(edx, 0x4d);                       /* mov edx, 0x4d */
            ii(0x100c_6b85, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6b88, 5);  call(0x100c_64f5, -0x698);            /* call 0x100c64f5 */
            ii(0x100c_6b8d, 5);  mov(ebx, 6);                          /* mov ebx, 0x6 */
            ii(0x100c_6b92, 5);  mov(edx, 0x4d);                       /* mov edx, 0x4d */
            ii(0x100c_6b97, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6b9a, 5);  call(0x100c_64f5, -0x6aa);            /* call 0x100c64f5 */
            ii(0x100c_6b9f, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x100c_6ba4, 5);  mov(edx, 0x4d);                       /* mov edx, 0x4d */
            ii(0x100c_6ba9, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6bac, 5);  call(0x100c_64f5, -0x6bc);            /* call 0x100c64f5 */
        l_0x100c_6bb1:
            ii(0x100c_6bb1, 5);  jmp(0x100c_7115, 0x55f); goto l_0x100c_7115;/* jmp 0x100c7115 */
        l_0x100c_6bb6:
            ii(0x100c_6bb6, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6bbb, 5);  mov(edx, 0x46);                       /* mov edx, 0x46 */
            ii(0x100c_6bc0, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6bc3, 5);  call(0x100c_64f5, -0x6d3);            /* call 0x100c64f5 */
            ii(0x100c_6bc8, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x100c_6bcd, 5);  mov(edx, 0x46);                       /* mov edx, 0x46 */
            ii(0x100c_6bd2, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6bd5, 5);  call(0x100c_64f5, -0x6e5);            /* call 0x100c64f5 */
            ii(0x100c_6bda, 5);  mov(ebx, 6);                          /* mov ebx, 0x6 */
            ii(0x100c_6bdf, 5);  mov(edx, 0x46);                       /* mov edx, 0x46 */
            ii(0x100c_6be4, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6be7, 5);  call(0x100c_64f5, -0x6f7);            /* call 0x100c64f5 */
            ii(0x100c_6bec, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100c_6bf1, 5);  mov(edx, 0x49);                       /* mov edx, 0x49 */
            ii(0x100c_6bf6, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6bf9, 5);  call(0x100c_64f5, -0x709);            /* call 0x100c64f5 */
            ii(0x100c_6bfe, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_6c02, 6);  if(jnz(0x100c_6cf2, 0xea)) goto l_0x100c_6cf2;/* jnz 0x100c6cf2 */
            ii(0x100c_6c08, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6c0d, 5);  mov(edx, 0x47);                       /* mov edx, 0x47 */
            ii(0x100c_6c12, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6c15, 5);  call(0x100c_64f5, -0x725);            /* call 0x100c64f5 */
            ii(0x100c_6c1a, 5);  mov(ebx, 7);                          /* mov ebx, 0x7 */
            ii(0x100c_6c1f, 5);  mov(edx, 0x47);                       /* mov edx, 0x47 */
            ii(0x100c_6c24, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6c27, 5);  call(0x100c_64f5, -0x737);            /* call 0x100c64f5 */
            ii(0x100c_6c2c, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x100c_6c31, 5);  mov(edx, 0x46);                       /* mov edx, 0x46 */
            ii(0x100c_6c36, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6c39, 5);  call(0x100c_64f5, -0x749);            /* call 0x100c64f5 */
            ii(0x100c_6c3e, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6c43, 5);  mov(edx, 0x49);                       /* mov edx, 0x49 */
            ii(0x100c_6c48, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6c4b, 5);  call(0x100c_64f5, -0x75b);            /* call 0x100c64f5 */
            ii(0x100c_6c50, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6c55, 5);  mov(edx, 0x44);                       /* mov edx, 0x44 */
            ii(0x100c_6c5a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6c5d, 5);  call(0x100c_64f5, -0x76d);            /* call 0x100c64f5 */
            ii(0x100c_6c62, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x100c_6c67, 5);  mov(edx, 0x44);                       /* mov edx, 0x44 */
            ii(0x100c_6c6c, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6c6f, 5);  call(0x100c_64f5, -0x77f);            /* call 0x100c64f5 */
            ii(0x100c_6c74, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100c_6c79, 5);  mov(edx, 0x44);                       /* mov edx, 0x44 */
            ii(0x100c_6c7e, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6c81, 5);  call(0x100c_64f5, -0x791);            /* call 0x100c64f5 */
            ii(0x100c_6c86, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x100c_6c8b, 5);  mov(edx, 0x44);                       /* mov edx, 0x44 */
            ii(0x100c_6c90, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6c93, 5);  call(0x100c_64f5, -0x7a3);            /* call 0x100c64f5 */
            ii(0x100c_6c98, 5);  mov(ebx, 7);                          /* mov ebx, 0x7 */
            ii(0x100c_6c9d, 5);  mov(edx, 0x44);                       /* mov edx, 0x44 */
            ii(0x100c_6ca2, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6ca5, 5);  call(0x100c_64f5, -0x7b5);            /* call 0x100c64f5 */
            ii(0x100c_6caa, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6caf, 5);  mov(edx, 0x45);                       /* mov edx, 0x45 */
            ii(0x100c_6cb4, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6cb7, 5);  call(0x100c_64f5, -0x7c7);            /* call 0x100c64f5 */
            ii(0x100c_6cbc, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x100c_6cc1, 5);  mov(edx, 0x45);                       /* mov edx, 0x45 */
            ii(0x100c_6cc6, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6cc9, 5);  call(0x100c_64f5, -0x7d9);            /* call 0x100c64f5 */
            ii(0x100c_6cce, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x100c_6cd3, 5);  mov(edx, 0x45);                       /* mov edx, 0x45 */
            ii(0x100c_6cd8, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6cdb, 5);  call(0x100c_64f5, -0x7eb);            /* call 0x100c64f5 */
            ii(0x100c_6ce0, 5);  mov(ebx, 7);                          /* mov ebx, 0x7 */
            ii(0x100c_6ce5, 5);  mov(edx, 0x45);                       /* mov edx, 0x45 */
            ii(0x100c_6cea, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6ced, 5);  call(0x100c_64f5, -0x7fd);            /* call 0x100c64f5 */
        l_0x100c_6cf2:
            ii(0x100c_6cf2, 5);  jmp(0x100c_7115, 0x41e); goto l_0x100c_7115;/* jmp 0x100c7115 */
        l_0x100c_6cf7:
            ii(0x100c_6cf7, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6cfc, 5);  mov(edx, 0x32);                       /* mov edx, 0x32 */
            ii(0x100c_6d01, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6d04, 5);  call(0x100c_64f5, -0x814);            /* call 0x100c64f5 */
            ii(0x100c_6d09, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x100c_6d0e, 5);  mov(edx, 0x32);                       /* mov edx, 0x32 */
            ii(0x100c_6d13, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6d16, 5);  call(0x100c_64f5, -0x826);            /* call 0x100c64f5 */
            ii(0x100c_6d1b, 5);  mov(ebx, 6);                          /* mov ebx, 0x6 */
            ii(0x100c_6d20, 5);  mov(edx, 0x32);                       /* mov edx, 0x32 */
            ii(0x100c_6d25, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6d28, 5);  call(0x100c_64f5, -0x838);            /* call 0x100c64f5 */
            ii(0x100c_6d2d, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x100c_6d32, 5);  mov(edx, 0x32);                       /* mov edx, 0x32 */
            ii(0x100c_6d37, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6d3a, 5);  call(0x100c_64f5, -0x84a);            /* call 0x100c64f5 */
            ii(0x100c_6d3f, 5);  jmp(0x100c_7115, 0x3d1); goto l_0x100c_7115;/* jmp 0x100c7115 */
        l_0x100c_6d44:
            ii(0x100c_6d44, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x100c_6d49, 5);  mov(edx, 0x32);                       /* mov edx, 0x32 */
            ii(0x100c_6d4e, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6d51, 5);  call(0x100c_64f5, -0x861);            /* call 0x100c64f5 */
            ii(0x100c_6d56, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6d5b, 5);  mov(edx, 0x33);                       /* mov edx, 0x33 */
            ii(0x100c_6d60, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6d63, 5);  call(0x100c_64f5, -0x873);            /* call 0x100c64f5 */
            ii(0x100c_6d68, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x100c_6d6d, 5);  mov(edx, 0x33);                       /* mov edx, 0x33 */
            ii(0x100c_6d72, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6d75, 5);  call(0x100c_64f5, -0x885);            /* call 0x100c64f5 */
            ii(0x100c_6d7a, 5);  mov(ebx, 6);                          /* mov ebx, 0x6 */
            ii(0x100c_6d7f, 5);  mov(edx, 0x33);                       /* mov edx, 0x33 */
            ii(0x100c_6d84, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6d87, 5);  call(0x100c_64f5, -0x897);            /* call 0x100c64f5 */
            ii(0x100c_6d8c, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x100c_6d91, 5);  mov(edx, 0x33);                       /* mov edx, 0x33 */
            ii(0x100c_6d96, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6d99, 5);  call(0x100c_64f5, -0x8a9);            /* call 0x100c64f5 */
            ii(0x100c_6d9e, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x100c_6da3, 5);  mov(edx, 0x33);                       /* mov edx, 0x33 */
            ii(0x100c_6da8, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6dab, 5);  call(0x100c_64f5, -0x8bb);            /* call 0x100c64f5 */
            ii(0x100c_6db0, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_6db4, 2);  if(jnz(0x100c_6dc8, 0x12)) goto l_0x100c_6dc8;/* jnz 0x100c6dc8 */
            ii(0x100c_6db6, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100c_6dbb, 5);  mov(edx, 0x33);                       /* mov edx, 0x33 */
            ii(0x100c_6dc0, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6dc3, 5);  call(0x100c_64f5, -0x8d3);            /* call 0x100c64f5 */
        l_0x100c_6dc8:
            ii(0x100c_6dc8, 5);  jmp(0x100c_7115, 0x348); goto l_0x100c_7115;/* jmp 0x100c7115 */
        l_0x100c_6dcd:
            ii(0x100c_6dcd, 5);  mov(ebx, 7);                          /* mov ebx, 0x7 */
            ii(0x100c_6dd2, 5);  mov(edx, 0x32);                       /* mov edx, 0x32 */
            ii(0x100c_6dd7, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6dda, 5);  call(0x100c_64f5, -0x8ea);            /* call 0x100c64f5 */
            ii(0x100c_6ddf, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6de4, 5);  mov(edx, 0x34);                       /* mov edx, 0x34 */
            ii(0x100c_6de9, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6dec, 5);  call(0x100c_64f5, -0x8fc);            /* call 0x100c64f5 */
            ii(0x100c_6df1, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x100c_6df6, 5);  mov(edx, 0x34);                       /* mov edx, 0x34 */
            ii(0x100c_6dfb, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6dfe, 5);  call(0x100c_64f5, -0x90e);            /* call 0x100c64f5 */
            ii(0x100c_6e03, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100c_6e08, 5);  mov(edx, 0x34);                       /* mov edx, 0x34 */
            ii(0x100c_6e0d, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6e10, 5);  call(0x100c_64f5, -0x920);            /* call 0x100c64f5 */
            ii(0x100c_6e15, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_6e19, 6);  if(jnz(0x100c_6f63, 0x144)) goto l_0x100c_6f63;/* jnz 0x100c6f63 */
            ii(0x100c_6e1f, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x100c_6e24, 5);  mov(edx, 0x34);                       /* mov edx, 0x34 */
            ii(0x100c_6e29, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6e2c, 5);  call(0x100c_64f5, -0x93c);            /* call 0x100c64f5 */
            ii(0x100c_6e31, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6e36, 5);  mov(edx, 0x32);                       /* mov edx, 0x32 */
            ii(0x100c_6e3b, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6e3e, 5);  call(0x100c_64f5, -0x94e);            /* call 0x100c64f5 */
            ii(0x100c_6e43, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x100c_6e48, 5);  mov(edx, 0x32);                       /* mov edx, 0x32 */
            ii(0x100c_6e4d, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6e50, 5);  call(0x100c_64f5, -0x960);            /* call 0x100c64f5 */
            ii(0x100c_6e55, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6e5a, 5);  mov(edx, 0x37);                       /* mov edx, 0x37 */
            ii(0x100c_6e5f, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6e62, 5);  call(0x100c_64f5, -0x972);            /* call 0x100c64f5 */
            ii(0x100c_6e67, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x100c_6e6c, 5);  mov(edx, 0x37);                       /* mov edx, 0x37 */
            ii(0x100c_6e71, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6e74, 5);  call(0x100c_64f5, -0x984);            /* call 0x100c64f5 */
            ii(0x100c_6e79, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100c_6e7e, 5);  mov(edx, 0x37);                       /* mov edx, 0x37 */
            ii(0x100c_6e83, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6e86, 5);  call(0x100c_64f5, -0x996);            /* call 0x100c64f5 */
            ii(0x100c_6e8b, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x100c_6e90, 5);  mov(edx, 0x37);                       /* mov edx, 0x37 */
            ii(0x100c_6e95, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6e98, 5);  call(0x100c_64f5, -0x9a8);            /* call 0x100c64f5 */
            ii(0x100c_6e9d, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6ea2, 5);  mov(edx, 0x4d);                       /* mov edx, 0x4d */
            ii(0x100c_6ea7, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6eaa, 5);  call(0x100c_64f5, -0x9ba);            /* call 0x100c64f5 */
            ii(0x100c_6eaf, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6eb4, 5);  mov(edx, 0x44);                       /* mov edx, 0x44 */
            ii(0x100c_6eb9, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6ebc, 5);  call(0x100c_64f5, -0x9cc);            /* call 0x100c64f5 */
            ii(0x100c_6ec1, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x100c_6ec6, 5);  mov(edx, 0x44);                       /* mov edx, 0x44 */
            ii(0x100c_6ecb, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6ece, 5);  call(0x100c_64f5, -0x9de);            /* call 0x100c64f5 */
            ii(0x100c_6ed3, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100c_6ed8, 5);  mov(edx, 0x44);                       /* mov edx, 0x44 */
            ii(0x100c_6edd, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6ee0, 5);  call(0x100c_64f5, -0x9f0);            /* call 0x100c64f5 */
            ii(0x100c_6ee5, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x100c_6eea, 5);  mov(edx, 0x44);                       /* mov edx, 0x44 */
            ii(0x100c_6eef, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6ef2, 5);  call(0x100c_64f5, -0xa02);            /* call 0x100c64f5 */
            ii(0x100c_6ef7, 5);  mov(ebx, 7);                          /* mov ebx, 0x7 */
            ii(0x100c_6efc, 5);  mov(edx, 0x44);                       /* mov edx, 0x44 */
            ii(0x100c_6f01, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6f04, 5);  call(0x100c_64f5, -0xa14);            /* call 0x100c64f5 */
            ii(0x100c_6f09, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100c_6f0e, 5);  mov(edx, 0x45);                       /* mov edx, 0x45 */
            ii(0x100c_6f13, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6f16, 5);  call(0x100c_64f5, -0xa26);            /* call 0x100c64f5 */
            ii(0x100c_6f1b, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x100c_6f20, 5);  mov(edx, 0x45);                       /* mov edx, 0x45 */
            ii(0x100c_6f25, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6f28, 5);  call(0x100c_64f5, -0xa38);            /* call 0x100c64f5 */
            ii(0x100c_6f2d, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6f32, 5);  mov(edx, 0x45);                       /* mov edx, 0x45 */
            ii(0x100c_6f37, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6f3a, 5);  call(0x100c_64f5, -0xa4a);            /* call 0x100c64f5 */
            ii(0x100c_6f3f, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x100c_6f44, 5);  mov(edx, 0x45);                       /* mov edx, 0x45 */
            ii(0x100c_6f49, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6f4c, 5);  call(0x100c_64f5, -0xa5c);            /* call 0x100c64f5 */
            ii(0x100c_6f51, 5);  mov(ebx, 7);                          /* mov ebx, 0x7 */
            ii(0x100c_6f56, 5);  mov(edx, 0x45);                       /* mov edx, 0x45 */
            ii(0x100c_6f5b, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6f5e, 5);  call(0x100c_64f5, -0xa6e);            /* call 0x100c64f5 */
        l_0x100c_6f63:
            ii(0x100c_6f63, 5);  jmp(0x100c_7115, 0x1ad); goto l_0x100c_7115;/* jmp 0x100c7115 */
        l_0x100c_6f68:
            ii(0x100c_6f68, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100c_6f6d, 5);  mov(edx, 0x36);                       /* mov edx, 0x36 */
            ii(0x100c_6f72, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6f75, 5);  call(0x100c_64f5, -0xa85);            /* call 0x100c64f5 */
            ii(0x100c_6f7a, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6f7f, 5);  mov(edx, 0x33);                       /* mov edx, 0x33 */
            ii(0x100c_6f84, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6f87, 5);  call(0x100c_64f5, -0xa97);            /* call 0x100c64f5 */
            ii(0x100c_6f8c, 5);  mov(ebx, 5);                          /* mov ebx, 0x5 */
            ii(0x100c_6f91, 5);  mov(edx, 0x33);                       /* mov edx, 0x33 */
            ii(0x100c_6f96, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6f99, 5);  call(0x100c_64f5, -0xaa9);            /* call 0x100c64f5 */
            ii(0x100c_6f9e, 5);  mov(ebx, 6);                          /* mov ebx, 0x6 */
            ii(0x100c_6fa3, 5);  mov(edx, 0x33);                       /* mov edx, 0x33 */
            ii(0x100c_6fa8, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6fab, 5);  call(0x100c_64f5, -0xabb);            /* call 0x100c64f5 */
            ii(0x100c_6fb0, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_6fb4, 2);  if(jnz(0x100c_7022, 0x6c)) goto l_0x100c_7022;/* jnz 0x100c7022 */
            ii(0x100c_6fb6, 5);  mov(ebx, 7);                          /* mov ebx, 0x7 */
            ii(0x100c_6fbb, 5);  mov(edx, 0x3a);                       /* mov edx, 0x3a */
            ii(0x100c_6fc0, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6fc3, 5);  call(0x100c_64f5, -0xad3);            /* call 0x100c64f5 */
            ii(0x100c_6fc8, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x100c_6fcd, 5);  mov(edx, 0x3a);                       /* mov edx, 0x3a */
            ii(0x100c_6fd2, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6fd5, 5);  call(0x100c_64f5, -0xae5);            /* call 0x100c64f5 */
            ii(0x100c_6fda, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_6fdf, 5);  mov(edx, 0x36);                       /* mov edx, 0x36 */
            ii(0x100c_6fe4, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6fe7, 5);  call(0x100c_64f5, -0xaf7);            /* call 0x100c64f5 */
            ii(0x100c_6fec, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x100c_6ff1, 5);  mov(edx, 0x36);                       /* mov edx, 0x36 */
            ii(0x100c_6ff6, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_6ff9, 5);  call(0x100c_64f5, -0xb09);            /* call 0x100c64f5 */
            ii(0x100c_6ffe, 5);  mov(ebx, 2);                          /* mov ebx, 0x2 */
            ii(0x100c_7003, 5);  mov(edx, 0x33);                       /* mov edx, 0x33 */
            ii(0x100c_7008, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_700b, 5);  call(0x100c_64f5, -0xb1b);            /* call 0x100c64f5 */
            ii(0x100c_7010, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x100c_7015, 5);  mov(edx, 0x33);                       /* mov edx, 0x33 */
            ii(0x100c_701a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_701d, 5);  call(0x100c_64f5, -0xb2d);            /* call 0x100c64f5 */
        l_0x100c_7022:
            ii(0x100c_7022, 5);  jmp(0x100c_7115, 0xee); goto l_0x100c_7115;/* jmp 0x100c7115 */
        l_0x100c_7027:
            ii(0x100c_7027, 5);  mov(ebx, 7);                          /* mov ebx, 0x7 */
            ii(0x100c_702c, 5);  mov(edx, 0x42);                       /* mov edx, 0x42 */
            ii(0x100c_7031, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_7034, 5);  call(0x100c_64f5, -0xb44);            /* call 0x100c64f5 */
            ii(0x100c_7039, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x100c_703e, 5);  mov(edx, 0x42);                       /* mov edx, 0x42 */
            ii(0x100c_7043, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_7046, 5);  call(0x100c_64f5, -0xb56);            /* call 0x100c64f5 */
            ii(0x100c_704b, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100c_7050, 5);  mov(edx, 0x36);                       /* mov edx, 0x36 */
            ii(0x100c_7055, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_7058, 5);  call(0x100c_64f5, -0xb68);            /* call 0x100c64f5 */
            ii(0x100c_705d, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_7061, 2);  if(jnz(0x100c_70cf, 0x6c)) goto l_0x100c_70cf;/* jnz 0x100c70cf */
            ii(0x100c_7063, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x100c_7068, 5);  mov(edx, 0x47);                       /* mov edx, 0x47 */
            ii(0x100c_706d, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_7070, 5);  call(0x100c_64f5, -0xb80);            /* call 0x100c64f5 */
            ii(0x100c_7075, 5);  mov(ebx, 7);                          /* mov ebx, 0x7 */
            ii(0x100c_707a, 5);  mov(edx, 0x47);                       /* mov edx, 0x47 */
            ii(0x100c_707f, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_7082, 5);  call(0x100c_64f5, -0xb92);            /* call 0x100c64f5 */
            ii(0x100c_7087, 5);  mov(ebx, 7);                          /* mov ebx, 0x7 */
            ii(0x100c_708c, 5);  mov(edx, 0x3a);                       /* mov edx, 0x3a */
            ii(0x100c_7091, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_7094, 5);  call(0x100c_64f5, -0xba4);            /* call 0x100c64f5 */
            ii(0x100c_7099, 5);  mov(ebx, 7);                          /* mov ebx, 0x7 */
            ii(0x100c_709e, 5);  mov(edx, 0x4f);                       /* mov edx, 0x4f */
            ii(0x100c_70a3, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_70a6, 5);  call(0x100c_64f5, -0xbb6);            /* call 0x100c64f5 */
            ii(0x100c_70ab, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100c_70b0, 5);  mov(edx, 0x49);                       /* mov edx, 0x49 */
            ii(0x100c_70b5, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_70b8, 5);  call(0x100c_64f5, -0xbc8);            /* call 0x100c64f5 */
            ii(0x100c_70bd, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x100c_70c2, 5);  mov(edx, 0x41);                       /* mov edx, 0x41 */
            ii(0x100c_70c7, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_70ca, 5);  call(0x100c_64f5, -0xbda);            /* call 0x100c64f5 */
        l_0x100c_70cf:
            ii(0x100c_70cf, 2);  jmp(0x100c_7115, 0x44); goto l_0x100c_7115;/* jmp 0x100c7115 */
        l_0x100c_70d1:
            ii(0x100c_70d1, 2);  jmp(0x100c_7115, 0x42); goto l_0x100c_7115;/* jmp 0x100c7115 */
        //  ii(0x100c_70d3, 1);  nop();                                /* nop */
        //  ii(0x100c_70d4, 36);  /* Служебная область с абсолютными адресами переходов. (0x100c_695b, 0x100c_6a30, 0x100c_6af3, 0x100c_6bb6, 0x100c_6cf7, 0x100c_6d44, 0x100c_6dcd, 0x100c_6f68, 0x100c_7027). */
        l_0x100c_70f8:
            ii(0x100c_70f8, 3);  mov(al, memb[ss, ebp - 44]);          /* mov al, [ebp-0x2c] */
            ii(0x100c_70fb, 2);  dec(al);                              /* dec al */
            ii(0x100c_70fd, 3);  mov(memb[ss, ebp - 48], al);          /* mov [ebp-0x30], al */
            ii(0x100c_7100, 4);  cmp(memb[ss, ebp - 48], 8);           /* cmp byte [ebp-0x30], 0x8 */
            ii(0x100c_7104, 2);  if(ja(0x100c_70d1, -0x35)) goto l_0x100c_70d1;/* ja 0x100c70d1 */
            ii(0x100c_7106, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100c_7108, 3);  mov(al, memb[ss, ebp - 48]);          /* mov al, [ebp-0x30] */
            ii(0x100c_710b, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100c_710e, 7);  /* jmp dword [cs:eax+0x100c70d4] */
            switch (jmp_abs_switch(memd[cs, eax + 0x100c_70d4]))
            {
                case 0x100c_695b:
                    goto l_0x100c_695b;
                case 0x100c_6a30:
                    goto l_0x100c_6a30;
                case 0x100c_6af3:
                    goto l_0x100c_6af3;
                case 0x100c_6bb6:
                    goto l_0x100c_6bb6;
                case 0x100c_6cf7:
                    goto l_0x100c_6cf7;
                case 0x100c_6d44:
                    goto l_0x100c_6d44;
                case 0x100c_6dcd:
                    goto l_0x100c_6dcd;
                case 0x100c_6f68:
                    goto l_0x100c_6f68;
                case 0x100c_7027:
                    goto l_0x100c_7027;
                default:
                    throw new NotImplementedException();
            }
        l_0x100c_7115:
            ii(0x100c_7115, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100c_7119, 2);  if(jnz(0x100c_7143, 0x28)) goto l_0x100c_7143;/* jnz 0x100c7143 */
            ii(0x100c_711b, 5);  call(0x100c_aef4, 0x3dd4);            /* call 0x100caef4 */
            ii(0x100c_7120, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100c_7122, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100c_7124, 3);  lea(edx, memd[ss, ebp - 20]);         /* lea edx, [ebp-0x14] */
            ii(0x100c_7127, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x100c_712a, 5);  call(0x100c_ae64, 0x3d35);            /* call 0x100cae64 */
            ii(0x100c_712f, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100c_7131, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_7134, 5);  call(0x100c_7177, 0x3e);              /* call 0x100c7177 */
            ii(0x100c_7139, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_713b, 3);  lea(eax, memd[ss, ebp - 52]);         /* lea eax, [ebp-0x34] */
            ii(0x100c_713e, 5);  call(0x100c_a6a0, 0x355d);            /* call 0x100ca6a0 */
        l_0x100c_7143:
            ii(0x100c_7143, 5);  call(0x100c_aef4, 0x3dac);            /* call 0x100caef4 */
            ii(0x100c_7148, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100c_714a, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100c_714c, 3);  lea(edx, memd[ss, ebp - 20]);         /* lea edx, [ebp-0x14] */
            ii(0x100c_714f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_7152, 5);  call(0x100c_ae64, 0x3d0d);            /* call 0x100cae64 */
            ii(0x100c_7157, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_7159, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100c_715c, 5);  call(0x100c_a6a0, 0x353f);            /* call 0x100ca6a0 */
            ii(0x100c_7161, 2);  jmp(0x100c_716d, 0xa); goto l_0x100c_716d;/* jmp 0x100c716d */
        //  ii(0x100c_7163, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x100c_7165, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
        //  ii(0x100c_7168, 5);  call(0x100c_a6a0, 0x3533);            /* call 0x100ca6a0 */
        l_0x100c_716d:
            ii(0x100c_716d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_7170, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_7172, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_7173, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_7174, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_7175, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_7176, 1);  ret();                                /* ret */
        }
    }
}
