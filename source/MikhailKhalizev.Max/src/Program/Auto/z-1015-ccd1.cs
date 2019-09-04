using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_ccd1-a5ca5a50")]
        public void Method_1015_ccd1()
        {
            ii(0x1015_ccd1, 5); push(0x20);                             /* push 0x20 */
            ii(0x1015_ccd6, 5); call(Definitions.sys_check_available_stack_size, 0x9077); /* call 0x10165d52 */
            ii(0x1015_ccdb, 1); push(ebx);                              /* push ebx */
            ii(0x1015_ccdc, 1); push(ecx);                              /* push ecx */
            ii(0x1015_ccdd, 1); push(edx);                              /* push edx */
            ii(0x1015_ccde, 1); push(esi);                              /* push esi */
            ii(0x1015_ccdf, 1); push(edi);                              /* push edi */
            ii(0x1015_cce0, 1); push(ebp);                              /* push ebp */
            ii(0x1015_cce1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_cce3, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1015_cce9, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1015_ccec, 5); mov(eax, StringDefinitions.PowerDown);  /* mov eax, 0x101b2802 */
            ii(0x1015_ccf1, 5); call(0x100a_8b4a, -0xb_41ac);           /* call 0x100a8b4a */
            ii(0x1015_ccf6, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_ccfb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_ccfe, 5); call(0x1007_6d98, -0xe_5f6b);           /* call 0x10076d98 */
            ii(0x1015_cd03, 2); test(al, al);                           /* test al, al */
            ii(0x1015_cd05, 2); if(jz(0x1015_cd22, 0x1b)) goto l_0x1015_cd22; /* jz 0x1015cd22 */
            ii(0x1015_cd07, 5); call(0x1010_2bf8, -0x5_a114);           /* call 0x10102bf8 */
            ii(0x1015_cd0c, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_cd0e, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1015_cd10, 5); mov(ebx, 0x10);                         /* mov ebx, 0x10 */
            ii(0x1015_cd15, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_cd18, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_cd1d, 5); call(0x1013_d5c0, -0x1_f762);           /* call 0x1013d5c0 */
        l_0x1015_cd22:
            ii(0x1015_cd22, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1015_cd27, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_cd2a, 5); call(0x1015_cbca, -0x165);              /* call 0x1015cbca */
            ii(0x1015_cd2f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_cd32, 3); mov(edx, memd[ds, eax + 49]);           /* mov edx, [eax+0x31] */
            ii(0x1015_cd35, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_cd38, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_cd3b, 5); call(0x1014_9b07, -0x1_3239);           /* call 0x10149b07 */
            ii(0x1015_cd40, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_cd43, 5); cmp(memw[ds, eax + 8], 0x1d);           /* cmp word [eax+0x8], 0x1d */
            ii(0x1015_cd48, 2); if(jnz(0x1015_cd66, 0x1c)) goto l_0x1015_cd66; /* jnz 0x1015cd66 */
            ii(0x1015_cd4a, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1015_cd4f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_cd52, 3); mov(edx, memd[ds, eax + 90]);           /* mov edx, [eax+0x5a] */
            ii(0x1015_cd55, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1015_cd58, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_cd5b, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1015_cd5e, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1015_cd60, 1); cwde();                                 /* cwde */
            ii(0x1015_cd61, 5); call(0x1013_322d, -0x2_9b39);           /* call 0x1013322d */
        l_0x1015_cd66:
            ii(0x1015_cd66, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_cd68, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_cd69, 1); pop(edi);                               /* pop edi */
            ii(0x1015_cd6a, 1); pop(esi);                               /* pop esi */
            ii(0x1015_cd6b, 1); pop(edx);                               /* pop edx */
            ii(0x1015_cd6c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_cd6d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_cd6e, 1); ret();                                  /* ret */
        }
    }
}
