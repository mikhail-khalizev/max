using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_aa40-c407cd4b")]
        public void Method_1012_aa40()
        {
            ii(0x1012_aa40, 5); push(0x1c);                             /* push 0x1c */
            ii(0x1012_aa45, 5); call(Definitions.sys_check_available_stack_size, 0x3_b308); /* call 0x10165d52 */
            ii(0x1012_aa4a, 1); push(ebx);                              /* push ebx */
            ii(0x1012_aa4b, 1); push(ecx);                              /* push ecx */
            ii(0x1012_aa4c, 1); push(edx);                              /* push edx */
            ii(0x1012_aa4d, 1); push(esi);                              /* push esi */
            ii(0x1012_aa4e, 1); push(edi);                              /* push edi */
            ii(0x1012_aa4f, 1); push(ebp);                              /* push ebp */
            ii(0x1012_aa50, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_aa52, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x1012_aa58, 7); mov(memb[ds, 0x101c_5c1c], 0x21);       /* mov byte [0x101c5c1c], 0x21 */
            ii(0x1012_aa5f, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_aa64, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x1012_aa68, 6); mov(memw[ds, 0x101c_5c1d], ax);         /* mov [0x101c5c1d], ax */
            ii(0x1012_aa6e, 9); mov(memw[ds, 0x101c_5c1f], 0x78);       /* mov word [0x101c5c1f], 0x78 */
            ii(0x1012_aa77, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_aa7c, 5); add(eax, 0x3b0);                        /* add eax, 0x3b0 */
            ii(0x1012_aa81, 5); call(Definitions.sys_strlen, 0x4_7441); /* call 0x10171ec7 */
            ii(0x1012_aa86, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_aa88, 2); if(jz(0x1012_aace, 0x44)) goto l_0x1012_aace; /* jz 0x1012aace */
            ii(0x1012_aa8a, 6); mov(edx, memd[ds, 0x101c_59cc]);        /* mov edx, [0x101c59cc] */
            ii(0x1012_aa90, 6); add(edx, 0x21a);                        /* add edx, 0x21a */
            ii(0x1012_aa96, 5); mov(eax, 0x101c_5c21);                  /* mov eax, 0x101c5c21 */
            ii(0x1012_aa9b, 5); call(Definitions.sys_strcpy, 0x3_b42f); /* call 0x10165ecf */
            ii(0x1012_aaa0, 5); mov(edx, StringDefinitions.Control30);  /* mov edx, 0x101a8656 */
            ii(0x1012_aaa5, 5); mov(eax, 0x101c_5c21);                  /* mov eax, 0x101c5c21 */
            ii(0x1012_aaaa, 5); call(Definitions.sys_strcat, 0x3_b482); /* call 0x10165f31 */
            ii(0x1012_aaaf, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_aab4, 6); lea(edx, memd[ds, eax + 0x3b0]);        /* lea edx, [eax+0x3b0] */
            ii(0x1012_aaba, 5); mov(eax, 0x101c_5c21);                  /* mov eax, 0x101c5c21 */
            ii(0x1012_aabf, 5); call(Definitions.sys_strcat, 0x3_b46d); /* call 0x10165f31 */
            ii(0x1012_aac4, 5); mov(eax, 5);                            /* mov eax, 0x5 */
            ii(0x1012_aac9, 5); call(0x1012_5be9, -0x4ee5);             /* call 0x10125be9 */
        l_0x1012_aace:
            ii(0x1012_aace, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_aacf, 1); pop(edi);                               /* pop edi */
            ii(0x1012_aad0, 1); pop(esi);                               /* pop esi */
            ii(0x1012_aad1, 1); pop(edx);                               /* pop edx */
            ii(0x1012_aad2, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_aad3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_aad4, 1); ret();                                  /* ret */
        }
    }
}
