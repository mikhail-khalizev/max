using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_fb06-9d022e77")]
        public void Method_100c_fb06()
        {
            ii(0x100c_fb06, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_fb0b, 5); call(Definitions.sys_check_available_stack_size, 0x9_6242); /* call 0x10165d52 */
            ii(0x100c_fb10, 1); push(ebx);                              /* push ebx */
            ii(0x100c_fb11, 1); push(ecx);                              /* push ecx */
            ii(0x100c_fb12, 1); push(esi);                              /* push esi */
            ii(0x100c_fb13, 1); push(edi);                              /* push edi */
            ii(0x100c_fb14, 1); push(ebp);                              /* push ebp */
            ii(0x100c_fb15, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_fb17, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_fb1d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_fb20, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x100c_fb23, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_fb26, 4); cmp(memb[ds, eax + 40], 0);             /* cmp byte [eax+0x28], 0x0 */
            ii(0x100c_fb2a, 2); if(jz(0x100c_fb6b, 0x3f)) goto l_0x100c_fb6b; /* jz 0x100cfb6b */
            ii(0x100c_fb2c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_fb2f, 3); cmp(memd[ds, eax], 0);                  /* cmp dword [eax], 0x0 */
            ii(0x100c_fb32, 2); if(jz(0x100c_fb64, 0x30)) goto l_0x100c_fb64; /* jz 0x100cfb64 */
            ii(0x100c_fb34, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_fb36, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100c_fb39, 1); push(eax);                              /* push eax */
            ii(0x100c_fb3a, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100c_fb3c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_fb3f, 5); call(0x100c_e8e2, -0x1262);             /* call 0x100ce8e2 */
            ii(0x100c_fb44, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_fb46, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_fb49, 5); call(0x100c_e897, -0x12b7);             /* call 0x100ce897 */
            ii(0x100c_fb4e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_fb50, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_fb53, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_fb55, 5); call(Definitions.sys_display_draw_2, 0x9_8f96); /* call 0x10168af0 */
            ii(0x100c_fb5a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_fb5d, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_fb5f, 5); call(/* sys */ 0x1016_9870, 0x9_9d0c);  /* call 0x10169870 */
        l_0x100c_fb64:
            ii(0x100c_fb64, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_fb67, 4); mov(memb[ds, eax + 40], 0);             /* mov byte [eax+0x28], 0x0 */
        l_0x100c_fb6b:
            ii(0x100c_fb6b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_fb6d, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_fb6e, 1); pop(edi);                               /* pop edi */
            ii(0x100c_fb6f, 1); pop(esi);                               /* pop esi */
            ii(0x100c_fb70, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_fb71, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_fb72, 1); ret();                                  /* ret */
        }
    }
}
