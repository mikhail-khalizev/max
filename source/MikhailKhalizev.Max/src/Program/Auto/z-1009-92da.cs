using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_92da-77e50dad")]
        public void Method_1009_92da()
        {
            ii(0x1009_92da, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1009_92df, 5); call(Definitions.sys_check_available_stack_size, 0xc_ca6e); /* call 0x10165d52 */
            ii(0x1009_92e4, 1); push(ebx);                              /* push ebx */
            ii(0x1009_92e5, 1); push(ecx);                              /* push ecx */
            ii(0x1009_92e6, 1); push(esi);                              /* push esi */
            ii(0x1009_92e7, 1); push(edi);                              /* push edi */
            ii(0x1009_92e8, 1); push(ebp);                              /* push ebp */
            ii(0x1009_92e9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_92eb, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1009_92f1, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_92f4, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1009_92f7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_92fa, 4); cmp(memb[ds, eax + 29], 5);             /* cmp byte [eax+0x1d], 0x5 */
            ii(0x1009_92fe, 2); if(jz(0x1009_9310, 0x10)) goto l_0x1009_9310; /* jz 0x10099310 */
            ii(0x1009_9300, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_9303, 4); mov(dx, memw[ds, eax + 8]);             /* mov dx, [eax+0x8] */
            ii(0x1009_9307, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_930a, 4); cmp(dx, memw[ds, eax + 19]);            /* cmp dx, [eax+0x13] */
            ii(0x1009_930e, 2); if(jz(0x1009_9312, 2)) goto l_0x1009_9312; /* jz 0x10099312 */
        l_0x1009_9310:
            ii(0x1009_9310, 2); jmp(0x1009_9327, 0x15); goto l_0x1009_9327; /* jmp 0x10099327 */
        l_0x1009_9312:
            ii(0x1009_9312, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_9315, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1009_9318, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1009_931b, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1009_931e, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_9321, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1009_9324, 3); call_abs(memd[ds, ebx + 44]);           /* call dword [ebx+0x2c] */
        l_0x1009_9327:
            ii(0x1009_9327, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_932a, 4); cmp(memb[ds, eax + 29], 5);             /* cmp byte [eax+0x1d], 0x5 */
            ii(0x1009_932e, 2); if(jz(0x1009_9342, 0x12)) goto l_0x1009_9342; /* jz 0x10099342 */
            ii(0x1009_9330, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_9333, 3); add(edx, 0x15);                         /* add edx, 0x15 */
            ii(0x1009_9336, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_9339, 5); call(0x1007_6d98, -0x2_25a6);           /* call 0x10076d98 */
            ii(0x1009_933e, 2); test(al, al);                           /* test al, al */
            ii(0x1009_9340, 2); if(jnz(0x1009_9344, 2)) goto l_0x1009_9344; /* jnz 0x10099344 */
        l_0x1009_9342:
            ii(0x1009_9342, 2); jmp(0x1009_9356, 0x12); goto l_0x1009_9356; /* jmp 0x10099356 */
        l_0x1009_9344:
            ii(0x1009_9344, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_9347, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1009_934a, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1009_934d, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1009_9350, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1009_9353, 3); call_abs(memd[ds, edx + 52]);           /* call dword [edx+0x34] */
        l_0x1009_9356:
            ii(0x1009_9356, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_935a, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x1009_935d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_935f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_9360, 1); pop(edi);                               /* pop edi */
            ii(0x1009_9361, 1); pop(esi);                               /* pop esi */
            ii(0x1009_9362, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_9363, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_9364, 1); ret();                                  /* ret */
        }
    }
}
