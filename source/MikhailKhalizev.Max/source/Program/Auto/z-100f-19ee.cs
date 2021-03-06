using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_19ee-79f91c31")]
        public void Method_100f_19ee()
        {
            ii(0x100f_19ee, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100f_19f3, 5);  call(Definitions.sys_check_available_stack_size, 0x7_435a);/* call 0x10165d52 */
            ii(0x100f_19f8, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_19f9, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_19fa, 1);  push(edx);                            /* push edx */
            ii(0x100f_19fb, 1);  push(esi);                            /* push esi */
            ii(0x100f_19fc, 1);  push(edi);                            /* push edi */
            ii(0x100f_19fd, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_19fe, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_1a00, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100f_1a06, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100f_1a09, 7);  cmp(memb[ds, 0x101c_3919], 0);        /* cmp byte [0x101c3919], 0x0 */
            ii(0x100f_1a10, 2);  if(jz(0x100f_1a75, 0x63)) goto l_0x100f_1a75;/* jz 0x100f1a75 */
            ii(0x100f_1a12, 7);  mov(memb[ds, 0x101c_3911], 0);        /* mov byte [0x101c3911], 0x0 */
            ii(0x100f_1a19, 5);  call(0x100d_51c4, -0x1_c85a);         /* call 0x100d51c4 */
            ii(0x100f_1a1e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_1a20, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100f_1a22, 5);  mov(eax, memd[ds, 0x101c_393c]);      /* mov eax, [0x101c393c] */
            ii(0x100f_1a27, 5);  call(0x100c_fb06, -0x2_1f26);         /* call 0x100cfb06 */
            ii(0x100f_1a2c, 5);  call(0x100f_0fc5, -0xa6c);            /* call 0x100f0fc5 */
            ii(0x100f_1a31, 5);  mov(edx, 0x509);                      /* mov edx, 0x509 */
            ii(0x100f_1a36, 5);  mov(eax, 0x101c_7278);                /* mov eax, 0x101c7278 */
            ii(0x100f_1a3b, 5);  call(0x1013_dc59, 0x4_c219);          /* call 0x1013dc59 */
            ii(0x100f_1a40, 7);  mov(memd[ss, ebp - 8], 0xb);          /* mov dword [ebp-0x8], 0xb */
            ii(0x100f_1a47, 2);  jmp(0x100f_1a4f, 6); goto l_0x100f_1a4f;/* jmp 0x100f1a4f */
        l_0x100f_1a49:
            ii(0x100f_1a49, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_1a4c, 3);  dec(memd[ss, ebp - 8]);               /* dec dword [ebp-0x8] */
        l_0x100f_1a4f:
            ii(0x100f_1a4f, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_1a53, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100f_1a55, 2);  if(jl(0x100f_1a75, 0x1e)) goto l_0x100f_1a75;/* jl 0x100f1a75 */
            ii(0x100f_1a57, 5);  call(0x1014_82f4, 0x5_6898);          /* call 0x101482f4 */
            ii(0x100f_1a5c, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100f_1a5e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1a61, 3);  mov(memd[ds, eax + 24], edx);         /* mov [eax+0x18], edx */
            ii(0x100f_1a64, 4);  imul(eax, memd[ss, ebp - 8], 0x14);   /* imul eax, [ebp-0x8], 0x14 */
            ii(0x100f_1a68, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100f_1a6b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1a6e, 5);  call(0x100f_17e0, -0x293);            /* call 0x100f17e0 */
            ii(0x100f_1a73, 2);  jmp(0x100f_1a49, -0x2c); goto l_0x100f_1a49;/* jmp 0x100f1a49 */
        l_0x100f_1a75:
            ii(0x100f_1a75, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_1a78, 5);  call(0x100f_140e, -0x66f);            /* call 0x100f140e */
            ii(0x100f_1a7d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_1a7f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_1a80, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_1a81, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_1a82, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_1a83, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_1a84, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_1a85, 1);  ret();                                /* ret */
        }
    }
}
