using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_d247-3f058dcb")]
        public void Method_100a_d247()
        {
            ii(0x100a_d247, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_d24c, 5); calld(Definitions.sys_check_available_stack_size, 0xb_8b01); /* call 0x10165d52 */
            ii(0x100a_d251, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_d252, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_d253, 1); pushd(edx);                             /* push edx */
            ii(0x100a_d254, 1); pushd(esi);                             /* push esi */
            ii(0x100a_d255, 1); pushd(edi);                             /* push edi */
            ii(0x100a_d256, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_d257, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_d259, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_d25f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_d262, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_d265, 3); mov(eax, memd_a32[ds, eax + 0x24]);     /* mov eax, [eax+0x24] */
            ii(0x100a_d268, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_d26b, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x100a_d26e, 2); if(jzd(0x100a_d28e, 0x1e)) goto l_0x100a_d28e; /* jz 0x100ad28e */
            ii(0x100a_d270, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_d273, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_d276, 5); calld(0x1007_6574, -0x3_6d07);          /* call 0x10076574 */
            ii(0x100a_d27b, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100a_d27e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_d281, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_d284, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x100a_d287, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_d28a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_d28c, 2); if(jzd(0x100a_d290, 0x2)) goto l_0x100a_d290; /* jz 0x100ad290 */
        l_0x100a_d28e:
            ii(0x100a_d28e, 2); jmpd(0x100a_d2ae, 0x1e); goto l_0x100a_d2ae; /* jmp 0x100ad2ae */
        l_0x100a_d290:
            ii(0x100a_d290, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_d293, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_d296, 5); calld(0x1007_6574, -0x3_6d27);          /* call 0x10076574 */
            ii(0x100a_d29b, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x100a_d29e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_d2a1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_d2a4, 3); mov(eax, memd_a32[ds, eax + 0x1e]);     /* mov eax, [eax+0x1e] */
            ii(0x100a_d2a7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_d2aa, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_d2ac, 2); if(jzd(0x100a_d2b0, 0x2)) goto l_0x100a_d2b0; /* jz 0x100ad2b0 */
        l_0x100a_d2ae:
            ii(0x100a_d2ae, 2); jmpd(0x100a_d2b6, 0x6); goto l_0x100a_d2b6; /* jmp 0x100ad2b6 */
        l_0x100a_d2b0:
            ii(0x100a_d2b0, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100a_d2b4, 2); jmpd(0x100a_d2ba, 0x4); goto l_0x100a_d2ba; /* jmp 0x100ad2ba */
        l_0x100a_d2b6:
            ii(0x100a_d2b6, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x100a_d2ba:
            ii(0x100a_d2ba, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100a_d2bd, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x100a_d2c0, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100a_d2c3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_d2c5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_d2c6, 1); popd(edi);                              /* pop edi */
            ii(0x100a_d2c7, 1); popd(esi);                              /* pop esi */
            ii(0x100a_d2c8, 1); popd(edx);                              /* pop edx */
            ii(0x100a_d2c9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_d2ca, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_d2cb, 1); retd(); return;                         /* ret */
        }
    }
}
