using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_82f4-ce368ec0")]
        public void Method_1014_82f4()
        {
            ii(0x1014_82f4, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1014_82f9, 5);  call(Definitions.sys_check_available_stack_size, 0x1_da54);/* call 0x10165d52 */
            ii(0x1014_82fe, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_82ff, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_8300, 1);  push(edx);                            /* push edx */
            ii(0x1014_8301, 1);  push(esi);                            /* push esi */
            ii(0x1014_8302, 1);  push(edi);                            /* push edi */
            ii(0x1014_8303, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_8304, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_8306, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_830c, 7);  cmp(memd[ds, 0x101c_8138], 0);        /* cmp dword [0x101c8138], 0x0 */
            ii(0x1014_8313, 2);  if(jnz(0x1014_831e, 9)) goto l_0x1014_831e;/* jnz 0x1014831e */
            ii(0x1014_8315, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1014_831c, 2);  jmp(0x1014_8372, 0x54); goto l_0x1014_8372;/* jmp 0x10148372 */
        l_0x1014_831e:
            ii(0x1014_831e, 5);  call(Definitions.sys_cli, 0x3_8cb7);  /* call 0x10180fda */
            ii(0x1014_8323, 5);  mov(edx, 0x80);                       /* mov edx, 0x80 */
            ii(0x1014_8328, 5);  mov(eax, 0x43);                       /* mov eax, 0x43 */
            ii(0x1014_832d, 5);  call(Definitions.sys_write_port, 0x3_8c96);/* call 0x10180fc8 */
            ii(0x1014_8332, 5);  mov(eax, 0x42);                       /* mov eax, 0x42 */
            ii(0x1014_8337, 5);  call(Definitions.sys_read_port, 0x3_8c96);/* call 0x10180fd2 */
            ii(0x1014_833c, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_833f, 5);  mov(eax, 0x42);                       /* mov eax, 0x42 */
            ii(0x1014_8344, 5);  call(Definitions.sys_read_port, 0x3_8c89);/* call 0x10180fd2 */
            ii(0x1014_8349, 3);  shl(eax, 8);                          /* shl eax, 0x8 */
            ii(0x1014_834c, 3);  add(memd[ss, ebp - 8], eax);          /* add [ebp-0x8], eax */
            ii(0x1014_834f, 5);  mov(eax, memd[ds, 0x101c_8130]);      /* mov eax, [0x101c8130] */
            ii(0x1014_8354, 3);  sub(eax, memd[ss, ebp - 8]);          /* sub eax, [ebp-0x8] */
            ii(0x1014_8357, 5);  and(eax, 0xffff);                     /* and eax, 0xffff */
            ii(0x1014_835c, 6);  mov(edx, memd[ds, 0x101c_8134]);      /* mov edx, [0x101c8134] */
            ii(0x1014_8362, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1014_8364, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_8367, 5);  call(Definitions.sys_sti, 0x3_8c70);  /* call 0x10180fdc */
            ii(0x1014_836c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_836f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x1014_8372:
            ii(0x1014_8372, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_8375, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_8377, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_8378, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_8379, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_837a, 1);  pop(edx);                             /* pop edx */
            ii(0x1014_837b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_837c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_837d, 1);  ret();                                /* ret */
        }
    }
}
