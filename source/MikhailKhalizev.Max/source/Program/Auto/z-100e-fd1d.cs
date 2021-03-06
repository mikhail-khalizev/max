using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_fd1d-27804f5e")]
        public void Method_100e_fd1d()
        {
            ii(0x100e_fd1d, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x100e_fd22, 5);  call(Definitions.sys_check_available_stack_size, 0x7_602b);/* call 0x10165d52 */
            ii(0x100e_fd27, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_fd28, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_fd29, 1);  push(esi);                            /* push esi */
            ii(0x100e_fd2a, 1);  push(edi);                            /* push edi */
            ii(0x100e_fd2b, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_fd2c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_fd2e, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100e_fd34, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_fd37, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_fd3a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_fd3d, 3);  mov(ax, memw[ds, eax]);               /* mov ax, [eax] */
            ii(0x100e_fd40, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_fd43, 4);  add(memd[ss, ebp - 8], 2);            /* add dword [ebp-0x8], 0x2 */
            ii(0x100e_fd47, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x100e_fd4e:
            ii(0x100e_fd4e, 3);  dec(memd[ss, ebp - 12]);              /* dec dword [ebp-0xc] */
            ii(0x100e_fd51, 5);  cmp(memw[ss, ebp - 12], -1 /* 0xff */);/* cmp word [ebp-0xc], 0xffff */
            ii(0x100e_fd56, 6);  if(jz(0x100e_fde7, 0x8b)) goto l_0x100e_fde7;/* jz 0x100efde7 */
            ii(0x100e_fd5c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_fd5f, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x100e_fd62, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x100e_fd64, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x100e_fd66, 3);  add(memd[ss, ebp - 16], eax);         /* add [ebp-0x10], eax */
            ii(0x100e_fd69, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100e_fd6c, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x100e_fd6f, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100e_fd71, 2);  mov(al, memb[ds, edx]);               /* mov al, [edx] */
            ii(0x100e_fd73, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_fd76, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100e_fd7a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100e_fd7c, 2);  if(jnz(0x100e_fd85, 7)) goto l_0x100e_fd85;/* jnz 0x100efd85 */
            ii(0x100e_fd7e, 7);  mov(memd[ss, ebp - 20], 0x100);       /* mov dword [ebp-0x14], 0x100 */
        l_0x100e_fd85:
            ii(0x100e_fd85, 3);  dec(memd[ss, ebp - 20]);              /* dec dword [ebp-0x14] */
            ii(0x100e_fd88, 5);  cmp(memw[ss, ebp - 20], -1 /* 0xff */);/* cmp word [ebp-0x14], 0xffff */
            ii(0x100e_fd8d, 2);  if(jz(0x100e_fde2, 0x53)) goto l_0x100e_fde2;/* jz 0x100efde2 */
            ii(0x100e_fd8f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_fd92, 3);  mov(al, memb[ds, eax + 2]);           /* mov al, [eax+0x2] */
            ii(0x100e_fd95, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100e_fd9a, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x100e_fd9e, 2);  sar(eax, cl);                         /* sar eax, cl */
            ii(0x100e_fda0, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_fda2, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100e_fda4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_fda7, 3);  mov(al, memb[ds, eax + 1]);           /* mov al, [eax+0x1] */
            ii(0x100e_fdaa, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100e_fdaf, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x100e_fdb3, 2);  sar(eax, cl);                         /* sar eax, cl */
            ii(0x100e_fdb5, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100e_fdb7, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x100e_fdb9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_fdbc, 2);  mov(al, memb[ds, eax]);               /* mov al, [eax] */
            ii(0x100e_fdbe, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x100e_fdc3, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x100e_fdc7, 2);  sar(eax, cl);                         /* sar eax, cl */
            ii(0x100e_fdc9, 3);  movzx(esi, al);                       /* movzx esi, al */
            ii(0x100e_fdcc, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_fdcf, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
            ii(0x100e_fdd2, 1);  cwde();                               /* cwde */
            ii(0x100e_fdd3, 2);  mov(ecx, edx);                        /* mov ecx, edx */
            ii(0x100e_fdd5, 2);  mov(edx, esi);                        /* mov edx, esi */
            ii(0x100e_fdd7, 5);  call(/* sys */ 0x1016_ccf8, 0x7_cf1c);/* call 0x1016ccf8 */
            ii(0x100e_fddc, 4);  add(memd[ss, ebp - 8], 3);            /* add dword [ebp-0x8], 0x3 */
            ii(0x100e_fde0, 2);  jmp(0x100e_fd85, -0x5d); goto l_0x100e_fd85;/* jmp 0x100efd85 */
        l_0x100e_fde2:
            ii(0x100e_fde2, 5);  jmp(0x100e_fd4e, -0x99); goto l_0x100e_fd4e;/* jmp 0x100efd4e */
        l_0x100e_fde7:
            ii(0x100e_fde7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_fde9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_fdea, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_fdeb, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_fdec, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_fded, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_fdee, 1);  ret();                                /* ret */
        }
    }
}
