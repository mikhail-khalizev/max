using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("38fa8992-b012-4fec-9caa-a4618f1473fe")]
        public void Method_100f_4dba()
        {
            ii(0x100f_4dba, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100f_4dbf, 5); calld(Definitions.sys_check_available_stack_size, 0x70f8e); /* call 0x10165d52 */
            ii(0x100f_4dc4, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_4dc5, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_4dc6, 1); pushd(edx);                             /* push edx */
            ii(0x100f_4dc7, 1); pushd(esi);                             /* push esi */
            ii(0x100f_4dc8, 1); pushd(edi);                             /* push edi */
            ii(0x100f_4dc9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_4dca, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_4dcc, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100f_4dd2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4dd4, 5); mov(eax, memd_a32[ds, 0x101b_8761]);    /* mov eax, [0x101b8761] */
            ii(0x100f_4dd9, 5); calld(0x100c_fb73, -0x2526b);           /* call 0x100cfb73 */
            ii(0x100f_4dde, 5); calld(0x100f_fc13, 0xae30);             /* call 0x100ffc13 */
            ii(0x100f_4de3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_4de5, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x100f_4dea, 1); cwde();                                 /* cwde */
            ii(0x100f_4deb, 5); calld(0x1012_3293, 0x2e4a3);            /* call 0x10123293 */
            ii(0x100f_4df0, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x100f_4df5, 5); calld(0x1007_5fdc, -0x7ee1e);           /* call 0x10075fdc */
            ii(0x100f_4dfa, 5); mov(memb_a32[ds, 0x101c_3915], al);     /* mov [0x101c3915], al */
            ii(0x100f_4dff, 5); mov(eax, 0x55);                         /* mov eax, 0x55 */
            ii(0x100f_4e04, 5); calld(0x1007_5fdc, -0x7ee2d);           /* call 0x10075fdc */
            ii(0x100f_4e09, 5); mov(memb_a32[ds, 0x101c_37ca], al);     /* mov [0x101c37ca], al */
            ii(0x100f_4e0e, 5); mov(eax, 0x54);                         /* mov eax, 0x54 */
            ii(0x100f_4e13, 5); calld(0x1007_5fdc, -0x7ee3c);           /* call 0x10075fdc */
            ii(0x100f_4e18, 7); imul(eax, memd_a32[ds, 0x101c_38c4]);   /* imul eax, [0x101c38c4] */
            ii(0x100f_4e1f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_4e22, 6); mov(memw_a32[ds, 0x101c_398a], ax);     /* mov [0x101c398a], ax */
            ii(0x100f_4e28, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x100f_4e2f, 2); if(jzd(0x100f_4e45, 0x14)) goto l_0x100f_4e45; /* jz 0x100f4e45 */
            ii(0x100f_4e31, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x100f_4e36, 5); calld(0x1007_5fdc, -0x7ee5f);           /* call 0x10075fdc */
            ii(0x100f_4e3b, 5); mov(memb_a32[ds, 0x101c_37c9], al);     /* mov [0x101c37c9], al */
            ii(0x100f_4e40, 5); calld(0x1012_93c3, 0x3457e);            /* call 0x101293c3 */
        l_0x100f_4e45:
            ii(0x100f_4e45, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100f_4e4a, 5); calld(0x1007_5fdc, -0x7ee73);           /* call 0x10075fdc */
            ii(0x100f_4e4f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4e51, 6); mov(dl, memb_a32[ds, 0x101c_3920]);     /* mov dl, [0x101c3920] */
            ii(0x100f_4e57, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_4e59, 2); if(jzd(0x100f_4e6f, 0x14)) goto l_0x100f_4e6f; /* jz 0x100f4e6f */
            ii(0x100f_4e5b, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100f_4e60, 5); calld(0x1007_5fdc, -0x7ee89);           /* call 0x10075fdc */
            ii(0x100f_4e65, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_4e6a, 5); calld(0x1007_1cca, -0x831a5);           /* call 0x10071cca */
        l_0x100f_4e6f:
            ii(0x100f_4e6f, 7); mov(memd_a32[ss, ebp - 0x4], 0x4);      /* mov dword [ebp-0x4], 0x4 */
        l_0x100f_4e76:
            ii(0x100f_4e76, 3); dec(memd_a32[ss, ebp - 0x4]);           /* dec dword [ebp-0x4] */
            ii(0x100f_4e79, 5); cmp(memw_a32[ss, ebp - 0x4], -0x1 /* 0xff */); /* cmp word [ebp-0x4], 0xffff */
            ii(0x100f_4e7e, 2); if(jzd(0x100f_4ea6, 0x26)) goto l_0x100f_4ea6; /* jz 0x100f4ea6 */
            ii(0x100f_4e80, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_4e84, 6); mov(eax, memd_a32[ds, eax + 0x101b_873d]); /* mov eax, [eax+0x101b873d] */
            ii(0x100f_4e8a, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x100f_4e8d, 5); calld(0x1007_5fdc, -0x7eeb6);           /* call 0x10075fdc */
            ii(0x100f_4e92, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_4e94, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_4e98, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_4e9e, 6); mov(memb_a32[ds, eax + 0x101c_a490], dl); /* mov [eax+0x101ca490], dl */
            ii(0x100f_4ea4, 2); jmpd(0x100f_4e76, -0x30); goto l_0x100f_4e76; /* jmp 0x100f4e76 */
        l_0x100f_4ea6:
            ii(0x100f_4ea6, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_4eab, 5); calld(0x1007_65d0, -0x7e8e0);           /* call 0x100765d0 */
            ii(0x100f_4eb0, 5); calld(0x100f_fa70, 0xabbb);             /* call 0x100ffa70 */
            ii(0x100f_4eb5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_4eb7, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_4eb8, 1); popd(edi);                              /* pop edi */
            ii(0x100f_4eb9, 1); popd(esi);                              /* pop esi */
            ii(0x100f_4eba, 1); popd(edx);                              /* pop edx */
            ii(0x100f_4ebb, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_4ebc, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_4ebd, 1); retd(); return;                         /* ret */
        }
    }
}
