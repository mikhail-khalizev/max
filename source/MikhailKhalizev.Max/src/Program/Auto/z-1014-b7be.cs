using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_b7be-f2cef21d")]
        public void Method_1014_b7be()
        {
            ii(0x1014_b7be, 5);  push(0x34);                           /* push 0x34 */
            ii(0x1014_b7c3, 5);  call(Definitions.sys_check_available_stack_size, 0x1_a58a);/* call 0x10165d52 */
            ii(0x1014_b7c8, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_b7c9, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_b7ca, 1);  push(esi);                            /* push esi */
            ii(0x1014_b7cb, 1);  push(edi);                            /* push edi */
            ii(0x1014_b7cc, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_b7cd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_b7cf, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1014_b7d5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_b7d8, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_b7db, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_b7de, 4);  mov(ax, memw[ds, eax + 26]);          /* mov ax, [eax+0x1a] */
            ii(0x1014_b7e2, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_b7e5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_b7e8, 4);  mov(ax, memw[ds, eax + 28]);          /* mov ax, [eax+0x1c] */
            ii(0x1014_b7ec, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_b7ef, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_b7f2, 4);  test(memb[ds, eax + 18], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1014_b7f6, 2);  if(jz(0x1014_b801, 9)) goto l_0x1014_b801;/* jz 0x1014b801 */
            ii(0x1014_b7f8, 7);  mov(memd[ss, ebp - 12], 2);           /* mov dword [ebp-0xc], 0x2 */
            ii(0x1014_b7ff, 2);  jmp(0x1014_b808, 7); goto l_0x1014_b808;/* jmp 0x1014b808 */
        l_0x1014_b801:
            ii(0x1014_b801, 7);  mov(memd[ss, ebp - 12], 1);           /* mov dword [ebp-0xc], 0x1 */
        l_0x1014_b808:
            ii(0x1014_b808, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_b80b, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1014_b80e, 5);  jmp(0x1014_b934, 0x121); goto l_0x1014_b934;/* jmp 0x1014b934 */
        l_0x1014_b813:
            ii(0x1014_b813, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_b816, 1);  dec(eax);                             /* dec eax */
            ii(0x1014_b817, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1014_b81a, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1014_b81e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_b821, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1014_b824, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1014_b826, 1);  cwde();                               /* cwde */
            ii(0x1014_b827, 5);  call(0x1007_5331, -0xd_64fb);         /* call 0x10075331 */
            ii(0x1014_b82c, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_b82f, 5);  jmp(0x1014_b9be, 0x18a); goto l_0x1014_b9be;/* jmp 0x1014b9be */
        l_0x1014_b834:
            ii(0x1014_b834, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_b837, 1);  dec(eax);                             /* dec eax */
            ii(0x1014_b838, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1014_b83b, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_b83e, 1);  inc(eax);                             /* inc eax */
            ii(0x1014_b83f, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1014_b842, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_b845, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1014_b848, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1014_b84a, 1);  cwde();                               /* cwde */
            ii(0x1014_b84b, 5);  call(0x1007_5331, -0xd_651f);         /* call 0x10075331 */
            ii(0x1014_b850, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_b853, 5);  jmp(0x1014_b9be, 0x166); goto l_0x1014_b9be;/* jmp 0x1014b9be */
        l_0x1014_b858:
            ii(0x1014_b858, 4);  movsx(ebx, memw[ss, ebp - 16]);       /* movsx ebx, word [ebp-0x10] */
            ii(0x1014_b85c, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_b85f, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1014_b862, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1014_b865, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_b868, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1014_b86b, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1014_b86d, 1);  cwde();                               /* cwde */
            ii(0x1014_b86e, 5);  call(0x1007_5331, -0xd_6542);         /* call 0x10075331 */
            ii(0x1014_b873, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_b876, 5);  jmp(0x1014_b9be, 0x143); goto l_0x1014_b9be;/* jmp 0x1014b9be */
        l_0x1014_b87b:
            ii(0x1014_b87b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_b87e, 1);  inc(eax);                             /* inc eax */
            ii(0x1014_b87f, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1014_b882, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_b885, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1014_b888, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1014_b88b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_b88e, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1014_b891, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1014_b893, 1);  cwde();                               /* cwde */
            ii(0x1014_b894, 5);  call(0x1007_5331, -0xd_6568);         /* call 0x10075331 */
            ii(0x1014_b899, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_b89c, 5);  jmp(0x1014_b9be, 0x11d); goto l_0x1014_b9be;/* jmp 0x1014b9be */
        l_0x1014_b8a1:
            ii(0x1014_b8a1, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_b8a4, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1014_b8a7, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1014_b8aa, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_b8ad, 1);  inc(eax);                             /* inc eax */
            ii(0x1014_b8ae, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1014_b8b1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_b8b4, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1014_b8b7, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1014_b8b9, 1);  cwde();                               /* cwde */
            ii(0x1014_b8ba, 5);  call(0x1007_5331, -0xd_658e);         /* call 0x10075331 */
            ii(0x1014_b8bf, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_b8c2, 5);  jmp(0x1014_b9be, 0xf7); goto l_0x1014_b9be;/* jmp 0x1014b9be */
        l_0x1014_b8c7:
            ii(0x1014_b8c7, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_b8ca, 3);  add(eax, memd[ss, ebp - 12]);         /* add eax, [ebp-0xc] */
            ii(0x1014_b8cd, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1014_b8d0, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1014_b8d4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_b8d7, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1014_b8da, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1014_b8dc, 1);  cwde();                               /* cwde */
            ii(0x1014_b8dd, 5);  call(0x1007_5331, -0xd_65b1);         /* call 0x10075331 */
            ii(0x1014_b8e2, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_b8e5, 5);  jmp(0x1014_b9be, 0xd4); goto l_0x1014_b9be;/* jmp 0x1014b9be */
        l_0x1014_b8ea:
            ii(0x1014_b8ea, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_b8ed, 1);  inc(eax);                             /* inc eax */
            ii(0x1014_b8ee, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1014_b8f1, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_b8f4, 1);  dec(eax);                             /* dec eax */
            ii(0x1014_b8f5, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1014_b8f8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_b8fb, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1014_b8fe, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1014_b900, 1);  cwde();                               /* cwde */
            ii(0x1014_b901, 5);  call(0x1007_5331, -0xd_65d5);         /* call 0x10075331 */
            ii(0x1014_b906, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_b909, 5);  jmp(0x1014_b9be, 0xb0); goto l_0x1014_b9be;/* jmp 0x1014b9be */
        l_0x1014_b90e:
            ii(0x1014_b90e, 4);  movsx(ebx, memw[ss, ebp - 16]);       /* movsx ebx, word [ebp-0x10] */
            ii(0x1014_b912, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_b915, 1);  dec(eax);                             /* dec eax */
            ii(0x1014_b916, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1014_b919, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_b91c, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x1014_b91f, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1014_b921, 1);  cwde();                               /* cwde */
            ii(0x1014_b922, 5);  call(0x1007_5331, -0xd_65f6);         /* call 0x10075331 */
            ii(0x1014_b927, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1014_b92a, 5);  jmp(0x1014_b9be, 0x8f); goto l_0x1014_b9be;/* jmp 0x1014b9be */
        l_0x1014_b92f:
            ii(0x1014_b92f, 5);  jmp(0x1014_b9a1, 0x6d); goto l_0x1014_b9a1;/* jmp 0x1014b9a1 */
        l_0x1014_b934:
            ii(0x1014_b934, 4);  cmp(memd[ss, ebp - 28], 8);           /* cmp dword [ebp-0x1c], 0x8 */
            ii(0x1014_b938, 2);  if(jb(0x1014_b979, 0x3f)) goto l_0x1014_b979;/* jb 0x1014b979 */
            ii(0x1014_b93a, 4);  cmp(memd[ss, ebp - 28], 8);           /* cmp dword [ebp-0x1c], 0x8 */
            ii(0x1014_b93e, 6);  if(jbe(0x1014_b87b, -0xc9)) goto l_0x1014_b87b;/* jbe 0x1014b87b */
            ii(0x1014_b944, 4);  cmp(memd[ss, ebp - 28], 0x20);        /* cmp dword [ebp-0x1c], 0x20 */
            ii(0x1014_b948, 2);  if(jb(0x1014_b96d, 0x23)) goto l_0x1014_b96d;/* jb 0x1014b96d */
            ii(0x1014_b94a, 4);  cmp(memd[ss, ebp - 28], 0x20);        /* cmp dword [ebp-0x1c], 0x20 */
            ii(0x1014_b94e, 6);  if(jbe(0x1014_b8a1, -0xb3)) goto l_0x1014_b8a1;/* jbe 0x1014b8a1 */
            ii(0x1014_b954, 4);  cmp(memd[ss, ebp - 28], 0x40);        /* cmp dword [ebp-0x1c], 0x40 */
            ii(0x1014_b958, 2);  if(jb(0x1014_b96b, 0x11)) goto l_0x1014_b96b;/* jb 0x1014b96b */
            ii(0x1014_b95a, 4);  cmp(memd[ss, ebp - 28], 0x40);        /* cmp dword [ebp-0x1c], 0x40 */
            ii(0x1014_b95e, 2);  if(jbe(0x1014_b90e, -0x52)) goto l_0x1014_b90e;/* jbe 0x1014b90e */
            ii(0x1014_b960, 7);  cmp(memd[ss, ebp - 28], 0x80);        /* cmp dword [ebp-0x1c], 0x80 */
            ii(0x1014_b967, 2);  if(jz(0x1014_b8ea, -0x7f)) goto l_0x1014_b8ea;/* jz 0x1014b8ea */
            ii(0x1014_b969, 2);  jmp(0x1014_b92f, -0x3c); goto l_0x1014_b92f;/* jmp 0x1014b92f */
        l_0x1014_b96b:
            ii(0x1014_b96b, 2);  jmp(0x1014_b92f, -0x3e); goto l_0x1014_b92f;/* jmp 0x1014b92f */
        l_0x1014_b96d:
            ii(0x1014_b96d, 4);  cmp(memd[ss, ebp - 28], 0x10);        /* cmp dword [ebp-0x1c], 0x10 */
            ii(0x1014_b971, 6);  if(jz(0x1014_b8c7, -0xb0)) goto l_0x1014_b8c7;/* jz 0x1014b8c7 */
            ii(0x1014_b977, 2);  jmp(0x1014_b92f, -0x4a); goto l_0x1014_b92f;/* jmp 0x1014b92f */
        l_0x1014_b979:
            ii(0x1014_b979, 4);  cmp(memd[ss, ebp - 28], 2);           /* cmp dword [ebp-0x1c], 0x2 */
            ii(0x1014_b97d, 2);  if(jb(0x1014_b995, 0x16)) goto l_0x1014_b995;/* jb 0x1014b995 */
            ii(0x1014_b97f, 4);  cmp(memd[ss, ebp - 28], 2);           /* cmp dword [ebp-0x1c], 0x2 */
            ii(0x1014_b983, 6);  if(jbe(0x1014_b834, -0x155)) goto l_0x1014_b834;/* jbe 0x1014b834 */
            ii(0x1014_b989, 4);  cmp(memd[ss, ebp - 28], 4);           /* cmp dword [ebp-0x1c], 0x4 */
            ii(0x1014_b98d, 6);  if(jz(0x1014_b858, -0x13b)) goto l_0x1014_b858;/* jz 0x1014b858 */
            ii(0x1014_b993, 2);  jmp(0x1014_b92f, -0x66); goto l_0x1014_b92f;/* jmp 0x1014b92f */
        l_0x1014_b995:
            ii(0x1014_b995, 4);  cmp(memd[ss, ebp - 28], 1);           /* cmp dword [ebp-0x1c], 0x1 */
            ii(0x1014_b999, 6);  if(jz(0x1014_b813, -0x18c)) goto l_0x1014_b813;/* jz 0x1014b813 */
            ii(0x1014_b99f, 2);  jmp(0x1014_b92f, -0x72); goto l_0x1014_b92f;/* jmp 0x1014b92f */
        l_0x1014_b9a1:
            ii(0x1014_b9a1, 5);  mov(ecx, 0x4b4);                      /* mov ecx, 0x4b4 */
            ii(0x1014_b9a6, 5);  mov(ebx, StringDefinitions.UnitinfoCpp);/* mov ebx, 0x101ad2d6 */
            ii(0x1014_b9ab, 5);  mov(edx, StringDefinitions.False);    /* mov edx, 0x101ad2e3 */
            ii(0x1014_b9b0, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1014_b9b2, 5);  call(Definitions.sys_assert, 0x1_a3db);/* call 0x10165d92 */
            ii(0x1014_b9b7, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x1014_b9be:
            ii(0x1014_b9be, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1014_b9c1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_b9c3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_b9c4, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_b9c5, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_b9c6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_b9c7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_b9c8, 1);  ret();                                /* ret */
        }
    }
}
