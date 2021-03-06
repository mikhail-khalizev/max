using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_cf8e-e572c366")]
        public void Method_1013_cf8e()
        {
            ii(0x1013_cf8e, 5);  push(0x40);                           /* push 0x40 */
            ii(0x1013_cf93, 5);  call(Definitions.sys_check_available_stack_size, 0x2_8dba);/* call 0x10165d52 */
            ii(0x1013_cf98, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_cf99, 1);  push(esi);                            /* push esi */
            ii(0x1013_cf9a, 1);  push(edi);                            /* push edi */
            ii(0x1013_cf9b, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_cf9c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_cf9e, 6);  sub(esp, 0x2c);                       /* sub esp, 0x2c */
            ii(0x1013_cfa4, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_cfa7, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1013_cfaa, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1013_cfad, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_cfb0, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_cfb3, 4);  cmp(ax, memw[ds, edx + 12]);          /* cmp ax, [edx+0xc] */
            ii(0x1013_cfb7, 2);  if(jz(0x1013_cfc0, 7)) goto l_0x1013_cfc0;/* jz 0x1013cfc0 */
            ii(0x1013_cfb9, 5);  cmp(memw[ss, ebp - 8], -1 /* 0xff */);/* cmp word [ebp-0x8], 0xffff */
            ii(0x1013_cfbe, 2);  if(jnz(0x1013_cfc5, 5)) goto l_0x1013_cfc5;/* jnz 0x1013cfc5 */
        l_0x1013_cfc0:
            ii(0x1013_cfc0, 5);  jmp(0x1013_d083, 0xbe); goto l_0x1013_d083;/* jmp 0x1013d083 */
        l_0x1013_cfc5:
            ii(0x1013_cfc5, 5);  mov(eax, 0x39);                       /* mov eax, 0x39 */
            ii(0x1013_cfca, 5);  call(0x1007_5fdc, -0xc_6ff3);         /* call 0x10075fdc */
            ii(0x1013_cfcf, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1013_cfd1, 2);  if(jz(0x1013_cfe2, 0xf)) goto l_0x1013_cfe2;/* jz 0x1013cfe2 */
            ii(0x1013_cfd3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_cfd6, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_cfd9, 4);  mov(memw[ds, edx + 14], ax);          /* mov [edx+0xe], ax */
            ii(0x1013_cfdd, 5);  jmp(0x1013_d083, 0xa1); goto l_0x1013_d083;/* jmp 0x1013d083 */
        l_0x1013_cfe2:
            ii(0x1013_cfe2, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_cfe5, 5);  call(0x1013_d111, 0x127);             /* call 0x1013d111 */
            ii(0x1013_cfea, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1013_cfed, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1013_cff0, 6);  mov(memb[ds, edx + 3529], al);        /* mov [edx+0xdc9], al */
            ii(0x1013_cff6, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1013_cffa, 2);  if(jz(0x1013_d00e, 0x12)) goto l_0x1013_d00e;/* jz 0x1013d00e */
            ii(0x1013_cffc, 6);  cmp(memw[ss, ebp - 8], 0x6a5);        /* cmp word [ebp-0x8], 0x6a5 */
            ii(0x1013_d002, 2);  if(jl(0x1013_d00c, 8)) goto l_0x1013_d00c;/* jl 0x1013d00c */
            ii(0x1013_d004, 6);  cmp(memw[ss, ebp - 8], 0x6ae);        /* cmp word [ebp-0x8], 0x6ae */
            ii(0x1013_d00a, 2);  if(jle(0x1013_d00e, 2)) goto l_0x1013_d00e;/* jle 0x1013d00e */
        l_0x1013_d00c:
            ii(0x1013_d00c, 2);  jmp(0x1013_d010, 2); goto l_0x1013_d010;/* jmp 0x1013d010 */
        l_0x1013_d00e:
            ii(0x1013_d00e, 2);  jmp(0x1013_d035, 0x25); goto l_0x1013_d035;/* jmp 0x1013d035 */
        l_0x1013_d010:
            ii(0x1013_d010, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_d017, 2);  jmp(0x1013_d01f, 6); goto l_0x1013_d01f;/* jmp 0x1013d01f */
        l_0x1013_d019:
            ii(0x1013_d019, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_d01c, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
        l_0x1013_d01f:
            ii(0x1013_d01f, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1013_d023, 3);  cmp(eax, 0xa);                        /* cmp eax, 0xa */
            ii(0x1013_d026, 2);  if(jz(0x1013_d035, 0xd)) goto l_0x1013_d035;/* jz 0x1013d035 */
            ii(0x1013_d028, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1013_d02c, 7);  mov(memb[ds, eax + 0x101c_8084], 1);  /* mov byte [eax+0x101c8084], 0x1 */
            ii(0x1013_d033, 2);  jmp(0x1013_d019, -0x1c); goto l_0x1013_d019;/* jmp 0x1013d019 */
        l_0x1013_d035:
            ii(0x1013_d035, 4);  mov(memb[ss, ebp - 34], 4);           /* mov byte [ebp-0x22], 0x4 */
            ii(0x1013_d039, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_d03c, 4);  mov(memw[ss, ebp - 44], ax);          /* mov [ebp-0x2c], ax */
            ii(0x1013_d040, 7);  mov(memd[ss, ebp - 42], 0x7fff);      /* mov dword [ebp-0x2a], 0x7fff */
            ii(0x1013_d047, 7);  mov(memd[ss, ebp - 38], 0x7fff);      /* mov dword [ebp-0x26], 0x7fff */
            ii(0x1013_d04e, 7);  mov(memd[ss, ebp - 33], 0x8000);      /* mov dword [ebp-0x21], 0x8000 */
            ii(0x1013_d055, 7);  mov(memd[ss, ebp - 29], 0);           /* mov dword [ebp-0x1d], 0x0 */
            ii(0x1013_d05c, 6);  mov(memw[ss, ebp - 25], 0);           /* mov word [ebp-0x19], 0x0 */
            ii(0x1013_d062, 6);  mov(memw[ss, ebp - 23], 0);           /* mov word [ebp-0x17], 0x0 */
            ii(0x1013_d068, 6);  mov(memw[ss, ebp - 21], 0);           /* mov word [ebp-0x15], 0x0 */
            ii(0x1013_d06e, 4);  mov(memb[ss, ebp - 19], 0);           /* mov byte [ebp-0x13], 0x0 */
            ii(0x1013_d072, 6);  mov(memw[ss, ebp - 18], 0xffff);      /* mov word [ebp-0x12], 0xffff */
            ii(0x1013_d078, 3);  lea(edx, memd[ss, ebp - 44]);         /* lea edx, [ebp-0x2c] */
            ii(0x1013_d07b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_d07e, 5);  call(0x1013_dfd1, 0xf4e);             /* call 0x1013dfd1 */
        l_0x1013_d083:
            ii(0x1013_d083, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_d085, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_d086, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_d087, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_d088, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_d089, 1);  ret();                                /* ret */
        }
    }
}
