using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_9406-66da686")]
        public void Method_1010_9406()
        {
            ii(0x1010_9406, 5); push(0x34);                             /* push 0x34 */
            ii(0x1010_940b, 5); call(Definitions.sys_check_available_stack_size, 0x5_c942); /* call 0x10165d52 */
            ii(0x1010_9410, 1); push(ebx);                              /* push ebx */
            ii(0x1010_9411, 1); push(ecx);                              /* push ecx */
            ii(0x1010_9412, 1); push(edx);                              /* push edx */
            ii(0x1010_9413, 1); push(esi);                              /* push esi */
            ii(0x1010_9414, 1); push(edi);                              /* push edi */
            ii(0x1010_9415, 1); push(ebp);                              /* push ebp */
            ii(0x1010_9416, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_9418, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1010_941e, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1010_9421, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_9424, 4); cmp(memd[ds, eax + 0x11], 0);           /* cmp dword [eax+0x11], 0x0 */
            ii(0x1010_9428, 2); if(jz(0x1010_9454, 0x2a)) goto l_0x1010_9454; /* jz 0x10109454 */
            ii(0x1010_942a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_942d, 3); mov(eax, memd[ds, eax + 0x11]);         /* mov eax, [eax+0x11] */
            ii(0x1010_9430, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_9433, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1010_9437, 2); if(jz(0x1010_944d, 0x14)) goto l_0x1010_944d; /* jz 0x1010944d */
            ii(0x1010_9439, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_943b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_943e, 5); call(Definitions.my_dtor_d3, -0x3_1710); /* call 0x100d7d33 */
            ii(0x1010_9443, 5); call(Definitions.sys_delete, 0x5_cb1c); /* call 0x10165f64 */
            ii(0x1010_9448, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_944b, 2); jmp(0x1010_9454, 7); goto l_0x1010_9454; /* jmp 0x10109454 */
        l_0x1010_944d:
            ii(0x1010_944d, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1010_9454:
            ii(0x1010_9454, 7); mov(memd[ss, ebp - 8], 0xc);            /* mov dword [ebp-0x8], 0xc */
        l_0x1010_945b:
            ii(0x1010_945b, 3); dec(memd[ss, ebp - 8]);                 /* dec dword [ebp-0x8] */
            ii(0x1010_945e, 5); cmp(memw[ss, ebp - 8], -1 /* 0xff */);  /* cmp word [ebp-0x8], 0xffff */
            ii(0x1010_9463, 2); if(jz(0x1010_94a8, 0x43)) goto l_0x1010_94a8; /* jz 0x101094a8 */
            ii(0x1010_9465, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9469, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_946c, 3); add(eax, memd[ss, ebp - 4]);            /* add eax, [ebp-0x4] */
            ii(0x1010_946f, 4); cmp(memd[ds, eax + 0x15], 0);           /* cmp dword [eax+0x15], 0x0 */
            ii(0x1010_9473, 2); if(jz(0x1010_94a6, 0x31)) goto l_0x1010_94a6; /* jz 0x101094a6 */
            ii(0x1010_9475, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1010_9479, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_947c, 3); add(eax, memd[ss, ebp - 4]);            /* add eax, [ebp-0x4] */
            ii(0x1010_947f, 3); mov(eax, memd[ds, eax + 0x15]);         /* mov eax, [eax+0x15] */
            ii(0x1010_9482, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_9485, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1010_9489, 2); if(jz(0x1010_949f, 0x14)) goto l_0x1010_949f; /* jz 0x1010949f */
            ii(0x1010_948b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_948d, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1010_9490, 5); call(Definitions.my_dtor_d2, -0x3_af5d); /* call 0x100ce538 */
            ii(0x1010_9495, 5); call(Definitions.sys_delete, 0x5_caca); /* call 0x10165f64 */
            ii(0x1010_949a, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1010_949d, 2); jmp(0x1010_94a6, 7); goto l_0x1010_94a6; /* jmp 0x101094a6 */
        l_0x1010_949f:
            ii(0x1010_949f, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x1010_94a6:
            ii(0x1010_94a6, 2); jmp(0x1010_945b, -0x4d); goto l_0x1010_945b; /* jmp 0x1010945b */
        l_0x1010_94a8:
            ii(0x1010_94a8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_94aa, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_94ab, 1); pop(edi);                               /* pop edi */
            ii(0x1010_94ac, 1); pop(esi);                               /* pop esi */
            ii(0x1010_94ad, 1); pop(edx);                               /* pop edx */
            ii(0x1010_94ae, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_94af, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_94b0, 1); ret();                                  /* ret */
        }
    }
}
