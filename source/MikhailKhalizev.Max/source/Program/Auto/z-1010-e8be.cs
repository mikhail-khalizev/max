using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_e8be-eb4d4dc1")]
        public void Method_1010_e8be()
        {
            ii(0x1010_e8be, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1010_e8c3, 5);  call(Definitions.sys_check_available_stack_size, 0x5_748a);/* call 0x10165d52 */
            ii(0x1010_e8c8, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_e8c9, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_e8ca, 1);  push(esi);                            /* push esi */
            ii(0x1010_e8cb, 1);  push(edi);                            /* push edi */
            ii(0x1010_e8cc, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_e8cd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_e8cf, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x1010_e8d5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_e8d8, 3);  mov(memb[ss, ebp - 4], dl);           /* mov [ebp-0x4], dl */
            ii(0x1010_e8db, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1010_e8df, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1010_e8e1, 3);  mov(bl, memb[ss, ebp - 12]);          /* mov bl, [ebp-0xc] */
            ii(0x1010_e8e4, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_e8e6, 3);  mov(dl, memb[ss, ebp - 4]);           /* mov dl, [ebp-0x4] */
            ii(0x1010_e8e9, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1010_e8ed, 5);  call(0x1012_91bd, 0x1_a8cb);          /* call 0x101291bd */
            ii(0x1010_e8f2, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1010_e8f4, 2);  if(jz(0x1010_e917, 0x21)) goto l_0x1010_e917;/* jz 0x1010e917 */
            ii(0x1010_e8f6, 4);  cmp(memb[ss, ebp - 4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_e8fa, 2);  if(jz(0x1010_e906, 0xa)) goto l_0x1010_e906;/* jz 0x1010e906 */
            ii(0x1010_e8fc, 5);  call(0x1010_b713, -0x31ee);           /* call 0x1010b713 */
            ii(0x1010_e901, 5);  call(0x1012_93c3, 0x1_aabd);          /* call 0x101293c3 */
        l_0x1010_e906:
            ii(0x1010_e906, 5);  mov(eax, memd[ds, 0x101c_391b]);      /* mov eax, [0x101c391b] */
            ii(0x1010_e90b, 3);  sar(eax, 0x18);                       /* sar eax, 0x18 */
            ii(0x1010_e90e, 5);  call(0x100f_f0ba, -0xf859);           /* call 0x100ff0ba */
            ii(0x1010_e913, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x1010_e917:
            ii(0x1010_e917, 5);  call(0x1012_9cc6, 0x1_b3aa);          /* call 0x10129cc6 */
            ii(0x1010_e91c, 4);  cmp(memb[ss, ebp - 12], 0);           /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1010_e920, 2);  if(jnz(0x1010_e92b, 9)) goto l_0x1010_e92b;/* jnz 0x1010e92b */
            ii(0x1010_e922, 7);  mov(memd[ss, ebp - 16], 1);           /* mov dword [ebp-0x10], 0x1 */
            ii(0x1010_e929, 2);  jmp(0x1010_e932, 7); goto l_0x1010_e932;/* jmp 0x1010e932 */
        l_0x1010_e92b:
            ii(0x1010_e92b, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1010_e932:
            ii(0x1010_e932, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_e935, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_e938, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1010_e93b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_e93d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_e93e, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_e93f, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_e940, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_e941, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_e942, 1);  ret();                                /* ret */
        }
    }
}
