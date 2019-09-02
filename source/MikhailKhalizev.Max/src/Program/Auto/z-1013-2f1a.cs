using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_2f1a-6770b175")]
        public void Method_1013_2f1a()
        {
            ii(0x1013_2f1a, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_2f1f, 5); call(Definitions.sys_check_available_stack_size, 0x3_2e2e); /* call 0x10165d52 */
            ii(0x1013_2f24, 1); push(ebx);                              /* push ebx */
            ii(0x1013_2f25, 1); push(ecx);                              /* push ecx */
            ii(0x1013_2f26, 1); push(edx);                              /* push edx */
            ii(0x1013_2f27, 1); push(esi);                              /* push esi */
            ii(0x1013_2f28, 1); push(edi);                              /* push edi */
            ii(0x1013_2f29, 1); push(ebp);                              /* push ebp */
            ii(0x1013_2f2a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_2f2c, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1013_2f32, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_2f35, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_2f38, 4); mov(memb[ds, eax + 0x1d], 0);           /* mov byte [eax+0x1d], 0x0 */
        l_0x1013_2f3c:
            ii(0x1013_2f3c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_2f3f, 4); cmp(memb[ds, eax + 0x1d], 0);           /* cmp byte [eax+0x1d], 0x0 */
            ii(0x1013_2f43, 2); if(jnz(0x1013_2f78, 0x33)) goto l_0x1013_2f78; /* jnz 0x10132f78 */
            ii(0x1013_2f45, 5); call(/* sys */ 0x1016_b208, 0x3_82be);  /* call 0x1016b208 */
            ii(0x1013_2f4a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_2f4d, 7); cmp(memb[ds, 0x101c_37d2], 0);          /* cmp byte [0x101c37d2], 0x0 */
            ii(0x1013_2f54, 2); if(jnz(0x1013_2f5c, 6)) goto l_0x1013_2f5c; /* jnz 0x10132f5c */
            ii(0x1013_2f56, 4); cmp(memd[ss, ebp - 8], 0x1b);           /* cmp dword [ebp-0x8], 0x1b */
            ii(0x1013_2f5a, 2); if(jnz(0x1013_2f63, 7)) goto l_0x1013_2f63; /* jnz 0x10132f63 */
        l_0x1013_2f5c:
            ii(0x1013_2f5c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_2f5f, 4); mov(memb[ds, eax + 0x1d], 1);           /* mov byte [eax+0x1d], 0x1 */
        l_0x1013_2f63:
            ii(0x1013_2f63, 5); call(0x100d_5094, -0x5_ded4);           /* call 0x100d5094 */
            ii(0x1013_2f68, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_2f6a, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1013_2f6c, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1013_2f71, 5); call(0x1010_0e32, -0x3_2144);           /* call 0x10100e32 */
            ii(0x1013_2f76, 2); jmp(0x1013_2f3c, -0x3c); goto l_0x1013_2f3c; /* jmp 0x10132f3c */
        l_0x1013_2f78:
            ii(0x1013_2f78, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_2f7a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_2f7b, 1); pop(edi);                               /* pop edi */
            ii(0x1013_2f7c, 1); pop(esi);                               /* pop esi */
            ii(0x1013_2f7d, 1); pop(edx);                               /* pop edx */
            ii(0x1013_2f7e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_2f7f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_2f80, 1); ret();                                  /* ret */
        }
    }
}
