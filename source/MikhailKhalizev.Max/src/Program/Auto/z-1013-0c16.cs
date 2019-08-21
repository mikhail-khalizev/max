using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_0c16-639c243f")]
        public void Method_1013_0c16()
        {
            ii(0x1013_0c16, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1013_0c1b, 5); calld(Definitions.sys_check_available_stack_size, 0x3_5132); /* call 0x10165d52 */
            ii(0x1013_0c20, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_0c21, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_0c22, 1); pushd(esi);                             /* push esi */
            ii(0x1013_0c23, 1); pushd(edi);                             /* push edi */
            ii(0x1013_0c24, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_0c25, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_0c27, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x1013_0c2d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_0c30, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x1013_0c33, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1013_0c36, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_0c39, 5); calld(0x100d_6a11, -0x5_a22d);          /* call 0x100d6a11 */
            ii(0x1013_0c3e, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1013_0c41, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_0c44, 6); mov(eax, memd_a32[ds, eax + 0xde]);     /* mov eax, [eax+0xde] */
            ii(0x1013_0c4a, 5); calld(0x100d_7f6c, -0x5_8ce3);          /* call 0x100d7f6c */
            ii(0x1013_0c4f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_0c52, 3); mov(al, memb_a32[ds, eax + 0x17]);      /* mov al, [eax+0x17] */
            ii(0x1013_0c55, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1013_0c58, 2); jmpd(0x1013_0c94, 0x3a); goto l_0x1013_0c94; /* jmp 0x10130c94 */
        l_0x1013_0c5a:
            ii(0x1013_0c5a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_0c5d, 5); calld(0x1012_fe49, -0xe19);             /* call 0x1012fe49 */
            ii(0x1013_0c62, 2); jmpd(0x1013_0caf, 0x4b); goto l_0x1013_0caf; /* jmp 0x10130caf */
        l_0x1013_0c64:
            ii(0x1013_0c64, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_0c67, 5); calld(0x1012_f31e, -0x194e);            /* call 0x1012f31e */
            ii(0x1013_0c6c, 2); jmpd(0x1013_0caf, 0x41); goto l_0x1013_0caf; /* jmp 0x10130caf */
        l_0x1013_0c6e:
            ii(0x1013_0c6e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_0c71, 5); calld(0x1013_0346, -0x930);             /* call 0x10130346 */
            ii(0x1013_0c76, 2); jmpd(0x1013_0caf, 0x37); goto l_0x1013_0caf; /* jmp 0x10130caf */
        l_0x1013_0c78:
            ii(0x1013_0c78, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_0c7b, 5); calld(0x1012_f672, -0x160e);            /* call 0x1012f672 */
            ii(0x1013_0c80, 2); jmpd(0x1013_0caf, 0x2d); goto l_0x1013_0caf; /* jmp 0x10130caf */
        l_0x1013_0c82:
            ii(0x1013_0c82, 2); jmpd(0x1013_0caf, 0x2b); goto l_0x1013_0caf; /* jmp 0x10130caf */
        //  ii(0x1013_0c84, 16); /* Служебная область с абсолютными адресами переходов. {0x1013_0c5a, 0x1013_0c64, 0x1013_0c6e, 0x1013_0c78}. */
        l_0x1013_0c94:
            ii(0x1013_0c94, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1013_0c97, 3); mov(memb_a32[ss, ebp - 0x2c], al);      /* mov [ebp-0x2c], al */
            ii(0x1013_0c9a, 4); cmp(memb_a32[ss, ebp - 0x2c], 0x3);     /* cmp byte [ebp-0x2c], 0x3 */
            ii(0x1013_0c9e, 2); if(jad(0x1013_0c82, -0x1e)) goto l_0x1013_0c82; /* ja 0x10130c82 */
            ii(0x1013_0ca0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_0ca2, 3); mov(al, memb_a32[ss, ebp - 0x2c]);      /* mov al, [ebp-0x2c] */
            ii(0x1013_0ca5, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_0ca8, 7); 
            switch (jmpd_abs_switch(memd_a32[cs, eax + 0x1013_0c84]))
            {
                case 0x1013_0c5a:
                    goto l_0x1013_0c5a;
                case 0x1013_0c64:
                    goto l_0x1013_0c64;
                case 0x1013_0c6e:
                    goto l_0x1013_0c6e;
                case 0x1013_0c78:
                    goto l_0x1013_0c78;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x10130c84] */
        l_0x1013_0caf:
            ii(0x1013_0caf, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1013_0cb3, 2); if(jzd(0x1013_0cbd, 0x8)) goto l_0x1013_0cbd; /* jz 0x10130cbd */
            ii(0x1013_0cb5, 3); mov(eax, memd_a32[ss, ebp - 0x16]);     /* mov eax, [ebp-0x16] */
            ii(0x1013_0cb8, 5); calld(Definitions.sys_display_draw_0, 0x3_67c7); /* call 0x10167484 */
        l_0x1013_0cbd:
            ii(0x1013_0cbd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_0cbf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_0cc0, 1); popd(edi);                              /* pop edi */
            ii(0x1013_0cc1, 1); popd(esi);                              /* pop esi */
            ii(0x1013_0cc2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_0cc3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_0cc4, 1); retd(); return;                         /* ret */
        }
    }
}
