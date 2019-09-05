using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_07ed-65279e80")]
        public void Method_1007_07ed()
        {
            ii(0x1007_07ed, 5);  push(0x4c);                           /* push 0x4c */
            ii(0x1007_07f2, 5);  call(Definitions.sys_check_available_stack_size, 0xf_555b);/* call 0x10165d52 */
            ii(0x1007_07f7, 1);  push(esi);                            /* push esi */
            ii(0x1007_07f8, 1);  push(edi);                            /* push edi */
            ii(0x1007_07f9, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_07fa, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_07fc, 6);  sub(esp, 0x38);                       /* sub esp, 0x38 */
            ii(0x1007_0802, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_0805, 3);  mov(memd[ss, ebp - 16], edx);         /* mov [ebp-0x10], edx */
            ii(0x1007_0808, 3);  mov(memd[ss, ebp - 12], ebx);         /* mov [ebp-0xc], ebx */
            ii(0x1007_080b, 3);  mov(memd[ss, ebp - 8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x1007_080e, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1007_0810, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_0813, 3);  mov(al, memb[ds, edx + 38]);          /* mov al, [edx+0x26] */
            ii(0x1007_0816, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1007_0819, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_081c, 5);  call(0x1007_623c, 0x5a1b);            /* call 0x1007623c */
            ii(0x1007_0821, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1007_0824, 3);  mov(eax, memd[ss, ebp + 24]);         /* mov eax, [ebp+0x18] */
            ii(0x1007_0827, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_082a, 2);  jmp(0x1007_0880, 0x54); goto l_0x1007_0880;/* jmp 0x10070880 */
        l_0x1007_082c:
            ii(0x1007_082c, 7);  mov(memd[ss, ebp - 24], 1);           /* mov dword [ebp-0x18], 0x1 */
            ii(0x1007_0833, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x1007_083a, 2);  jmp(0x1007_089d, 0x61); goto l_0x1007_089d;/* jmp 0x1007089d */
        l_0x1007_083c:
            ii(0x1007_083c, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1007_0843, 7);  mov(memd[ss, ebp - 32], 1);           /* mov dword [ebp-0x20], 0x1 */
            ii(0x1007_084a, 2);  jmp(0x1007_089d, 0x51); goto l_0x1007_089d;/* jmp 0x1007089d */
        l_0x1007_084c:
            ii(0x1007_084c, 7);  mov(memd[ss, ebp - 24], 0xffff_ffff); /* mov dword [ebp-0x18], 0xffffffff */
            ii(0x1007_0853, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x1007_085a, 2);  jmp(0x1007_089d, 0x41); goto l_0x1007_089d;/* jmp 0x1007089d */
        l_0x1007_085c:
            ii(0x1007_085c, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1007_0863, 7);  mov(memd[ss, ebp - 32], 0xffff_ffff); /* mov dword [ebp-0x20], 0xffffffff */
            ii(0x1007_086a, 2);  jmp(0x1007_089d, 0x31); goto l_0x1007_089d;/* jmp 0x1007089d */
        l_0x1007_086c:
            ii(0x1007_086c, 2);  jmp(0x1007_089d, 0x2f); goto l_0x1007_089d;/* jmp 0x1007089d */
        //  ii(0x1007_086e, 2);  mov(eax, eax);                        /* mov eax, eax */
        //  ii(0x1007_0870, 16);  /* Служебная область с абсолютными адресами переходов. (0x1007_082c, 0x1007_083c, 0x1007_084c, 0x1007_085c). */
        l_0x1007_0880:
            ii(0x1007_0880, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1007_0883, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1007_0886, 5);  cmp(memw[ss, ebp - 44], 3);           /* cmp word [ebp-0x2c], 0x3 */
            ii(0x1007_088b, 2);  if(ja(0x1007_086c, -0x21)) goto l_0x1007_086c;/* ja 0x1007086c */
            ii(0x1007_088d, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1007_088f, 4);  mov(ax, memw[ss, ebp - 44]);          /* mov ax, [ebp-0x2c] */
            ii(0x1007_0893, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1007_0896, 7);  /* jmp dword [cs:eax+0x10070870] */
            switch (jmp_abs_switch(memd[cs, eax + 0x1007_0870]))
            {
                case 0x1007_082c:
                    goto l_0x1007_082c;
                case 0x1007_083c:
                    goto l_0x1007_083c;
                case 0x1007_084c:
                    goto l_0x1007_084c;
                case 0x1007_085c:
                    goto l_0x1007_085c;
                default:
                    throw new NotImplementedException();
            }
        l_0x1007_089d:
            ii(0x1007_089d, 7);  mov(memd[ss, ebp - 36], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x1007_08a4, 2);  jmp(0x1007_08ac, 6); goto l_0x1007_08ac;/* jmp 0x100708ac */
        l_0x1007_08a6:
            ii(0x1007_08a6, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1007_08a9, 3);  inc(memd[ss, ebp - 36]);              /* inc dword [ebp-0x24] */
        l_0x1007_08ac:
            ii(0x1007_08ac, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1007_08af, 4);  cmp(ax, memw[ss, ebp + 16]);          /* cmp ax, [ebp+0x10] */
            ii(0x1007_08b3, 6);  if(jge(0x1007_09b2, 0xf9)) goto l_0x1007_09b2;/* jge 0x100709b2 */
            ii(0x1007_08b9, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_08bc, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x1007_08bf, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_08c1, 2);  if(jl(0x1007_08d2, 0xf)) goto l_0x1007_08d2;/* jl 0x100708d2 */
            ii(0x1007_08c3, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_08c6, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1007_08c9, 7);  cmp(ax, memw[ds, 0x101c_8172]);       /* cmp ax, [0x101c8172] */
            ii(0x1007_08d0, 2);  if(jl(0x1007_08d4, 2)) goto l_0x1007_08d4;/* jl 0x100708d4 */
        l_0x1007_08d2:
            ii(0x1007_08d2, 2);  jmp(0x1007_08de, 0xa); goto l_0x1007_08de;/* jmp 0x100708de */
        l_0x1007_08d4:
            ii(0x1007_08d4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_08d7, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x1007_08da, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_08dc, 2);  if(jge(0x1007_08e0, 2)) goto l_0x1007_08e0;/* jge 0x100708e0 */
        l_0x1007_08de:
            ii(0x1007_08de, 2);  jmp(0x1007_08ef, 0xf); goto l_0x1007_08ef;/* jmp 0x100708ef */
        l_0x1007_08e0:
            ii(0x1007_08e0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_08e3, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x1007_08e6, 7);  cmp(ax, memw[ds, 0x101c_8174]);       /* cmp ax, [0x101c8174] */
            ii(0x1007_08ed, 2);  if(jl(0x1007_08f4, 5)) goto l_0x1007_08f4;/* jl 0x100708f4 */
        l_0x1007_08ef:
            ii(0x1007_08ef, 5);  jmp(0x1007_099b, 0xa7); goto l_0x1007_099b;/* jmp 0x1007099b */
        l_0x1007_08f4:
            ii(0x1007_08f4, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x1007_08f7, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x1007_08fa, 5);  jmp(0x1007_097f, 0x80); goto l_0x1007_097f;/* jmp 0x1007097f */
        l_0x1007_08ff:
            ii(0x1007_08ff, 5);  mov(eax, 2);                          /* mov eax, 0x2 */
            ii(0x1007_0904, 1);  push(eax);                            /* push eax */
            ii(0x1007_0905, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_0908, 3);  movsx(ecx, memw[ds, eax]);            /* movsx ecx, word [eax] */
            ii(0x1007_090b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_090e, 3);  movsx(ebx, memw[ds, eax]);            /* movsx ebx, word [eax] */
            ii(0x1007_0911, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_0914, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1007_0917, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1007_0919, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1007_091c, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_0920, 5);  call(0x1007_02b9, -0x66c);            /* call 0x100702b9 */
            ii(0x1007_0925, 3);  test(ax, ax);                         /* test ax, ax */
            ii(0x1007_0928, 2);  if(jz(0x1007_0936, 0xc)) goto l_0x1007_0936;/* jz 0x10070936 */
            ii(0x1007_092a, 7);  mov(memd[ss, ebp - 52], 1);           /* mov dword [ebp-0x34], 0x1 */
            ii(0x1007_0931, 5);  jmp(0x1007_09b9, 0x83); goto l_0x1007_09b9;/* jmp 0x100709b9 */
        l_0x1007_0936:
            ii(0x1007_0936, 2);  jmp(0x1007_099b, 0x63); goto l_0x1007_099b;/* jmp 0x1007099b */
        l_0x1007_0938:
            ii(0x1007_0938, 5);  call(0x1007_6034, 0x56f7);            /* call 0x10076034 */
            ii(0x1007_093d, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1007_093f, 2);  mov(cl, al);                          /* mov cl, al */
            ii(0x1007_0941, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_0944, 3);  movsx(ebx, memw[ds, eax]);            /* movsx ebx, word [eax] */
            ii(0x1007_0947, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_094a, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1007_094d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_0950, 5);  call(0x1007_4c30, 0x42db);            /* call 0x10074c30 */
            ii(0x1007_0955, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1007_0957, 2);  if(jz(0x1007_097b, 0x22)) goto l_0x1007_097b;/* jz 0x1007097b */
            ii(0x1007_0959, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_095c, 3);  mov(ecx, memd[ds, eax + 16]);         /* mov ecx, [eax+0x10] */
            ii(0x1007_095f, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x1007_0962, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_0965, 3);  movsx(ebx, memw[ds, eax]);            /* movsx ebx, word [eax] */
            ii(0x1007_0968, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_096b, 3);  movsx(edx, memw[ds, eax]);            /* movsx edx, word [eax] */
            ii(0x1007_096e, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_0971, 5);  call(0x1007_0d68, 0x3f2);             /* call 0x10070d68 */
            ii(0x1007_0976, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x1007_0979, 2);  jmp(0x1007_09b9, 0x3e); goto l_0x1007_09b9;/* jmp 0x100709b9 */
        l_0x1007_097b:
            ii(0x1007_097b, 2);  jmp(0x1007_099b, 0x1e); goto l_0x1007_099b;/* jmp 0x1007099b */
        l_0x1007_097d:
            ii(0x1007_097d, 2);  jmp(0x1007_099b, 0x1c); goto l_0x1007_099b;/* jmp 0x1007099b */
        l_0x1007_097f:
            ii(0x1007_097f, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1007_0982, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x1007_0985, 5);  cmp(memw[ss, ebp - 56], 0);           /* cmp word [ebp-0x38], 0x0 */
            ii(0x1007_098a, 6);  if(jbe(0x1007_08ff, -0x91)) goto l_0x1007_08ff;/* jbe 0x100708ff */
            ii(0x1007_0990, 5);  cmp(memw[ss, ebp - 56], 1);           /* cmp word [ebp-0x38], 0x1 */
            ii(0x1007_0995, 2);  if(jz(0x1007_0938, -0x5f)) goto l_0x1007_0938;/* jz 0x10070938 */
            ii(0x1007_0997, 2);  jmp(0x1007_097d, -0x1c); goto l_0x1007_097d;/* jmp 0x1007097d */
        //  ii(0x1007_0999, 2);  jmp(0x1007_097d, -0x1e); goto l_0x1007_097d;/* jmp 0x1007097d */
        l_0x1007_099b:
            ii(0x1007_099b, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_099e, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1007_09a1, 3);  add(memw[ds, edx], ax);               /* add [edx], ax */
            ii(0x1007_09a4, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1007_09a7, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_09aa, 3);  add(memw[ds, edx], ax);               /* add [edx], ax */
            ii(0x1007_09ad, 5);  jmp(0x1007_08a6, -0x10c); goto l_0x1007_08a6;/* jmp 0x100708a6 */
        l_0x1007_09b2:
            ii(0x1007_09b2, 7);  mov(memd[ss, ebp - 52], 0);           /* mov dword [ebp-0x34], 0x0 */
        l_0x1007_09b9:
            ii(0x1007_09b9, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x1007_09bc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_09be, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_09bf, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_09c0, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_09c1, 3);  ret(0xc);                             /* ret 0xc */
        }
    }
}
