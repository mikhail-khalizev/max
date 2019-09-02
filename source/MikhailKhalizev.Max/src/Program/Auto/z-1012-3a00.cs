using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_3a00-d364072")]
        public void Method_1012_3a00()
        {
            ii(0x1012_3a00, 5); push(0x48);                             /* push 0x48 */
            ii(0x1012_3a05, 5); call(Definitions.sys_check_available_stack_size, 0x4_2348); /* call 0x10165d52 */
            ii(0x1012_3a0a, 1); push(ebx);                              /* push ebx */
            ii(0x1012_3a0b, 1); push(esi);                              /* push esi */
            ii(0x1012_3a0c, 1); push(edi);                              /* push edi */
            ii(0x1012_3a0d, 1); push(ebp);                              /* push ebp */
            ii(0x1012_3a0e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_3a10, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1012_3a16, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_3a19, 7); cmp(memd[ds, eax + 164], 0);            /* cmp dword [eax+0xa4], 0x0 */
            ii(0x1012_3a20, 2); if(jz(0x1012_3a30, 0xe)) goto l_0x1012_3a30; /* jz 0x10123a30 */
            ii(0x1012_3a22, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_3a25, 6); mov(eax, memd[ds, eax + 164]);          /* mov eax, [eax+0xa4] */
            ii(0x1012_3a2b, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1012_3a2e, 2); jmp(0x1012_3a3c, 0xc); goto l_0x1012_3a3c; /* jmp 0x10123a3c */
        l_0x1012_3a30:
            ii(0x1012_3a30, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_3a33, 6); mov(eax, memd[ds, eax + 160]);          /* mov eax, [eax+0xa0] */
            ii(0x1012_3a39, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
        l_0x1012_3a3c:
            ii(0x1012_3a3c, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_3a3f, 6); mov(edx, memd[ds, eax + 132]);          /* mov edx, [eax+0x84] */
            ii(0x1012_3a45, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1012_3a48, 6); mov(eax, memd[ds, eax + 136]);          /* mov eax, [eax+0x88] */
            ii(0x1012_3a4e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_3a50, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1012_3a53, 4); cmp(memd[ss, ebp - 20], 0);             /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1012_3a57, 2); if(jnz(0x1012_3a65, 0xc)) goto l_0x1012_3a65; /* jnz 0x10123a65 */
            ii(0x1012_3a59, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_3a60, 5); jmp(0x1012_3b62, 0xfd); goto l_0x1012_3b62; /* jmp 0x10123b62 */
        l_0x1012_3a65:
            ii(0x1012_3a65, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1012_3a68, 3); cmp(memb[ds, eax], 0x20);               /* cmp byte [eax], 0x20 */
            ii(0x1012_3a6b, 2); if(jnz(0x1012_3a75, 8)) goto l_0x1012_3a75; /* jnz 0x10123a75 */
            ii(0x1012_3a6d, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1012_3a70, 3); inc(memd[ss, ebp - 20]);                /* inc dword [ebp-0x14] */
            ii(0x1012_3a73, 2); jmp(0x1012_3a65, -0x10); goto l_0x1012_3a65; /* jmp 0x10123a65 */
        l_0x1012_3a75:
            ii(0x1012_3a75, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1012_3a78, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1012_3a7a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_3a7f, 3); cmp(eax, 0xd);                          /* cmp eax, 0xd */
            ii(0x1012_3a82, 2); if(jnz(0x1012_3a90, 0xc)) goto l_0x1012_3a90; /* jnz 0x10123a90 */
            ii(0x1012_3a84, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_3a8b, 5); jmp(0x1012_3b62, 0xd2); goto l_0x1012_3b62; /* jmp 0x10123b62 */
        l_0x1012_3a90:
            ii(0x1012_3a90, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
        l_0x1012_3a97:
            ii(0x1012_3a97, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1012_3a9a, 3); cmp(eax, memd[ss, ebp - 4]);            /* cmp eax, [ebp-0x4] */
            ii(0x1012_3a9d, 2); if(jae(0x1012_3aae, 0xf)) goto l_0x1012_3aae; /* jae 0x10123aae */
            ii(0x1012_3a9f, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1012_3aa2, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1012_3aa4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_3aa9, 3); cmp(eax, 0xd);                          /* cmp eax, 0xd */
            ii(0x1012_3aac, 2); if(jnz(0x1012_3ab0, 2)) goto l_0x1012_3ab0; /* jnz 0x10123ab0 */
        l_0x1012_3aae:
            ii(0x1012_3aae, 2); jmp(0x1012_3ab8, 8); goto l_0x1012_3ab8; /* jmp 0x10123ab8 */
        l_0x1012_3ab0:
            ii(0x1012_3ab0, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1012_3ab3, 3); cmp(memb[ds, eax], 0x2c);               /* cmp byte [eax], 0x2c */
            ii(0x1012_3ab6, 2); if(jnz(0x1012_3aba, 2)) goto l_0x1012_3aba; /* jnz 0x10123aba */
        l_0x1012_3ab8:
            ii(0x1012_3ab8, 2); jmp(0x1012_3ac2, 8); goto l_0x1012_3ac2; /* jmp 0x10123ac2 */
        l_0x1012_3aba:
            ii(0x1012_3aba, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1012_3abd, 3); cmp(memb[ds, eax], 0x20);               /* cmp byte [eax], 0x20 */
            ii(0x1012_3ac0, 2); if(jnz(0x1012_3ac4, 2)) goto l_0x1012_3ac4; /* jnz 0x10123ac4 */
        l_0x1012_3ac2:
            ii(0x1012_3ac2, 2); jmp(0x1012_3ad8, 0x14); goto l_0x1012_3ad8; /* jmp 0x10123ad8 */
        l_0x1012_3ac4:
            ii(0x1012_3ac4, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1012_3ac7, 3); inc(memd[ss, ebp - 20]);                /* inc dword [ebp-0x14] */
            ii(0x1012_3aca, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1012_3acd, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
            ii(0x1012_3ad0, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1012_3ad2, 4); mov(memb[ds, edx + ebp - 52], al);      /* mov [edx+ebp-0x34], al */
            ii(0x1012_3ad6, 2); jmp(0x1012_3a97, -0x41); goto l_0x1012_3a97; /* jmp 0x10123a97 */
        l_0x1012_3ad8:
            ii(0x1012_3ad8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_3adb, 5); mov(memb[ds, eax + ebp - 52], 0);       /* mov byte [eax+ebp-0x34], 0x0 */
            ii(0x1012_3ae0, 4); cmp(memd[ss, ebp - 8], 0);              /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1012_3ae4, 2); if(jnz(0x1012_3af2, 0xc)) goto l_0x1012_3af2; /* jnz 0x10123af2 */
            ii(0x1012_3ae6, 7); mov(memd[ss, ebp - 12], 0);             /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_3aed, 5); jmp(0x1012_3b62, 0x70); goto l_0x1012_3b62; /* jmp 0x10123b62 */
        l_0x1012_3af2:
            ii(0x1012_3af2, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1012_3af5, 3); cmp(eax, memd[ss, ebp - 4]);            /* cmp eax, [ebp-0x4] */
            ii(0x1012_3af8, 2); if(jae(0x1012_3b02, 8)) goto l_0x1012_3b02; /* jae 0x10123b02 */
            ii(0x1012_3afa, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1012_3afd, 3); cmp(memb[ds, eax], 0x20);               /* cmp byte [eax], 0x20 */
            ii(0x1012_3b00, 2); if(jz(0x1012_3b04, 2)) goto l_0x1012_3b04; /* jz 0x10123b04 */
        l_0x1012_3b02:
            ii(0x1012_3b02, 2); jmp(0x1012_3b0c, 8); goto l_0x1012_3b0c; /* jmp 0x10123b0c */
        l_0x1012_3b04:
            ii(0x1012_3b04, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1012_3b07, 3); inc(memd[ss, ebp - 20]);                /* inc dword [ebp-0x14] */
            ii(0x1012_3b0a, 2); jmp(0x1012_3af2, -0x1a); goto l_0x1012_3af2; /* jmp 0x10123af2 */
        l_0x1012_3b0c:
            ii(0x1012_3b0c, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1012_3b0f, 3); cmp(memb[ds, eax], 0x2c);               /* cmp byte [eax], 0x2c */
            ii(0x1012_3b12, 2); if(jnz(0x1012_3b25, 0x11)) goto l_0x1012_3b25; /* jnz 0x10123b25 */
            ii(0x1012_3b14, 3); inc(memd[ss, ebp - 20]);                /* inc dword [ebp-0x14] */
            ii(0x1012_3b17, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1012_3b1a, 3); mov(edx, memd[ss, ebp + 20]);           /* mov edx, [ebp+0x14] */
            ii(0x1012_3b1d, 6); mov(memd[ds, edx + 164], eax);          /* mov [edx+0xa4], eax */
            ii(0x1012_3b23, 2); jmp(0x1012_3b31, 0xc); goto l_0x1012_3b31; /* jmp 0x10123b31 */
        l_0x1012_3b25:
            ii(0x1012_3b25, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1012_3b28, 3); mov(edx, memd[ss, ebp + 20]);           /* mov edx, [ebp+0x14] */
            ii(0x1012_3b2b, 6); mov(memd[ds, edx + 164], eax);          /* mov [edx+0xa4], eax */
        l_0x1012_3b31:
            ii(0x1012_3b31, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_3b33, 3); mov(al, memb[ss, ebp - 51]);            /* mov al, [ebp-0x33] */
            ii(0x1012_3b36, 3); cmp(eax, 0x78);                         /* cmp eax, 0x78 */
            ii(0x1012_3b39, 2); if(jnz(0x1012_3b48, 0xd)) goto l_0x1012_3b48; /* jnz 0x10123b48 */
            ii(0x1012_3b3b, 3); lea(eax, memd[ss, ebp - 50]);           /* lea eax, [ebp-0x32] */
            ii(0x1012_3b3e, 5); call(0x1012_47af, 0xc6c);               /* call 0x101247af */
            ii(0x1012_3b43, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1012_3b46, 2); jmp(0x1012_3b53, 0xb); goto l_0x1012_3b53; /* jmp 0x10123b53 */
        l_0x1012_3b48:
            ii(0x1012_3b48, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x1012_3b4b, 5); call(/* sys */ 0x1017_90ce, 0x5_557e);  /* call 0x101790ce */
            ii(0x1012_3b50, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
        l_0x1012_3b53:
            ii(0x1012_3b53, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1012_3b56, 3); mov(edx, memd[ss, ebp + 24]);           /* mov edx, [ebp+0x18] */
            ii(0x1012_3b59, 2); mov(memd[ds, edx], eax);                /* mov [edx], eax */
            ii(0x1012_3b5b, 7); mov(memd[ss, ebp - 12], 1);             /* mov dword [ebp-0xc], 0x1 */
        l_0x1012_3b62:
            ii(0x1012_3b62, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_3b65, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_3b67, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_3b68, 1); pop(edi);                               /* pop edi */
            ii(0x1012_3b69, 1); pop(esi);                               /* pop esi */
            ii(0x1012_3b6a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_3b6b, 1); ret();                                  /* ret */
        }
    }
}
